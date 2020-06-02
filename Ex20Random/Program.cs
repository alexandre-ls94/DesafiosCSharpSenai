using System;
using System.Collections.Generic;

namespace Ex20Random
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i <= 9; i++)
            {
                Random numAleatorio = new Random();
                int num = numAleatorio.Next(1, 51);
                vetor[i] = num;
            }

            foreach (int numLista in vetor)
            {
                if(numLista % 2 == 0)
                {
                    pares.Add(numLista);
                }
                else
                {
                    impares.Add(numLista);
                }
            }

            Console.Write("Números pares: ");
            foreach (var item in pares)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();

            Console.Write("Números ímpares: ");
            foreach (var item in impares)
            {
                Console.Write(item + ",");
            }
        }
    }
}
