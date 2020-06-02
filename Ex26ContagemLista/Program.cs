using System;
using System.Collections.Generic;

namespace Ex26ContagemLista
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            List<string> lista = new List<string>();

            Console.WriteLine("Digite um nome ou digite 0 para terminar: ");

            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                    if(nome != "0")
                    {
                        lista.Add(nome);
                    }
            }
            while(nome != "0");

            Console.WriteLine($"Quantidade de nomes na lista: {lista.Count}");
        }
    }
}
