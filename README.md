# streaming-flix-xunit
Atividade 24 - Realizada por Cauã Parreiras Vieira; Maria Luisa de Carmo Cardoso; Yasmim Aparecida Souza de Paula
# StreamingFlix

## Visão Geral

O StreamingFlix é uma aplicação desenvolvida em .NET 10 para gerenciamento de regras de planos de streaming.

A aplicação possui regras para:

- Classificação dos planos de acordo com o número de telas simultâneas.
- Cálculo da mensalidade com descontos de acordo com o período contratado.
- Controle de acesso a conteúdo adulto.

O projeto também possui testes unitários utilizando xUnit para validar as regras implementadas.

## Equipe

Projeto desenvolvido por:

- **CAUÃ PARREIRAS VIEIRA** – RA: 32516918
- **MARIA LUÍSA DO CARMO CARDOSO** – RA: 325116932
- **YASMIN APARECIDA SOUZA DE PAULA** – RA: 32612974

## Cobertura dos Testes
Os testes verificam as principais regras da aplicação:
Classificação dos Planos
- 1 tela: BÁSICO
- 2 telas: PADRÃO
- 4 ou mais telas: PREMIUM
Cálculo de Desconto
- Menos de 6 meses: sem desconto
- De 6 a 11 meses: 10% de desconto
- 12 meses ou mais: 20% de desconto
Acesso a Conteúdo Adulto
O acesso é permitido somente quando:
- A idade é igual ou superior a 18 anos.
- O controle parental está desativado.
Os testes utilizam diferentes cenários para garantir que essas regras funcionem corretamente.

## Requisitos

- .NET 10 SDK
- Git

## Como Clonar o Projeto

Abra um terminal e execute:

```bash
git clone https://github.com/SEU-USUARIO/streaming-flix-xunit.git

