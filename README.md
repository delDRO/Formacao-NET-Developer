# 💻 Formação .NET Developer - Desafios de Projeto (DIO)

Este repositório contém a resolução dos desafios de projeto desenvolvidos durante o bootcamp **Formação .NET Developer** da [Digital Innovation One (DIO)](https://www.dio.me). Os projetos cobrem desde os fundamentos da linguagem C# até conceitos avançados de Programação Orientada a Objetos (POO).

---

## 📂 Estrutura do Repositório

O repositório é dividido nas seguintes pastas, cada uma representando um desafio específico:

| Projeto / Desafio | Descrição | Tecnologias / Conceitos |
| :--- | :--- | :--- |
| [🚗 Desafio Fundamentos](./Desafio%20Fundamentos/) | Sistema de gerenciamento de um estacionamento para controlar a entrada, saída e tarifas de veículos. | C#, Lógica de Programação, Estruturas de Repetição, Coleções |
| [🏨 Desafio de Hospedagem](./Desafio%20de%20projeto-Construindo%20um%20sistema%20de%20hospedagem%20de%20um%20hotel%20no%20C%23/) | Sistema de reservas para um hotel com validação de capacidade de suítes e cálculo de diárias com desconto. | C#, Coleções, Manipulação de Strings, Operadores, Exceções |
| [📱 Desafio POO](./Desafio-Programação-Orientada%20a%20Objetos/) | Modelagem do comportamento de smartphones (Nokia e iPhone) utilizando herança, encapsulamento e polimorfismo. | C#, Programação Orientada a Objetos (POO), Herança, Abstração |

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

---

## 🚀 Como Executar os Projetos

### Pré-requisitos
Certifique-se de ter instalado em sua máquina:
* [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior recomendada)

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
