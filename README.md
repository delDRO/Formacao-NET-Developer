# 💻 Formação .NET Developer - Desafios de Projeto (DIO)

Este repositório contém a resolução dos desafios de projeto desenvolvidos durante o bootcamp **Formação .NET Developer** da [Digital Innovation One (DIO)](https://www.dio.me). Os projetos cobrem desde os fundamentos da linguagem C# até conceitos avançados de APIs REST com Entity Framework e consultas relacionais em SQL Server.

---

## 📂 Estrutura do Repositório

O repositório é dividido nas seguintes pastas, cada uma representando um desafio específico:

| Projeto / Desafio | Descrição | Tecnologias / Conceitos |
| :--- | :--- | :--- |
| [🚗 Desafio Fundamentos](./Desafio%20Fundamentos/) | Sistema de gerenciamento de um estacionamento para controlar a entrada, saída e tarifas de veículos. | C#, Lógica de Programação, Estruturas de Repetição, Coleções |
| [🏨 Desafio de Hospedagem](./Desafio%20de%20projeto-Construindo%20um%20sistema%20de%20hospedagem%20de%20um%20hotel%20no%20C%23/) | Sistema de reservas para um hotel com validação de capacidade de suítes e cálculo de diárias com desconto. | C#, Coleções, Manipulação de Strings, Operadores, Exceções |
| [📱 Desafio POO](./Desafio-Programação-Orientada%20a%20Objetos/) | Modelagem do comportamento de smartphones (Nokia e iPhone) utilizando herança, encapsulamento e polimorfismo. | C#, POO, Herança, Abstração |
| [📋 Desafio API + Entity Framework](./Desafio-API_Entity_framework/) | Sistema Gerenciador de Tarefas com CRUD completo via Web API RESTful e banco de dados SQLite gerenciado pelo EF Core. | ASP.NET Core, Entity Framework Core, SQLite, Swagger |
| [🗃️ Desafio SQL Server](./Desafios%20de%20Projeto%20Montando%20consultas%20relacionais%20no%20SQL%20Server/) | Consultas relacionais em SQL Server baseadas nos desafios propostos pela DIO, abrangendo JOINs, agregações e filtros. | SQL Server, T-SQL, Consultas Relacionais, JOINs |

---

## 🛠️ Detalhes dos Desafios

### 1. [Desafio Fundamentos](./Desafio%20Fundamentos/)
* **Objetivo:** Desenvolver uma aplicação de console que gerencie o fluxo de um estacionamento.
* **Funcionalidades:**
  * Cadastrar placa de veículo.
  * Listar todos os veículos atualmente estacionados.
  * Remover veículo e calcular o valor cobrado com base na tarifa: `Preço Inicial + (Preço por Hora * Horas Estacionadas)`.

### 2. [Desafio de Hospedagem](./Desafio%20de%20projeto-Construindo%20um%20sistema%20de%20hospedagem%20de%20um%20hotel%20no%20C%23/)
* **Objetivo:** Criar um sistema de hotelaria para gerenciar hóspedes, suítes e reservas.
* **Funcionalidades:**
  * Associar hóspedes a uma reserva e uma suíte específica.
  * Validar se a capacidade da suíte comporta o número de hóspedes (lança exceção caso exceda).
  * Calcular o valor total da hospedagem aplicando desconto de 10% para reservas de 10 dias ou mais.

### 3. [Desafio POO](./Desafio-Programação-Orientada%20a%20Objetos/)
* **Objetivo:** Abstrair o comportamento de celulares utilizando herança e polimorfismo em C#.
* **Funcionalidades:**
  * Implementação da classe abstrata `Smartphone`.
  * Criação das classes derivadas `Nokia` e `Iphone`.
  * Sobrescrita do método abstrato `InstalarAplicativo` para comportamentos específicos de cada marca.

### 4. [Desafio API + Entity Framework](./Desafio-API_Entity_framework/)
* **Objetivo:** Construir um **Sistema Gerenciador de Tarefas** com CRUD completo usando ASP.NET Core Web API e Entity Framework Core.
* **Tecnologias:** ASP.NET Core (.NET 10), Entity Framework Core, SQLite, Swagger/OpenAPI.
* **Funcionalidades:**
  * Endpoints REST para criar, listar, buscar, atualizar e deletar tarefas (`POST`, `GET`, `PUT`, `DELETE`).
  * Filtros de busca por **título**, **data** e **status** (Pendente, Em Andamento, Concluído).
  * Banco de dados **SQLite** criado automaticamente na inicialização via `Database.Migrate()`.
  * Documentação interativa disponível via **Swagger UI**.
* **Para executar:**
  ```bash
  cd Desafio-API_Entity_framework/TarefasApi
  dotnet run
  ```
  Acesse `https://localhost:{porta}/swagger` para explorar os endpoints.

### 5. [Desafio SQL Server](./Desafios%20de%20Projeto%20Montando%20consultas%20relacionais%20no%20SQL%20Server/)
* **Objetivo:** Desenvolver consultas relacionais no SQL Server com resultados equivalentes aos propostos no desafio da DIO.
* **Referência:** [Repositório oficial do desafio](https://github.com/digitalinnovationone/trilha-net-banco-de-dados-desafio)
* **Conceitos praticados:**
  * Consultas com `JOIN` entre múltiplas tabelas.
  * Uso de funções de agregação (`COUNT`, `SUM`, `AVG`).
  * Filtros com `WHERE`, `GROUP BY` e `ORDER BY`.

---

## 🚀 Como Executar os Projetos

### Pré-requisitos
Certifique-se de ter instalado em sua máquina:
* [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior recomendada)
* [SQL Server](https://www.microsoft.com/sql-server) (para o desafio de banco de dados)

### Instruções para rodar localmente
1. Clone este repositório em sua máquina:
   ```bash
   git clone https://github.com/seu-usuario/Formacao-NET-Developer.git
   ```
2. Navegue até a pasta do desafio desejado, por exemplo:
   ```bash
   cd "Desafio Fundamentos"
   ```
3. Restaure as dependências e execute o projeto:
   ```bash
   dotnet run
   ```

---

## 🎓 Sobre a Formação
A **Formação .NET Developer** da DIO é focada no desenvolvimento de software backend utilizando C# e a plataforma .NET. O programa aborda desde a sintaxe básica até o desenvolvimento de APIs robustas com ASP.NET Core, testes de software, integração com bancos de dados (SQL Server, Entity Framework) e boas práticas de arquitetura.
