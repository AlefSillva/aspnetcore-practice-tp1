using System;

class Program
{
    static void Main(string[] args)
    {
        Func<string, string, string> multicast = (texto1, texto2) => texto1 + " " + texto2;
        multicast += (texto, _) => texto.ToUpper();
        multicast += (texto, _) => texto.Replace(" ", "");

        string resultado = multicast("Alef", "Silva");

        Console.WriteLine($"Retorno do delegate: {resultado}");

        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }

}
