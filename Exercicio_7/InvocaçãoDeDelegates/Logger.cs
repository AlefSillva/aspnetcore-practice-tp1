using System;

public class Logger
{
    public void LogToConsole(string mensagem)
    {
        Console.WriteLine($"Log to Console: {mensagem}");
    }

    public void LogToFile(string mensagem)
    {
        Console.WriteLine($"Log to File: {mensagem}");
    }

    public void LogToDatabase(string mensagem)
    {
        Console.WriteLine($"Log to Database: {mensagem}");
    }


}
