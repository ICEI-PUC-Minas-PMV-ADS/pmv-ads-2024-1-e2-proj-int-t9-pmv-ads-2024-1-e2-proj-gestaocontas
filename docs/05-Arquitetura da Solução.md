# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER (Projeto Conceitual)

![DER Money master](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t9-pmv-ads-2024-1-e2-proj-gestaocontas/assets/145507947/0dd7f129-7f05-41bd-a7d4-ab2b9861b8ce)


## Projeto da Base de Dados
Entidades:
1. Usuário
   - CPF (chave primária)
   - Nome
   - Email
   - Senha

2. Cartão de Crédito
   - Nome do Titular
   - Data de Vencimento
   - Bandeira do cartão 
   - 4 ultimos digitos do cartão
   - Tipo de gastos
   - Descrição
   - CPF_Usuário (chave estrangeira)

3. Boleto Bancário
   - Código do Boleto (chave primária)
   - Data de Vencimento
   - Valor
   - link para o boleto
   - Tipo de gastos
   - Descrição
   - CPF_Usuário (chave estrangeira)

4. Dinheiro Físico/Pix
   - ID (chave primária)
   - Valor
   - Tipo de gasto
   - Descrição
   - CPF_Usuário (chave estrangeira)

5. Grupo de Finanças
   - ID_Grupo (chave primária)
   - Nome do Grupo
   - Data da transação
   - Tipo de gasto
   - Descrição

6. Registro de gastos
   - ID_Registro (chave primária)
   - Data
   - Valor_Cartão de crédito,Dinheiro físico pix,Boleto(Chave estrageira)
   - tipo de gastos
   - descrição
   - CPF_Usuário (chave estrangeira)
   - ID_Grupo (chave estrangeira)

Relacionamentos:
- Um Usuário pode ter vários Cartões de Crédito, Boletos Bancários e Dinheiro Físico.
- Um Usuário pode pertencer a vários Grupos de Finanças.
- Um Registro de gastos Registra todos os gastos todos os gastos de um Usuário ou de um Grupo de Finanças.

Atributos de Relacionamento:
- 
-


## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
