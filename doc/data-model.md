Modelo de dados
===============

O objeto principal do App é a mensagem.

```js
Message = {
    "id": {
        "type": "string",
        "description": "Identificação (GUID) do recado" },
    "createdBy": {
        "type": "string",
        "description": "Nome de quem criou o recado" },
    "createdIn": {
        "type": "GMT",
        "description": "Data/Hora de criação" },
    "title:" {
        "type": "string",
        "description": "Título da mensagem" },
    "body": {
        "type": "string",
        "description": "Corpo da mensagem" }
}
```
