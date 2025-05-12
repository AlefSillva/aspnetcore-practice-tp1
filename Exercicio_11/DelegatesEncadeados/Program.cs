using System;


class Program
{
    static void Main(string[] args)
    {
        Func<string, string, string> pipeline = (texto1, texto2) => ConcatenaNomeSobrenome(texto1, texto2);
        pipeline += ParaMaiusculas;
        pipeline += RemoveEspacos;

        string resultado = pipeline("João", "Silva");

        Console.WriteLine($"Resultado final retornado pelo delegate: {resultado}");

        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }

    static string ConcatenaNomeSobrenome(string nome, string sobrenome)
    {
        Console.WriteLine("Concatenando...");
        return $"{nome} {sobrenome}";
    }

    static string ParaMaiusculas(string texto, string texto2)
    {
        Console.WriteLine("Convertendo para maiúsculas...");
        return texto.ToUpper();
    }

    static string RemoveEspacos(string texto, string texto2)
    {
        Console.WriteLine("Removendo espaços...");
        return texto.Replace(" ", "");
    }

}
