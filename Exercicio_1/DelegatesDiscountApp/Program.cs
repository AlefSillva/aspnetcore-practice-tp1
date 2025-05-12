
public class Program
{
    delegate decimal CalculateDiscount(decimal precoOriginal);


    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o preço original do produto: ");
        string precoOriginal = Console.ReadLine();

        if ( decimal.TryParse(precoOriginal, out decimal precoComDesconto))
        {
            CalculateDiscount calcDesconto = (preco) => preco * 0.9m;

            decimal precoDescontado = calcDesconto(precoComDesconto);

            Console.WriteLine("O preço com desconto é: " + precoDescontado);
        }
        else
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
        
        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();
    }
}