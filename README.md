# Teste BackEnd - Criando Web API com ASP.NET CORE

### Conexão com SQL SERVER

* Localize 'appsettings.json'.
* Dentro de "ConnectionStrings" troque o valor dentro de "Default" para a sua conexão com o banco.
* Exemplo da query de conexão: "Password={senha};Persist Security Info=True;User ID={Usuario};Initial Catalog={Banco};Data Source={Servidor}"

### Seeders

* Dentro da pasta Data localizada na raiz do projeto, encontra-se os seeders
* Para alimentar o banco com estes seeders utilize as migrations

### Migrations

* No seu terminal digite `` dotnet ef migrations add initial ``
* Após o primeiro passo, digite `` dotnet ef database update ``

### Swagger
* Execute a API
* No seu navegador, digite na url `http://localhost:5000`
* Caso o link acima não funcione e estiver usando Visual Studio 2019, use `http://localhost:10907`
* Ira abrir um Swagger com a documentação da API.

### Endpoints
* [GET]     /api/cliente - Método responsável por retornar todos os clientes
* [GET]     /api/cliente/{id} - Método responsável por retornar apenas um unico cliente pelo Código Id
* [GET]     /api/cliente/ByName - Método responsável por retornar apenas um unico cliente pelo Nome
* [POST]    /api/cliente - Método responsável por cadastrar clientes no banco de dados
* [PUT]     /api/cliente/{id} - Método responsável por atualizar o cliente por meio do Código Id
* [PATCH]   /api/cliente/{id} - Método responsável por atualizar o meu cliente por meio do código id
* [DELETE]  /api/cliente/{id} - Método responsável por delete um cliente por meio do código Id

Alinhado a esquerda | Centralizado | Alinhado a direita
:--------- | :------: | -------:
Valor | Valor | Valor

## Observações para os recrutadores
Encontrei dificuldades para fazer o frontend, e no fim não consegui finalizar 50% dele, por isso acabei desconsiderando... Mas caso sirva para algo, poderá encontrar aqui <github.com/RenanOrtega/CRUDApp>
