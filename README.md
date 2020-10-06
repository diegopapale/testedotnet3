# Desafio Back-end Luby Software
Primeiramente, obrigado pelo seu interesse em trabalhar na Luby. Somos uma fábrica de software com mais de 110 desenvolvedores e 15 anos de mercado. Temos atuação em mais de 5 países e estamos em busca de talentos para integrar o nosso time no desenvolvimento .NET de forma 100% remota.

#### Premissas:
- Criar uma API usando .NET CORE.
- O banco de dados pode ser  MySql ou SQL Server.

#### Teste:
Desenvolver um serviço que seja capaz de gerar um lançamento de horas.
- Um lançamento de horas é composta por pelo menos **id**, **data inicio**, **data fim**, **desenvolvedor**.

#### Sua tarefa é desenvolver os serviços abaixo:
- CRUD para desenvolvedor
- CRUD de projeto
- Criar um lançamento de hora
- Retornar ranking dos 5 desenvolvedores da semana com maior média de horas trabalhadas.
- Criar um cliente WEB para consumir essa API (Angular, React, Razor MVC)

#### Instruções:
1. Realizar `fork` deste projeto.
2. Desenvolver em cima do seu `fork`.
3. Atualizar esse README.md com sua identificação no fim do arquivo
4. Após finalizar, realizar o `pull request`.
5. Fique à vontade para perguntar qualquer dúvida aos recrutadores.

#### E por fim:
- Gostaríamos de ver o uso do controle de versão.
- Entendimento de OO, conceitos de SOLID, e outros relacionados
- Reuso do código
- Vamos avaliar a maneira que você escreveu seu código, a solução apresentada.
- Caso encontre algum impedimento no decorrer do desenvolvimento, entregue da maneira que preferir e faça uma explicação sobre o impedimento.
- Avaliaremos também sua postura, honestidade e a maneira que resolve problemas.

#### Identificação:
Nome: Diego Papale<br/>
E-mail: diegopapale@hotmail.com

#### Projeto Considerações Gerais:
- Criei um modelo separado em camadas com 3 projetos, Data, Business e Service.
- Este modelo trabalhando com Kernel, dispensa o uso de IIS para hospedar a API e torna-se multiplataforma.
- Para uso basta criar um serviço no sistema operacional e identificar porta que vai ser usado no appsettings.json.

#### Projeto Luby.Data:
- Criado para gerenciar a regra de banco de dados do projeto em camada separada da regra de negócio e do serviço da API.
- Foi criada uma classe para gerenciamento da conexão com o banco de dados.
- Criada uma classe que contém os métodos de inserção e consulta.

#### Projeto Luby.Business:
- Regra de negócio do projeto, onde aloquei as models.
- Vai servir para gerenciar validações e regras compartilhadas.

#### Projeto Luby.Service:
- É o projeto .net Core que faz o trabalho da API, usando Kernel como Self Host, dispensando uso do IIS.
- Contém o Controller da Aplicação, com os métodos Post e Get.
