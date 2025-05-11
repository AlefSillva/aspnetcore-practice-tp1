class Program
{
    static void Main(string[] args)
    {

        Logger logger = new Logger();

        Action<string> logDelegate = null;

        logDelegate?.Invoke("Mensagem de teste sem métodos");


        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}