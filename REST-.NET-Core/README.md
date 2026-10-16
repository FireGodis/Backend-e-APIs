# API de tarefas com ASP.NET Core

Eu desenvolvi esta API REST em C# e ASP.NET Core para praticar endpoints HTTP, JSON e validação simples. O exemplo mantém os dados em memória para facilitar a execução local.

## Como executar

```bash
dotnet run
```

A API oferece `GET /tasks` e `POST /tasks`. Para criar uma tarefa, envio JSON com o campo `title`.

## O que pratiquei

- Rotas REST e verbos HTTP
- Serialização JSON e códigos de resposta
- Separação simples entre validação e endpoint

Este é um exemplo local; os dados são apagados quando o processo termina.
