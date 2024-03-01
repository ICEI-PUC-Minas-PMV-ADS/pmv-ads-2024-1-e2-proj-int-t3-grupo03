# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

### Valkiria Mendes
22 anos, acadêmica de Direito da PUC Minas, Belo-horizontina, noiva e sem filhos. Está no oitavo período e precisa se lembrar de todas as suas tarefas, trabalhos e projetos acadêmicos e suas entregas semanais, mensais e bimestrais. Ela precisa de seu plano de estudos para a sua prova da ordem e está planejando qual assunto irá realizar seu TCC. Na parte da tarde, ela vai à academia e, aos finais de semana, participa de palestras e oratórias. Agora, ela tem aulas on-line duas vezes na semana, segunda e terça, às 19 horas. Todos os seus trabalhos são semanais e são entregues toda semana na sexta-feira. No mês de julho, Valkiria entra de férias e já está programando para viajar. Ela precisa de ter uma organização diária, semanal e mensal de seus estudos, para entregar tudo a tempo do que sua universidade exige dela.

### Henrique Braga
48 anos, contador autônomo há mais de 20 anos, formado em contabilidade na Universidade USP, faz atendimentos em casa. Henrique precisa organizar seus clientes, e os agendamentos do dia, quais os trabalhos serão feitos no dia e quantos agendados. Ele, como atleta, é um homem ativo, mais reservado e solteiro. Ele não entende muito de tecnologia, ele precisa de algo que facilite os seus dias no trabalho, ele faz ainda seus agendamentos à mão, e acaba que às vezes perde estes documentos dos clientes, não lembrava mais qual era o caso do cliente, só do telefone e tem que retornar a ligação ao mesmo. Henrique precisa agendar cada caso do cliente, agendando para tal dia e horário sem perder, e agendando com antecedência. Aos finais de semana, Henrique pratica natação aos sábados de manhã e à noite ele encontra os velhos amigos para praticar o alpinismo. Ele faz seus atendimentos na parte da manhã e de tarde de segunda a sexta, e à noite, que ele precisa organizar sua agenda para o dia seguinte.

### Laila Pires 
35 anos, dona de casa em tempo integral, mãe de 2 filhos, Jasmin e Sanjay, casada. Acabou de se mudar para Niterói–RJ e não conhece as localidades da cidade e onde cada compromisso se localiza. Entretanto, precisa fazer sua lista de tarefas do dia, tarefas de seus filhos, lista de compras e quais são as tarefas do dia e da semana para todos. Ela precisa que suas tarefas sejam declaradas como cumpridas quando ela as termina (checklist). Seu marido faz viagens e ela tem que contabilizar quantos dias o seu marido vai se ausentar. Sabendo quais tarefas serão feitas de cada filho e agendando como de Jasmin, que faz aula de piano aos domingos à tarde, Sanjay que faz treinos de futebol todos os dias da semana, Jasmin faz consultas mensais com seu médico e Sanjay semanalmente vai ao nutricionista. Fora as tarefas domésticas que têm que estar em dia.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO `VALKIRIA MENDES`| QUERO/PRECISO ...`GERENCIAMENTO`   |PARA ...`ACADÊMICO`                     |
|-------------------------|------------------------------------|----------------------------------------|
|Usuário do sistema       | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Usuário do sistema       | Lembrete de minhas tarefas          | Enfatizar a tarefa                     |
|Usuário do sistema       | Especificar cada tarefa            | Se lembrado que se trata               |
|Administrador             | Disponibilizar horário e datas     | Escolha de preferência                 |
|Administrador             | Notificação de tarefa              | Potencializar a tarefa                |

|EU COMO...`HENRIQUE BRAGA` | QUERO/PRECISO ... `PRATICIDADE`      |PARA ... `PROFISSIONAL`                 |
|-------------------------|----------------------------------------|----------------------------------------|
|Usuário do sistema       | Organizar minhas lista de clientes     | Não esquecer do atendimento do dia     |
|Usuário do sistema       | Marcar se o cliente compareceu         | Para remarcar                          |
|Usuário do sistema       | Especificar o caso do cliente          | Facilitando a solução do caso          |
|Administrador             | Lista de clientes por ordem alfabética   | Não esquecer o nome dos clientes       |
|Administrador             | Lista de clientes por ordem de horário | Para saber qual o próximo atendimento  |

|EU COMO `LAILA PIRES`    | QUERO/PRECISO ...`FUNCIONAL`                  |PARA ... `USO PESSOAL/FAMILIAR`                  |
|-------------------------|-----------------------------------------------|-------------------------------------------------|
|Usuário do sistema       | Preciso registrar o local do meu compromisso  | Não esquecer de onde localizar seus compromissos |
|Usuário do sistema       | Faz lista de tarefas, lista de compras        | Lista uma sobre a outra, tendo ordem             |
|Usuário do sistema       | Calendário completo                           | Para registrar tudo que precisa                 |
|Usuário do sistema       | Marcação no calendário personalizada          | Diferenciar cada um dos compromissos            |
|Administrador             | Marcar que a tarefa foi concluída             | Para saber o que falta ser concluído            |
|Administrador             | Localização do endereço                          | Onde está localizada no nomento                 |

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

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| Todas as etapas do projeto deve ser entregue no prazo e a 5 etapa e final entregue até o final do semestre dia 04/07/24|
|02| O projeto deve ser desenvolvido usando a linguagem c# e o modelo padrão MVC de desenvolvimento de software|
|03| A documentação e o código da aplicação devem ser publicados no GitHub |

## Diagrama de Casos de Uso
<p align='center' font-size='2px' text-align='center'>
<kbd>
 <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-ProjKipa/blob/main/docs/img/casosdeusokipa.drawio.png"> <br>
</kbd>
</p>
