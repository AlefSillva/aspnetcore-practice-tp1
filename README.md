# Projeto de Delegates e Eventos em Aplicação Web - ASP.NET Core

Este projeto é uma aplicação ASP.NET Core que implementa uma série de exercícios práticos utilizando **delegates**, **eventos** e **Razor Pages**. O objetivo do projeto é integrar conceitos de lógica de negócio com eventos em uma aplicação web, simulando um sistema de cadastro de produtos e eventos, com o uso de delegates para registrar ações como o cadastro de eventos.

## Funcionalidades

- **Exercício 1**: Implementação de um delegate para calcular o preço com desconto em um sistema de vendas online.
- **Exercício 2**: Implementação de uma estrutura com `Action<string>` para exibir mensagens de boas-vindas em diferentes idiomas.
- **Exercício 3**: Cálculo de área de figuras geométricas utilizando `Func<double, double, double>`.
- **Exercício 4**: Monitoramento de temperatura com evento personalizado que dispara alertas.
- **Exercício 5**: Notificação de conclusão de download utilizando eventos.
- **Exercício 6**: Sistema de registro de logs com multicast delegate para exibir mensagens em múltiplos destinos.
- **Exercício 7**: Garantia de robustez em invocação de delegates, utilizando `?.Invoke()`.
- **Exercício 8**: Construção de uma aplicação web simples utilizando Razor Pages para exibir produtos.
- **Exercício 9**: Exploração da estrutura de projeto ASP.NET Core, com detalhes sobre as pastas e arquivos do projeto.
- **Exercício 10**: Implementação de um formulário em Razor Pages para cadastro de produtos.
- **Exercício 11**: Manipulação de strings com delegates encadeados para transformação de texto.
- **Exercício 12**: Integração de delegates e eventos para registrar eventos em uma aplicação web.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para desenvolvimento de aplicações web.
- **Razor Pages**: Estrutura do ASP.NET Core para desenvolvimento web baseado em páginas.
- **C#**: Linguagem de programação para lógica de aplicação.
- **Visual Studio**: IDE utilizada para desenvolvimento.
- **IIS Express**: Servidor utilizado para execução local da aplicação.

## Como Executar o Projeto

1. **Clonar o Repositório**: 
   - Clone o repositório para o seu ambiente local:
     ```bash
     git clone https://github.com/seu-usuario/projeto-delegates-eventos.git
     ```

2. **Abrir no Visual Studio**:
   - Abra o projeto no Visual Studio ou em outra IDE que suporte .NET Core.

3. **Restaurar Dependências**:
   - Se necessário, restaure as dependências do projeto:
     ```bash
     dotnet restore
     ```

4. **Executar a Aplicação**:
   - Para rodar a aplicação, utilize o comando:
     ```bash
     dotnet run
     ```

   - Alternativamente, você pode executar a aplicação diretamente no Visual Studio utilizando o IIS Express ou qualquer outro servidor que esteja configurado para rodar sua aplicação.

5. **Acessar a Aplicação**:
   - Após iniciar a aplicação, o Visual Studio irá automaticamente abrir o navegador padrão, ou você pode acessar diretamente o endereço exibido na saída do terminal (geralmente algo como `http://localhost:<porta>`).

  
## Exercícios Implementados

### Exercício 1 - Implementação de Delegate Personalizado para Descontos
Implementação de um delegate para calcular o preço com 10% de desconto em um sistema de vendas online.

### Exercício 2 - Ações Multilíngues com Action<string>
Uso de delegates `Action<string>` para exibir mensagens de boas-vindas em diferentes idiomas conforme a escolha do usuário.

### Exercício 3 - Cálculo de Área Utilizando Func
Utilização do delegate `Func<double, double, double>` para calcular a área de diferentes formas geométricas.

### Exercício 4 - Monitoramento de Temperatura com Evento Personalizado
Monitoramento de temperatura com um evento que dispara alertas quando a temperatura ultrapassa um limite específico.

### Exercício 5 - Notificação de Conclusão de Download com Eventos
Simulação de um processo de download assíncrono, com evento disparado ao final da operação.

### Exercício 6 - Sistema de Registro com Multicast Delegate
Criação de um sistema de registro de logs que envia as mensagens para múltiplos destinos utilizando um multicast delegate.

### Exercício 7 - Garantia de Robustez em Invocação de Delegates
Uso de delegates de forma segura utilizando o operador `?.Invoke()` para evitar exceções quando não houver métodos associados.

### Exercício 8 - Construção de Aplicação Web com Razor Pages
Desenvolvimento de uma aplicação web simples utilizando Razor Pages para exibir produtos e permitir navegação entre páginas.

### Exercício 9 - Exploração da Estrutura de Projeto ASP.NET Core
Análise e explicação sobre as pastas e arquivos principais de um projeto ASP.NET Core, como `Pages`, `Program.cs` e `Startup.cs`.

### Exercício 10 - Implementação de Formulário em Razor Pages
Criação de um formulário para cadastro de produtos, com validação e exibição dos dados submetidos.

### Exercício 11 - Manipulação de Strings com Delegates Encadeados
Uso de delegates encadeados para realizar transformações em strings, como conversão para maiúsculas e remoção de espaços.

### Exercício 12 - Integração de Delegates e Eventos em Aplicação Web
Cadastro de eventos em uma aplicação web, com disparo de um delegate `Action<Event>` para registrar a criação no console.

## Conclusão

Este projeto foi desenvolvido com o objetivo de demonstrar o uso de delegates e eventos em uma aplicação web ASP.NET Core, utilizando Razor Pages para interação com o usuário e lógica de negócios baseada em delegates. Ele oferece uma introdução a conceitos fundamentais da linguagem C# e do ASP.NET Core.
