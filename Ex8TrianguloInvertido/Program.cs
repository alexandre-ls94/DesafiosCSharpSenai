using System;

namespace TrianguloInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("Digite a altura do triangulo: ");
            num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
