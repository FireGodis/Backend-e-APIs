from fastapi import FastAPI
from pydantic import BaseModel

app = FastAPI(title="Catálogo de estudos")

class StudyItem(BaseModel):
    title: str
    technology: str

items: list[StudyItem] = []

@app.get("/items", response_model=list[StudyItem])
def list_items():
    return items

@app.post("/items", response_model=StudyItem, status_code=201)
def create_item(item: StudyItem):
    items.append(item)
    return item
