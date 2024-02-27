# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Valkiria Mendes, 22 anos, acadêmica de Direito Puc Minas, BelorizontIna, noiva e sem filhos. Está oitavo período, e precisa se 
lembrar de todas as suas tarefas, trabalhos e projetos acadêmicos e suas entregas semanais, mensais e bimestrais. Ela precisa de ter seu plano de estudos para a sua prova da ordem e está planejando qual assunto irá realisar seu TCC. Na parte da tarde ela vai à academia, e aos finais de semana participa de palestras e oratórias. Agora ela tem aulas on-line duas vezes na semana, segunda e terça, às 19 horas. Todos os seus trabalhos são semanais, e são entregues toda semana na sexta-feira. No mês de julho Valkiria entra de férias e já está programando para viajar. Ela precisa de ter uma organização diária, semanal e mensal de seus estudos, para entregar tudo a tempo do que sua universidade exige dela.

Henrique Braga, 48 anos, contador autônomo a 25 anos, formado em contabilidade na Universade USP e faz atendimentos em casa. Henrique precisa organizar seus clientes, e os agendamentos do dia, e quais os trabalhos serão feitos no dia e quantos agendados. Henrique como atleta e um homem ativo, mais reservado  e solteiro. Ele não entende muito de tecnologia, ele precisa de algo que falicite os seus dias no trabalho, ele faz ainda seus agendamentos a mão, e acaba que ás vezes perdendo estes documentos do clientes, não lembrava mais qual era o caso do cliente, só do telefone e tem que retornar a ligação com omesmo. Ele precisa agendar cada caso do cliente, agendando para tal dia e horário sem perder, e agendando com antecedência. Aos finais de semana Henrique pratica natação aos sábados de manhã e de noite ele encontra os velhos amigos para praticar o alpinismo. Ele faz seus atendimentos na parte da manhã e de tarde de segunda á sexta, e a noite que ele precisa organizar sua agenda para o dia seguinte.

Laila Pires, 35 anos, dona de casa em tempo integral, mãe de 2 filnhos Jasmin e Sanjei, casada. Acabou de mudar para Niterói-RJ- e não conhece direito onde os compromisso de seus filhos localiza. Entretanto precisa fazer sua lista de tarefas do dia, tarafas de seus filhos, lista de como compras e quais são as tarefas do dia e da semana para todos. Ela precisa de que quando suas tarefa fou comprida mostre a ela e do que ainda precisa. Seu marido faz viagens e ela tem que contabilizar quantos dias o seus marido vai se ausentar. Ela precisa sabe quais tarefas serão feitas de cada filho, Jasmin faz aula de piano aos domingo á tarde, Sanjei tem treino de futebol todos os dias da semana, Jasmin faz consultas mensais com seu médico e Sanjei semanalmente vai a nuticionista. Fora as tarefas domesticas que Laila tem que está com elas em dia. Laila está finalizando suas aulas da autoescola e seu exame do DETRAN será marcado.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO `VALKIRIA MENDES`| QUERO/PRECISO ...`GERENCIAMENTO`   |PARA ...`ACADÊMICO`                     |
|-------------------------|------------------------------------|----------------------------------------|
|Usuário do sistema       | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Usuário do sistema       | Lembrete de minas tarefas          | Enfatizar a tarefa                     |
|Usuário do sistema       | Espesificar cada tarefa            | Se lembrado que se trata               |
|Adminstrador             | Disponibilizar horário e datas     | Escolha de preferencia                 |
|Adminstrador             | Notificação de tarefa              | Pontencializar a tarefa                |

|EU COMO...`HENRIQUE BRAGA` | QUERO/PRECISO ... `PRATICIDADE`      |PARA ... `PROFISSIONAL`                 |
|-------------------------|----------------------------------------|----------------------------------------|
|Usuário do sistema       | Organizar minhas lista de clientes     | Não esquecer do atendimento do dia     |
|Usuário do sistema       | Marcar se o cliente compareceu         | Para remarcar                          |
|Usuário do sistema       | Espesificar o caso do cliente          | Facilitando a solução do caso          |
|Adminstrador             | Lista de clientes por orgem alfabete   | Não esquecer o nome dos clientes       |
|Adminstrador             | Lista de clientes por orgem de horário | Para saber qual o próximo atendimento  |

|EU COMO `LAILA PIRES`    | QUERO/PRECISO ...`FUNCIONAL`                  |PARA ... `USO PESSOAL/FAMILIAR`                  |
|-------------------------|-----------------------------------------------|-------------------------------------------------|
|Usuário do sistema       | Preciso regidtrar o local do meu compromisso  | Não esquecer de onde localiza seus compromissos |
|Usuário do sistema       | Faz lista de tarefas, lista de compras        | Lista uma sobre a outra tendo ordem             |
|Usuário do sistema       | Galendario completo                           | Para registrar tudo que precisa                 |
|Usuário do sistema       | Marcação no galendario personalizada          | Diferenciar cada um dos compromissos            |
|Adminstrador             | Marcar que a tarefa foi concluída             | Para saber o que falta ser concluído            |
|Adminstrador             | Da localização atual                          | Onde está logalizada no nomento                 |
 
Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site deve permitir o cadastro do usuário | ALTA | 
|RF-002| O site deve permitir o login do usuário   | ALTA |
|RF-003| O site deve permitir a modificação de dados do usuário | ALTA |
|RF-004| O site deve conter uma página inicial para receber o usuário | ALTA |
|RF-005| O site deve ser acessível para qualquer pessoa independente do nível de conhecimento tecnológico | ALTA |
|RF-006| O site deve permitir a criação, deleção e edição de dos dados de lembretes | ALTA |
|RF-007| O site deve conter uma página que exibe todos os lembretes e rotinas definidos | ALTA |
|RF-008| O site deve permitir a criação, deleção e edição dos dados de rotinas | ALTA |
|RF-009| O site deve permitir o upload de fotos para a conta do usuário | MÉDIA |
|RF-010| O site deve permitir a definição de alarmes para lembretes | MÉDIA | 
|RF-011| O site deve notificar o usuário depois do tempo definido em um lembrete ou rotina acabar | MÉDIA |
|RF-012| O site deve permitir separar lembretes em seções diferentes por meio de classificações dadas pelo usuário | MÉDIA |
|RF-013| O site deve permitir separar rotinas em seções diferentes por meio de classificações dadas pelo usuário | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-003| O código deve ser bem documentado e modularizado para facilitar futuras alterações e correções. |  MÉDIA | 
|RNF-004| A aplicação deve ser compatível com os principais navegadores: Google Chrome, Firefox e Microsoft Edge. | ALTA |
|RNF-005| A aplicação deve garantir a segurança dos dados do usuário durante o cadastro | ALTA |
|RNF-006| A aplicação deve haver controle de acesso para proteger informações confidenciais do usuário | ALTA |

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
|01| Todas as etapas do projeto deve ser entregue no prazo e a 5 etapa e final entregue até o final do semestre dia 04/07/24|
|02| O projeto deve ser desenvolvido usando a linguagem c# e o modelo padrão MVC de desenvolvimento de software|
|03| A documentação e o código da aplicação devem ser publicados no GitHub |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso
<p align='center' font-size='2px' text-align='center'>
 <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-ProjKipa/blob/main/docs/img/casosdeusokipa.drawio.png"> <br>
 VERSÃO INICIAL
</p>
