using System;

namespace Ex23MaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            List<int> numeros = new List<int>(10);

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = numAleatorio.Next(1, 51);
            }

            Console.Write("Números do vetor = ");

            foreach (var item in vetor)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in vetor)
            {
                numeros.Add(item);
            }

            numeros.Sort();

            int menor = numeros[0];
            int maior = numeros[9];

            Console.WriteLine($"O número {maior} é o maior número da lista");
            Console.WriteLine($"O número {menor} é o menor número da lista");

        }
    }
}
