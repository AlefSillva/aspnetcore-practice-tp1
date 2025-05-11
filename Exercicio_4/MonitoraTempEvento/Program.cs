using System;

public class Program
{
    static void Main(string[] args)
    {
        TemperatureSensor sensor = new TemperatureSensor();

        sensor.TemperatureExceeded += Sensor_TemperatureExceeded;

        while (true)
        {
            Console.WriteLine("Digite a temperatura (ou digite 'sair' para encerrar):");
            
            string input = Console.ReadLine();

            if ( input.ToLower() == "sair")
            {
                break;
            }
            else 
            {
                if (double.TryParse(input, out double temperaturaLida))
                {
                    sensor.MonitoradorDeTemperatura(temperaturaLida);

                }
                else
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                }
            }

        }
    }

    static void Sensor_TemperatureExceeded(object sender, TemperatureExceededEventArgs e)
    {
        Console.WriteLine($"Temperatura excedida! O valor registrado foi: {e.Temperatura}ºC");
    }
}
