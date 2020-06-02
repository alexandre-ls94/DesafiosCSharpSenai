using System;

namespace Ex22MatrizBidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];
            Random numAleatorio = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int num = numAleatorio.Next(1,51);
                    matriz[i,j] = num;
                }
            }

            int soma = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i,j] + " ");
                    soma += matriz[i,j];
                }
                
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("A soma dos números é: " + soma);

        }
    }
}
