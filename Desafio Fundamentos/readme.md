#  Criação de estacionamento — DIO

# 🚗 Sistema de Gerenciamento de Estacionamento

Este projeto é a resolução de um desafio de código, onde o objetivo foi desenvolver um sistema dinâmico para gerenciar os veículos de um estacionamento. O sistema é capaz de adicionar, listar e remover veículos, além de calcular o valor total a ser pago com base nas horas de permanência.

---

## 🛠️ Funcionalidades

O sistema conta com as seguintes operações:

1. **Cadastrar veículo:** O usuário digita a placa do veículo para inseri-lo no sistema.
2. **Listar veículos:** Exibe na tela todos os veículos que estão estacionados no momento. Se não houver nenhum, o sistema avisa que o estacionamento está vazio.
3. **Remover veículo:** O usuário digita a placa do veículo que está saindo e a quantidade de horas que ele permaneceu estacionado. O sistema calcula automaticamente o valor total com base na fórmula:
   
   $$\text{Preço Inicial} + (\text{Preço por Hora} \times \text{Horas Estacionadas})$$
   
   Após o cálculo, o valor é exibido na tela e o veículo é removido da lista.

---

## 🚀 Tecnologias Utilizadas

* **Linguagem:** C# 
* **Paradigma:** Orientação a Objetos (se aplicável)
* **Ambiente de Execução:** Console / Terminal