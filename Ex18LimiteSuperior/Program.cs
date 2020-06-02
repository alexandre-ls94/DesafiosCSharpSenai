using System;

namespace Ex18LimiteSuperior
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteSuperior = 0;

            Console.Write("Digite um limite superior: ");
            limiteSuperior = int.Parse(Console.ReadLine());

            for (int i = 1; i < limiteSuperior; i+= 2)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
