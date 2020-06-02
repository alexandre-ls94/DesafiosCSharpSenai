using System;
using System.Collections.Generic;

namespace Ex12NumerosOrdem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            string numero;

            do
            {
                Console.WriteLine("Digite um número ou digite X para encerrar: ");
                numero = Console.ReadLine();

                if (numero != "X")
                {
                    int numeroConvertido = int.Parse(numero);
                    
                    lista.Add(numeroConvertido);
                }

            } while (numero != "X");

            lista.Sort();

            Console.WriteLine();
            Console.WriteLine("A ordem dos números é:");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
