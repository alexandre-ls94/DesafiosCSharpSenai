using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.Write("Digite um número ou digite 0 para encerrar: ");

                num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"O número {num} é par !");
                    }
                    else
                    {
                        Console.WriteLine($"O número {num} é ímpar !");
                    }
                }
            } while (num != 0);
        }
    }
}
