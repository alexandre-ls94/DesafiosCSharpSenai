using System;
using System.Collections.Generic;

namespace Ex11NomesOrdem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            string nome;

            do
            {
                Console.WriteLine("Digite um nome ou 0 para encerrar: ");
                nome = Console.ReadLine();

                if (nome != "0")
                {
                    nomes.Add(nome);
                }

            } while (nome != "0");

            nomes.Sort();

            Console.WriteLine("A ordem das palavras é: ");

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
