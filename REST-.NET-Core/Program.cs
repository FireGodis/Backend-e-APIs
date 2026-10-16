var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var tasks = new List<TaskItem>();

app.MapGet("/tasks", () => Results.Ok(tasks));
app.MapPost("/tasks", (CreateTask request) =>
{
    if (string.IsNullOrWhiteSpace(request.Title))
        return Results.BadRequest(new { error = "title é obrigatório" });

    var task = new TaskItem(Guid.NewGuid(), request.Title.Trim(), false);
    tasks.Add(task);
    return Results.Created($"/tasks/{task.Id}", task);
});

app.Run();

record TaskItem(Guid Id, string Title, bool Done);
record CreateTask(string Title);
