using System;

namespace Ex5TrocaDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());

            b = a - b;
            a = a - b;
            b = a + b;

            Console.WriteLine($"O valor de A é {a}");
            Console.WriteLine($"O valor de B é {b}");
        }
    }
}
