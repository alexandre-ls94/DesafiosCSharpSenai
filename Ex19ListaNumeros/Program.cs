using System;

namespace Ex19ListaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Quantos números deseja listar?");
            int posicoesVetor = int.Parse(Console.ReadLine());

            int[] vetor = new int[posicoesVetor];

            Console.WriteLine("Digite o número a ser listado: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                numero = int.Parse(Console.ReadLine());
                vetor[i] = numero;
            }

            Console.WriteLine("Sua lista foi preenchida com os números :");

            foreach (var item in vetor)
            {
                Console.Write(item + " ");
            }
        }
    }
}
