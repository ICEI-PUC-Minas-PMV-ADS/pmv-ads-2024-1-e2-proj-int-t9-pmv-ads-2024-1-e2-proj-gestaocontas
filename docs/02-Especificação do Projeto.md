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

## Maria Silva
  Idade:35<br>
Ocupação: Auxiliar administrativa, trabalha com Freelancer por ter perdido o emprego durante a pandemia<br/>
Metas:<br/>
●	Pagar dividas acumuladas e começar a economizar para emergências e objetivos futuros.<br/>

Motivações:<br/>
●	Renda instável como freelancer.<br/>
●	Aprender a gerenciar melhor sua renda e despesas mensais.<br/>
●	Entender mais sobre investimentos e encontrar maneiras de fazer seu dinheiro crescer de forma segura.  <br/>

Frustrações:<br/>
● Dívidas acumuladas devido a contas não pagas durante a fase de desemprego.<br/>
● Dificuldade em economizar e planejar o orçamento mensal de forma eficaz.<br/>
● Falta de conhecimento sobre investimentos e como fazer o dinheiro render.<br/>

Características principais:<br/>
● Introvertida.<br/>
● Esquece de coisas importantes.<br/>

## Ana Beatriz
Idade: 22 anos<br>
Ocupação: Estudante Universitária<br/>
Metas:<br>
● Concluir a faculdade sem dívidas.<br>
● Economizar para um intercâmbio no próximo ano.<br>
● Aprender a investir e construir um fundo de emergência.<br>

Motivações:<br>
● Busca independência financeira.<br>
● Deseja evitar dívidas e juros.<br>
● Quer aproveitar oportunidades de crescimento pessoal.<br>

Frustrações:<br>
● Lida com orçamento apertado devido às despesas estudantis.<br>
● Fica ansiosa com a falta de controle sobre suas finanças.<br>
● Acha difícil equilibrar estudos, trabalho e vida financeira.<br>

Características Principais:<br>
● Estudante universitária.<br>
● Curiosa e disposta a aprender sobre finanças.<br>

## Carlos Augusto
Idade: 35 anos.<br>
Ocupação: Profissional Autônomo<br>
Metas:<br>
● Expandir seu negócio de consultoria.<br>
● Investir em imóveis para renda passiva.<br>
● Planejar a aposentadoria antecipada.<br>

Motivações:<br>
● Busca liberdade financeira e flexibilidade.<br>
● Valoriza a autonomia e o controle sobre sua carreira.<br>
● Quer construir riqueza a longo prazo.<br>

Frustrações:<br>
● Incerteza de renda como autônomo.<br>
● Preocupação com impostos e burocracia.<br>
● Dificuldade em equilibrar trabalho e vida pessoal.<br>

Características Principais:<br>
● Consultor autônomo.<br>
● Determinado e disposto a correr riscos calculados.<br>













 	
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
|RF-04|O site deve apresentar, um crud para adição de grupos de custo, nome, integrantes e contas compartilhadas.	|Alta|
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

