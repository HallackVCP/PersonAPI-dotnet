# Criação de API da Entidade Pessoa em .NET 7.0

Este repositório contém a criação de uma API da entidade Pessoa utilizando .NET 7.0. A API foi desenvolvida com o auxílio do Entity Framework e utiliza um banco de dados em memória.

## Requisitos

Antes de executar o projeto, certifique-se de que você tenha os seguintes requisitos instalados:

- .NET SDK 7.0 ou superior
- Execute a aplicação:
- Agora a API da entidade Pessoa estará disponível e pode ser acessada localmente em `http://localhost:5000`.

## Endpoints

A API oferece os seguintes endpoints:

- `GET /api/Person`: Retorna a lista de todas as pessoas cadastradas.
- `GET /api/Person/{id}`: Retorna os detalhes de uma pessoa específica com base no ID fornecido.
- `POST /api/Person`: Adiciona uma nova pessoa à base de dados. Certifique-se de enviar os dados corretamente no corpo da solicitação.
- `PUT /api/Person/{id}`: Atualiza as informações de uma pessoa existente com base no ID fornecido. Novos dados devem ser enviados no corpo da solicitação.
- `DELETE /api/Person/{id}`: Remove uma pessoa da base de dados com base no ID fornecido.

Certifique-se de fornecer os dados corretamente formatados para as operações POST e PUT.
