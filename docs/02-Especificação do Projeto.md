# Especificações do Projeto


## Personas
## Amanda Alves

  Idade:41<br>
Ocupação: advogada, é sócia de um pequeno escritório que atua em processos de fusões de empresas.<br/>
Metas:<br/>
●	Comprar uma casa<br/>
Motivações:<br/>
●	Deseja controlar melhor seus gastos<br/>
●	Saber quanto gasta com dinheiro físico<br/>
Frustrações:<br/>
●	Não consegue ter uma boa saúde financeira<br/>
Características principais:<br/>
●	Não gosta de fazer comida, usuária frequente de apps de delivery.<br/>
●	Se o banco existe, ela tem conta e cartão.<br/>


## Carlos Gomes<br/>
Idade: 41<br/>
Ocupação: Engenheiro de Produção, funcionário de uma multinacional do setor da indústria automotiva<br/>
Metas:<br/>
●	Sobrar mais dinheiro para viajar com a família.<br/>

Motivações:<br/>
●	Deseja melhorar a relação financeira com sua esposa.<br/>
●	Gostaria de controlar melhor seus gastos no cartão de crédito.<br/>
●	Parar de pagar contas com multa<br/>
Frustrações:<br/>
●	Paga boa parte das contas da casa sozinho, por se perder em prazos<br/>
●	Se assusta todos os meses com seus gastos no cartão<br/>
Características principais:<br/>
●	Desorganizado.<br/>
●	Não consegue se expressar ou pedir ajuda financeira corretamente.<br/>








 	
## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Amanda Alves  |   visualizar o quanto gasta com dinheiro físico mensalmente       |    tomar ciência do quanto ela gasta sem perceber         |
|  Amanda Alves     | saber de uma maneira fácil como estão seus gastos em todos os seus cartões.                 | ter um maior controle das suas finanças. |
|Carlos Gomes |conseguir compartilhar suas contas com sua esposa|não ter que arcar com todos os custos sozinho.|
|Carlos Gomes|ver as datas e local onde consegue emitir e pagar seus boletos.|não pagar mais multas com contas atrasadas.|
|Amanda Alves|perceber qual cartão ela utiliza mais e qual utiliza menos.|diminuir a quantidade cartões para ter uma melhor relação com um banco em específico.|
|Carlos	Gomes	/ Amanda Alves|descobrir com oque gasta mais.|	ter um maior controle das suas finanças.|



## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RF-01|	O site deve apresentar cadastro e login dos seus usuários.|	Alta|
|RF-02|	O site deve apresentar, um crud para adição de boletos, com data de vencimento, nome e local onde ele é gerado.|	Alta|
|RF-03|	O site deve apresentar, um crud para adição de cartões, com data de vencimento, nome e banco.|	Média
|RF-04|O site deve apresentar, um crud para adição de grupos de custo, nome, integrantes e contas compartilhadas e banco.	|Alta|
|RF-05|	O site deve apresentar, um crud para adição de gastos nos cartões, com data de vencimento, nome e tipo de gasto.|	Média|
|RF-06|	O site deve gerar um relatório apontando quais gastos ocorrem mais, de acordo com seu tipo.|	Baixa|



### Requisitos não Funcionais
|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RNF-02|	O site deverá ser responsivo permitindo a visualização em um celular de forma adequada|	Alta|
|RNF-03|O site deve ter bom nível de contraste entre os elementos da tela em conformidade|	Média|
|RE-04|	O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge)| Alta|



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01|	O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 07/07/2020.|
|RE-02|	O aplicativo deve se restringir às tecnologias básicas da Web no Frontend|
|RE-03|	A equipe não pode subcontratar o desenvolvimento do trabalho.|
|Re-04|	O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);|	
    




## Diagrama de Casos de Uso

![Captura de tela 2024-03-15 204050](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t9-pmv-ads-2024-1-e2-proj-gestaocontas/blob/main/docs/img/Casos%20de%20uso.jpg)

