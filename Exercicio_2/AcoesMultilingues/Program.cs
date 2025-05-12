using System.Diagnostics;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha um idioma");
        Console.WriteLine("PT - Para Português");
        Console.WriteLine("EN - Para Inglês");
        Console.WriteLine("ES - Para Espanhol");

        Console.WriteLine("Digite a opção de idioma escolhido: ");
        string input = Console.ReadLine().ToUpper();

        Action<string> msgPortugues = mensagem => Console.WriteLine(mensagem);
        Action<string> msgIngles = mensagem => Console.WriteLine(mensagem);
        Action<string> msgEspanhol = mensagem => Console.WriteLine(mensagem);

        if (!string.IsNullOrEmpty(input))
        {
            string mensagem;

            switch (input)
            {
                case "PT":
                    mensagem = "Seja Bem-Vindo(a)!";
                    msgPortugues(mensagem);
                    break;
                case "EN":
                    mensagem = "Welcome!";
                    msgIngles(mensagem);
                    break;
                case "ES":
                    mensagem = "¡Bienvenido(a)!";
                    msgEspanhol(mensagem);
                    break;
                default:
                    Console.WriteLine("Idioma incorreto ou não suportado.");
                    break;
            }
        }
        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadLine();
    }
}