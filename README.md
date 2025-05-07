# ✅ Gerenciador de Tarefas - API REST em .NET 8

Este projeto é uma **API RESTful** desenvolvida em **.NET 8**, utilizando **Entity Framework Core** para gerenciamento de banco de dados, com o objetivo de fornecer uma solução para o gerenciamento de tarefas vinculadas a usuários. A aplicação foi estruturada com base em princípios de **arquitetura limpa**, utilizando boas práticas de design e padrões de desenvolvimento para garantir escalabilidade, manutenção e segurança.

---

## 🧠 Objetivo do Projeto

O **Gerenciador de Tarefas** é uma solução digital voltada para a gestão de tarefas de forma eficiente, permitindo que um **usuário** crie, edite, visualize e remova **tarefas** que estão relacionadas a ele. Cada tarefa possui informações como **descrição**, **prazo**, **status** de conclusão e **categoria**.

Este projeto é útil para aprender e aplicar conceitos de **APIs RESTful**, **Entity Framework Core**, **injeção de dependências**, **migrações de banco de dados** e **boas práticas de arquitetura de software**.

---

## 🧩 Conceitos e Arquitetura

### API RESTful

A arquitetura **REST (Representational State Transfer)** é um estilo de desenvolvimento de APIs que segue princípios de design simples, utilizando os métodos HTTP (GET, POST, PUT, DELETE) para a comunicação entre cliente e servidor.

Cada **endpoint** da API serve como **representação** de um recurso. No nosso caso, temos dois principais recursos:

1. **Usuários** - Representa o indivíduo que interage com a plataforma.
2. **Tarefas** - Representa as atividades ou pendências que o usuário precisa gerenciar.

### Princípios RESTful

- **Stateless**: Cada requisição do cliente deve conter todas as informações necessárias para ser processada, ou seja, o servidor não armazena informações sobre o estado da aplicação entre as requisições.
- **Recurso identificável via URL**: Cada recurso tem uma URL única. Por exemplo:
  - `/api/usuarios` - para listar todos os usuários.
  - `/api/tarefas/{id}` - para acessar uma tarefa específica.
- **Uso dos métodos HTTP**:
  - **GET**: Recupera dados do servidor.
  - **POST**: Envia dados para o servidor para criar um novo recurso.
  - **PUT/PATCH**: Atualiza um recurso existente.
  - **DELETE**: Remove um recurso.

---

## 🛠️ Tecnologias Utilizadas

### .NET 8 (ASP.NET Core)

**ASP.NET Core** é um framework open-source da Microsoft para o desenvolvimento de aplicações web e APIs. Ele oferece excelente desempenho, escalabilidade e suporte a múltiplos ambientes (Windows, Linux e macOS). Utilizamos a versão **.NET 8**, que traz melhorias significativas em termos de desempenho e produtividade.

### Entity Framework Core 9

O **Entity Framework Core (EF Core)** é um **ORM (Object-Relational Mapper)**, que facilita a interação com o banco de dados utilizando objetos e classes. Com o EF Core, não precisamos escrever SQL manualmente; podemos manipular dados diretamente em objetos C#.

O EF Core faz o mapeamento entre as **entidades** do código e as **tabelas** no banco de dados, e usamos **migrations** para versionar e controlar mudanças no esquema do banco de dados.

### SQL Server

O **SQL Server** é um sistema de gerenciamento de banco de dados relacional (RDBMS) amplamente utilizado. Ele é a escolha ideal para aplicações que necessitam de alta integridade e suporte transacional robusto. Utilizamos o **SQL Server Express** para este projeto, uma versão gratuita e leve do SQL Server, adequada para desenvolvimentos iniciais.

### Swagger (Swashbuckle)

O **Swagger** (ou **OpenAPI**) é uma especificação para descrever APIs RESTful. O **Swashbuckle** é uma biblioteca que integra o Swagger ao ASP.NET Core, fornecendo uma interface interativa onde desenvolvedores e usuários podem explorar os endpoints da API, além de testar as requisições diretamente no navegador.

---

## 📖 Modelagem do Banco de Dados

### Entidades

O sistema de gerenciamento de tarefas é baseado em duas principais entidades:

1. **Usuário**
   - **Id** (int) – Identificador único.
   - **Nome** (string) – Nome do usuário.
   - **Email** (string) – E-mail do usuário.
   - **Senha** (string) – Senha do usuário.

2. **Tarefa**
   - **Id** (int) – Identificador único.
   - **Descricao** (string) – Descrição da tarefa.
   - **DataDeCriacao** (DateTime) – Data em que a tarefa foi criada.
   - **Prazo** (DateTime) – Data limite para a conclusão da tarefa.
   - **Categoria** (string) – Categoria da tarefa.
   - **Concluida** (bool) – Status indicando se a tarefa foi concluída ou não.
   - **UsuarioId** (int) – Identificador do usuário ao qual a tarefa pertence.

### Relacionamento entre Entidades

- **Usuário (1) ⟶ (N) Tarefas**: Um usuário pode ter várias tarefas associadas, mas cada tarefa está vinculada a um único usuário.

---

## 📝 Operações Realizadas pela API

### Usuários

A API permite o gerenciamento completo de usuários, com as seguintes operações:

- **Criar**: Registra um novo usuário.
- **Consultar**: Busca os dados de um usuário específico ou de todos os usuários.
- **Atualizar**: Modifica as informações de um usuário.
- **Excluir**: Remove um usuário do sistema.

### Tarefas

As tarefas estão associadas a um usuário e podem ser manipuladas de acordo com as seguintes operações:

- **Criar**: Permite a criação de uma nova tarefa para um usuário.
- **Consultar**: Lista todas as tarefas de um usuário ou busca uma tarefa específica.
- **Atualizar**: Atualiza informações de uma tarefa, como descrição e prazo.
- **Excluir**: Exclui uma tarefa específica.

---

## 🏗️ Como Funciona o Fluxo de Dados

1. O **usuário** realiza uma requisição para um dos endpoints da API (por exemplo, para criar uma nova tarefa).
2. O **controller** da API recebe a requisição, valida os dados e repassa para o **DbContext**, que representa o banco de dados.
3. O **DbContext** interage com o banco de dados usando o **Entity Framework Core**, realizando as operações de inserção, atualização, leitura ou remoção de dados.
4. Após a operação, o servidor envia uma resposta para o cliente, informando o sucesso ou falha da requisição.

---

## 🚀 Como Executar o Projeto

### Requisitos

- **.NET 8 SDK**
- **SQL Server (Express ou outro)**

### Passos

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/GerenciadorDeTarefas.git
   cd GerenciadorDeTarefas
