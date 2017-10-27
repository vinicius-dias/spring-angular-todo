# spring-angular-todo
Exemplo de TODO List WEB API usando AngularJS como frontend e duas versões de backend: Java SpringBoot e .net Core

Necessário ter instalado:
    Java
    Maven

Para rodar frontend + JAVA backend via ECLIPSE

- Instalação
    - Clonar o repositorio
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


Para rodar frontend + JAVA backend via linha de comando
- Instalação
    - Clonar o repositório

- Rodar
    - Navegar até o diretório spring-angular-todo/springboot
    - Comando para rodar a aplicação: mvn spring-boot:run
    - A aplicação pode ser acessada através da URL http://localhost:8080

    Durante a primeira vez, as bibliotecas serão baixadas e a aplicação demorará um pouco mais para subir.

    