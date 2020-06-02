using System;

namespace Ex24SomaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = {10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
            int[] vetorB = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] vetorC = new int[10];
            
            for (int i = 0; i < vetorC.Length; i++)
            {
                int a = vetorA[i];
                int b = vetorB[i];

                vetorC[i] = a + b;
            }
            
            Console.WriteLine("Lista com a soma dos números de vetorA e vetorB :");

            foreach (var item in vetorC)
            {
                Console.Write(item + " ");
            }
        }
    }
}
