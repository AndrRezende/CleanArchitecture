# Clean Architecture C# Project

Este é um projeto de implementação de Clean Architecture utilizando C#. O objetivo é demonstrar a estruturação de uma aplicação seguindo os princípios da Clean Architecture, garantindo um código modular, desacoplado e fácil de testar.

## Estrutura do Projeto

O projeto está organizado nas seguintes camadas principais:

- **CleanArchitecture.API**: Responsável pela camada de apresentação e comunicação com o cliente (API).
- **CleanArchitecture.Application**: Contém as regras de negócio e casos de uso da aplicação.
- **CleanArchitecture.Persistence**: Implementa a infraestrutura de persistência de dados (repositórios, contextos de banco de dados, etc).
- **CleanArchitecture.Tests**: Inclui os testes unitários e de integração para as diversas camadas.
- **Domain**: Define as entidades e regras de domínio, mantendo o núcleo da aplicação isolado.

### Detalhes das Camadas

1. **CleanArchitecture.API**
    - Camada responsável por expor os endpoints da API.
    - Controladores para lidar com requisições HTTP e invocar os casos de uso apropriados da camada de Application.
    - Arquivos importantes:
      - `Program.cs`: Configura os serviços e o pipeline de execução.
      - `appsettings.json`: Contém configurações como strings de conexão com o banco de dados.

2. **CleanArchitecture.Application**
    - Implementa os casos de uso e regras de negócio.
    - Interage com os repositórios da camada de Persistence.
    - Contém serviços da aplicação que coordenam a execução de operações.

3. **CleanArchitecture.Persistence**
    - Implementa os repositórios e gerencia a persistência dos dados.
    - Conecta-se ao banco de dados SQLite (representado pelo arquivo `users.db`).

4. **CleanArchitecture.Tests**
    - Camada de testes com foco em garantir a qualidade e o funcionamento correto de cada parte do sistema.
    - Inclui testes para as camadas de Application e Domain.

5. **Domain**
    - Camada de domínio puro, que contém as entidades e interfaces centrais da aplicação.
    - Foca em garantir que o núcleo do negócio fique desacoplado de frameworks e outras camadas.

## Como Executar o Projeto

1. Clone o repositório:
    ```bash
    git clone git@github.com:AndrRezende/CleanArchitecture.git
    ```
2. Acesse a pasta do projeto:
    ```bash
    cd clean-architecture-csharp
    ```
3. Restaure as dependências do projeto:
    ```bash
    dotnet restore
    ```
4. Execute o projeto:
    ```bash
    dotnet run --project CleanArchitecture.API
    ```

## Como Rodar os Testes

Para rodar os testes do projeto, execute o seguinte comando na raiz do projeto:

```bash
dotnet test
