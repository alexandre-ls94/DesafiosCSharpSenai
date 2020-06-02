using System;

namespace ConvertCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;

            do
            {
                Console.WriteLine("Digite os graus Celsius ou digite 0 para encerrar");

                c = Convert.ToDouble(Console.ReadLine());

                if (c != 0)
                {
                    double f = Math.Round(((9 * c + 160) / 5),2);

                    Console.WriteLine($"A conversão de Graus Celsius em Graus Fahrenheit é {f}ºF");
                }                
            } while (c != 0);
        }
    }
}
