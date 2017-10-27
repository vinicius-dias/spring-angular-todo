# spring-angular-todo
Exemplo de TODO List WEB API usando AngularJS como frontend e duas versões de backend: Java SpringBoot e .net Core

Necessário ter instalado:
- Java
- Maven
- Eclipse
- .net core SDK (https://www.microsoft.com/net/download/core)
- Visual Studio Code com extensão C# (https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
- Clonar o repositório
    
## Para iniciar backend .net core
- Abrir pasta do netcore no Visual Studio Code
- Aguardar instalação das extensões Omni Sharp do Visual Studio COde (somente a primeira vez)
- Pressionar F5 para executar o código.

Será iniciado o backend c# na porta 5000 definida em <code>./netcore/Program.cs</code>. Pode modificar a porta conforme necessário.

Se tiver instalação do Visual Studio, é possíveç também abrir o arquivo <code>./netcore/poc_webapi.csproj</code> e executar o projeto pelo Visual Studio.

## Para iniciar frontend + JAVA backend via ECLIPSE
- Instalação
    - Importar o projeto no Eclipse (File -> Import)
    - Escolher Maven -> Existing Maven Projects
    - Em Root Directory, colocar a pasta springboot, dentro da raiz do repositório (<algum_dir>/spring-angular-todo/springboot)
    - Se assegurar que checkbox pom.xml está checado
    - Clicar Finish

- Rodar
    - No menu superior: Run -> Run Configurations
    - Na barra à esquerda: clicar duas vezes em Maven Build. Uma nova configuração será criada
    - Mudar o nome da configuração para algum mais bonito e descritivo
    - Colocar em Base Directory: Workspace e escolher o projeto spring-angular-poc
        (ou digitar ${workspace_loc:/spring-angular-poc} no campo)
    - Colocar em Goals: spring-boot:run
    - Clicar em Run
    - A aplicação pode ser acessada através da URL http://localhost:8080

    Durante a primeira vez, as bibliotecas serão baixadas e a aplicação demorará um pouco mais para subir.
    Nas próximas vezes, só necessário clicar em RUN (botão Play)


## Para iniciar frontend + JAVA backend via linha de comando
- Instalação
    - Clonar o repositório

- Rodar
    - Navegar até o diretório spring-angular-todo/springboot
    - Comando para rodar a aplicação: mvn spring-boot:run
    - A aplicação pode ser acessada através da URL http://localhost:8080

    Durante a primeira vez, as bibliotecas serão baixadas e a aplicação demorará um pouco mais para subir.

## Para usar a demo
 Especificar os endereços das APIs spingboot e .net core nos campos de Backend definidos na tela.
 Por padrão são as portas 5000 para .net core e 8080 para springboot.