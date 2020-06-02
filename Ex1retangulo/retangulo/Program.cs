using System;

namespace retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            do
            {
                Console.WriteLine("Digite a altura e largura do retangulo a ser calculado ou digite 0 para encerrar");

                a = Convert.ToDouble(Console.ReadLine());
                if (a != 0)
                {
                    b = Convert.ToDouble(Console.ReadLine());

                    double perimetro = Math.Round((2 * a + 2 * b),2);
                    double area = Math.Round((a * b),2);
                    double diagonal = Math.Round((Math.Sqrt(a * a + b * b)),2);

                    Console.WriteLine($"O perimetro é {perimetro}; A area é {area}; A diagonal é {diagonal}");                    
                }
            } while (a != 0);

        }
    }
}
