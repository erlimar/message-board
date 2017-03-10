Modelo de dados
===============

## Objetos

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

## API

URL: http://message-board-app.e5r.tech

Métodos disponíveis na API:

### Obtendo a lista de mensagens

Obtem a lista com todas as mensagens disponíveis.
#### Request:
```http
GET /message HTTP/1.1
Host: message-board-app.e5r.tech
Accept: application/json


```

#### Response:
```http
Status: 200
Content-Type: application/json; charset=utf-8
Content-Length: ...

[Message, ...]
```

### Adicionando uma nova mensagem no mural

Adiciona uma mensagem no mural que pode ser obtida pelos demais usuaios.

#### Request:
```http
POST /message HTTP/1.1
Host: message-board-app.e5r.tech
Content-Type: application/json; charset=utf-8
Accept: application/json
Content-Length: ...

{
    "createdBy": "User name",
    "title": "Title of message",
    "body": "Content message"
}
```

#### Response:
```http
Status: 201
Content-Type: text/plain; charset=utf-8
Content-Length: ...

Created
```

### Marcando uma mensagem como lida

Marca uma mensagem como lida por um determinado usuário.

#### Request:
```http
PUT /message HTTP/1.1
Host: message-board-app.e5r.tech
Content-Type: application/json; charset=utf-8
Accept: application/json
Content-Length: ...

{
    "id": "",
    "readBy": "Nome do usuário"
}
```

#### Response:
```http
Status: 200
Content-Type: text/plain; charset=utf-8
Content-Length: ...

OK
```
