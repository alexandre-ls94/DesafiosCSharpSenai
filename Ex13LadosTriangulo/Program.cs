using System;

namespace Ex13LadosTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento de um lado do triângulo:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro comprimento:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro comprimento:");
            int num3 = int.Parse(Console.ReadLine());

            if((num1 < (num2 + num3)) && (num2 < (num1 + num3)) && (num3 < (num1 + num2)))
            {
                //Console.WriteLine($"Os números {num1}, {num2} e {num3} fazem parte de um triângulo");
                if((num1 == num2) && (num2 == num3))
                {
                    Console.WriteLine("Este é um triângulo equilátero !");
                }

                else if ((num1 == num2) || (num2 == num3) || (num1 == num3))
                {
                    Console.WriteLine("Este é um triângulo isósceles !");
                }
                
                else if ((num1 != num2) && (num2 != num3) && (num1 != num3))
                {
                    Console.WriteLine("Este é um triângulo escaleno !");
                }
            }
            else{
                Console.WriteLine("Os comprimentos não fazem parte de um triângulo");
            }

        }
    }
}
