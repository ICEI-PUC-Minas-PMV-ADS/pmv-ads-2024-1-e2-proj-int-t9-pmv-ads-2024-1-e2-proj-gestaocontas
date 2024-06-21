# Plano de Testes de Software

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-01: Verificar o funcionamento do cadastro de usuário</td>
  <td>
   <ul>
    <li>RF-01 O site deve apresentar cadastro e login dos seus usuários.</li>
 
   </ul>
  </td>
  <td>Verificar se o usuário está conseguindo se cadastrar no site.</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li>Clicar no link de cadastro.</li>
    <li> Inserir dados necessários para cadastro </li>
    <li> Clicar em criar conta </li>
    
   </ol>
   </td>
  <td>O sistema não deve permitir cadastro de usuários se não for inserido e-mail e/ou senha, não deve permitir cadastro caso senha e confirmação de senha estiverem diferentes e caso o usuário já estiver previamente cadastrados. O sistema deve permitir o cadastro quando as informaçãoes essenciais, tais como e-mail, senha e confime senha estiverem adequadamente preenchidos. .</td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-02: Verificar o funcionamento do login de usuário</td>
  <td>
   <ul>
    <li>RF-01 O site deve apresentar cadastro e login dos seus usuários. </li>
  
   </ul>
  </td>
  <td>Verificar se ao efetuar a inserção dos dados de e-mail e senha o sistema efetua o login e direciona à tela home.</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li>Clicar no link Login.</li>
    <li>Preencher informações de e-mail e senha previamente cadastrados</li>
     <li>Clicar no botão "acessar".</li>
        
   </ol>
   </td>
  <td>O sistema não deve permitir login em caso de dados inseridos na tela de login diferente do previamente cadastrado, e para inserção de dados previamente cadastrados, o sistema deverá efetuar o login do usuário e direcioná-lo a tela home.</td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-03: Verificar o funcionamento do cadastro de contas</td>
  <td>
   <ul>
    <li>RF-02 O site deve apresentar, um crud para adição de boletos, com data de vencimento, nome , tipo de gasto e valor. </li>
    <li>RF-03 O site deve apresentar, um crud para adição de cartões, com data de vencimento, nome e banco. </li>
  
   </ul>
  </td>
  <td>Verificar se ao efetuar a inserção dos dados de contas eles aparecem corretamente nos respectivos links na ordem correta.</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li>Efetuar login .</li>
    <li>Acessar aba Cartões </li>
     <li>Inserir dados e verificar se apareceram de forma correta.</li>
     <li>Selecionar a aba home </li>
     <li>Acessar aba Boletos </li>
     <li>Inserir dados e verificar se apareceram de forma correta.</li>
        
   </ol>
   </td>
  <td>O sistema deve mostrar as informações na ordem que foram preenchidas.</td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-04: Verificar a funcionalidade de inserir usuários aos grupos devedores</td>
  <td>
   <ul>
    <li>RF-04 O site deve apresentar, um crud para adição de grupos de custo, nome, integrantes e contas compartilhadas e banco. </li>
  
   </ul>
  </td>
  <td>Verificar se o sistema está adicionando usuários aos grupos e permitindo a edição dos mesmos.</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li>Efetuar login .</li>
    <li>Acessar aba Grupos </li>
     <li>Selecionar aba nomes</li>
     <li>Inserir usuários que já estejam cadastrados </li>
        
   </ol>
   </td>
  <td>O sistema deve exibir os usuários inseridos nos respectivos grupos.</td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-05: Verificar a funcionalidade de inserção de cartoes</td>
  <td>
   <ul>
    <li>RF-05 O site deve apresentar, um crud para adição de gastos nos cartões, com data de vencimento, nome e tipo de gasto. </li>
  
   </ul>
  </td>
  <td>Verificar se o sistema está adicionando os cartoes</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li>Efetuar login .</li>
    <li>Selecionar aba cartões </li>
    <li>Inserir um cartão .</li>
    <li>Verificar os dados que foram inseridos</li>
        
   </ol>
   </td>
  <td>O sistema deve exibir de forma correta os respectivos gastos que foram inseridos tanto para o usuário indidual quanto para os grupos de gastos.</td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-06: Verificar a funcionalidade de inserção de boletos</td>
  <td>
   <ul>
    <li>RF-02 O site deve apresentar, um crud para adição de boletos, com data de vencimento, nome , tipo de gasto e valor. </li>
  
   </ul>
  </td>
  <td>Verificar se o sistema está adicionando os boletos</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li>Efetuar login .</li>
    <li>Selecionar aba boletos </li>
    <li>Inserir um cartão .</li>
    <li>Verificar os dados que foram inseridos</li>
        
   </ol>
   </td>
  <td>O sistema deve exibir de forma correta os respectivos gastos que foram inseridos tanto para o usuário indidual quanto para os grupos de gastos.</td>
 </tr>
</table>

<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-07: Verificar a funcionalidade de análise de gastos</td>
  <td>
   <ul>
     <li>RF-06 O site deve gerar um relatório apontando quais gastos ocorrem mais, de acordo com seu tipo. </li>
  
   </ul>
  </td>
  <td>Verificar se o sistema está permitindo a analise dos gastos adicionados.</td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li>Efetuar login .</li>
    <li>Selecionar aba cartões </li>
    <li>selecionar "ver gastos" .</li>
    <li>Verificar gastos que foram inseridos</li>
    <li>Selecionar aba Home</li>
    <li>Selecionar aba fisico.</li>
    <li>Verificar gastos que foram inseridos </li>
        
   </ol>
   </td>
  <td>O sistema deve exibir de forma correta os respectivos gastos que foram inseridos.</td>
 </tr>
</table>

 <table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-08: Verificar a funcionalidade de inserção de gastos dos grupos devedores</td>
  <td>
   <ul>
     <li>RF-04 O site deve apresentar, um crud para adição de grupos de custo, nome, integrantes e contas compartilhadas. </li>
  
   </ul>
  </td>
  <td>Verificar se o sistema está permitindo a adição de gastos dos grupos devedores.</td>
  <td>
   <ol>
     <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li>Efetuar login .</li>
    <li>Acessar aba Grupos </li>
     <li>Selecionar botão "adicionar" no canto inferior direito</li>
     <li>Inserir nome do gasto </li>
     <li>Inserir data </li>
     <li>Inserir devedores </li>
     <li>Inserir recebedor </li>
     <li>Inserir valor </li>
     <li>Verificar se todas as informações aparecem de forma correta na aba "Grupos" </li>
        
   </ol>
   </td>
  <td>O sistema deve exibir de forma correta todas as informações adicionadas no grupo.</td>
 </tr>



<table>
 <tr>
  <th>Caso de teste</th>
  <th>Requisitos associados</th>
  <th>Objetivo do teste</th>
  <th>Passos</th>
  <th>Critérios de êxito</th>
 </tr>
 <tr>
  <td>CT-09: Verificar a funcionalidade de inserção de gastos físicos </td>
  <td>
   <ul>
    <li>RF-05 O site deve apresentar, um crud para adição de dinheiro físico, com data de vencimento, nome e tipo de gasto.</li>
 
   </ul>
  </td>
  <td> Verificar se o sistema está permitindo a adição de gastos físicos, informando o tipo de gasto, valor e nome. </td>
  <td>
   <ol>
    <li>Acessar o navegador.</li>
    <li>Informar o endereço do site.</li>
    <li>Visualizar a página Home.</li>
    <li> Efetuar login </li>
    <li>Clicar no link gastos físicos.</li>
    <li> Inserir dados do gasto físico </li>
    <li> Verificar os dados que foram inseridos </li>
    
   </ol>
   </td>
  <td>O sistema deve exibir de forma correta os respectivos gastos que foram inseridos para o usuário individual.</td>
 </tr>

 
</table>
 

