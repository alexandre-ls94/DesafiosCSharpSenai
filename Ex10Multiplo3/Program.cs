using System;

namespace Ex10Multiplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if(num % 3 == 0)
            {
                Console.WriteLine($"O número {num} é múltiplo de 3");
            }
            else
            {
                Console.WriteLine($"O número {num} não é múltiplo de 3");
            }
        }
    }
}
