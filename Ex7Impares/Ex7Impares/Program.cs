using System;

namespace Ex7Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contagem de números ímpares até 10: ");
            
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
