
class Program
{
    static void Main(string[] args)
    {
        Logger logger = new Logger();

        Action<string> logDelegate = logger.LogToConsole;

        logDelegate += logger.LogToFile;

        logDelegate += logger.LogToDatabase;

        logDelegate("Esta é uma mensagem de log");

        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }

}