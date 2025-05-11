using System;

public class CalcArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a base do retângulo:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Insira a altura do retângulo:");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double baseRetangulo) &&
            double.TryParse(input2, out double alturaRetangulo))
        {
            
            Func<double, double, double> calcularArea = (baseRet, alturaRet) => baseRet * alturaRet;

            
            double area = calcularArea(baseRetangulo, alturaRetangulo);

            Console.WriteLine($"A área do retângulo é: {area}");
        }
        else
        {
            Console.WriteLine("Valores inválidos. Certifique-se de digitar números válidos.");
        }

        Console.WriteLine();
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
}
