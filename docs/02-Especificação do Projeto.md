# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

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

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário gerencie suas tarefas | ALTA | 
|RF-002| A aplicação deve emitir um relatório de tarefas realizadas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
