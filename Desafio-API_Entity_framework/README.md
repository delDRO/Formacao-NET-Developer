# 📋 Sistema Gerenciador de Tarefas — Web API + Entity Framework

[![.NET](https://img.shields.io/badge/.NET-10.0-purple)](https://dotnet.microsoft.com/)
[![EF Core](https://img.shields.io/badge/EF%20Core-10.0-blue)](https://docs.microsoft.com/ef/core/)
[![SQLite](https://img.shields.io/badge/SQLite-Database-lightblue)](https://www.sqlite.org/)
[![Swagger](https://img.shields.io/badge/Swagger-OpenAPI-green)](https://swagger.io/)

## 📌 Sobre o Desafio

Este projeto foi desenvolvido como parte do **Desafio de Projeto** da trilha **.NET da DIO (Digital Innovation One)**, módulo **API e Entity Framework**.

O objetivo é construir um **Sistema Gerenciador de Tarefas** com CRUD completo utilizando **ASP.NET Core Web API** e **Entity Framework Core**.

---

## 🏗️ Estrutura do Projeto

```
TarefasApi/
├── Context/
│   └── OrganizadorContext.cs       # DbContext do Entity Framework
├── Controllers/
│   └── TarefaController.cs         # Controller com todos os endpoints
├── Entities/
│   ├── Tarefa.cs                   # Entidade principal
│   └── EnumStatusTarefa.cs         # Enum de status da tarefa
├── Migrations/                     # Migrations geradas pelo EF Core
├── appsettings.json                # Configurações (Connection String SQLite)
└── Program.cs                      # Configuração da aplicação
```

---

## 🚀 Tecnologias Utilizadas

| Tecnologia | Versão | Uso |
|------------|--------|-----|
| ASP.NET Core | .NET 10 | Framework Web API |
| Entity Framework Core | 10.x | ORM para acesso a dados |
| SQLite | - | Banco de dados local |
| Swashbuckle / Swagger | 10.x | Documentação interativa da API |

---

## 📦 Entidade Tarefa

```csharp
public class Tarefa
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public DateTime Data { get; set; }
    public EnumStatusTarefa Status { get; set; }
}
```

### Status Disponíveis (`EnumStatusTarefa`)

| Valor | Nome | Descrição |
|-------|------|-----------|
| `0` | Pendente | Tarefa aguardando início |
| `1` | EmAndamento | Tarefa em execução |
| `2` | Concluido | Tarefa finalizada |

---

## 🔌 Endpoints da API

| Método | Rota | Descrição |
|--------|------|-----------|
| `POST` | `/Tarefa` | Criar uma nova tarefa |
| `GET` | `/Tarefa/{id}` | Obter tarefa por ID |
| `GET` | `/Tarefa/ObterTodos` | Listar todas as tarefas |
| `GET` | `/Tarefa/ObterPorTitulo?titulo=xxx` | Buscar tarefas por título |
| `GET` | `/Tarefa/ObterPorData?data=2024-01-01` | Buscar tarefas por data |
| `GET` | `/Tarefa/ObterPorStatus?status=0` | Buscar tarefas por status |
| `PUT` | `/Tarefa/{id}` | Atualizar uma tarefa existente |
| `DELETE` | `/Tarefa/{id}` | Deletar uma tarefa |

---

## ▶️ Como Executar o Projeto

### Pré-requisitos

- [.NET SDK 10+](https://dotnet.microsoft.com/download)

### Passos

1. **Clone ou navegue até a pasta do projeto:**
   ```bash
   cd Desafio-API_Entity_framework/TarefasApi
   ```

2. **Execute a aplicação:**
   ```bash
   dotnet run
   ```
   > ⚠️ O banco de dados SQLite será criado automaticamente na primeira execução via `db.Database.Migrate()`.

3. **Acesse o Swagger UI:**
   ```
   https://localhost:{porta}/swagger
   ```

---

## 🧪 Exemplos de Uso

### Criar uma tarefa (POST /Tarefa)

```json
{
  "titulo": "Estudar Entity Framework",
  "descricao": "Aprender sobre DbContext, Migrations e LINQ",
  "data": "2024-01-15T10:00:00",
  "status": 0
}
```

### Atualizar uma tarefa (PUT /Tarefa/1)

```json
{
  "titulo": "Estudar Entity Framework",
  "descricao": "Concluído! Aprendi sobre DbContext, Migrations e LINQ",
  "data": "2024-01-15T10:00:00",
  "status": 2
}
```

---

## 📖 Conceitos Aplicados

- ✅ **Web API RESTful** com ASP.NET Core
- ✅ **Entity Framework Core** com Code-First Migrations
- ✅ **SQLite** como banco de dados local
- ✅ **CRUD completo** (Create, Read, Update, Delete)
- ✅ **Filtros de busca** por título, data e status
- ✅ **Injeção de Dependência** (Dependency Injection)
- ✅ **Swagger / OpenAPI** para documentação interativa
- ✅ **Respostas HTTP semânticas** (200, 201, 204, 400, 404)
- ✅ **Banco de dados auto-criado** na inicialização

---

## 📁 Banco de Dados

O arquivo `TarefasOrganizador.db` (SQLite) é gerado automaticamente na pasta do projeto ao iniciar a aplicação pela primeira vez.

---

*Projeto desenvolvido como parte da Formação .NET Developer — Digital Innovation One (DIO)*
