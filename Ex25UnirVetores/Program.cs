using System;

namespace Ex25UnirVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();

            Console.WriteLine("Qual o tamanho dos vetores ?");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetorA = new int[tamanho];
            int[] vetorB = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                vetorA[i] = numAleatorio.Next(1, 11);
                vetorB[i] = numAleatorio.Next(1, 11);
            }

            int[] vetorC = new int[(tamanho * 2)];

            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorC[i] = vetorA[i];
            }

            for (int j = 0; j < vetorB.Length; j++)
            {
                vetorC[(tamanho + j)] = vetorB[j];
            }

            Console.Write("VetorA = ");
            foreach (var item in vetorA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("VetorB = ");
            foreach (var item in vetorB)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("VetorC = ");
            foreach (var item in vetorC)
            {
                Console.Write(item + " ");
            }
        }
    }
}
