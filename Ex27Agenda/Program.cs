using System;
using System.Collections.Generic;

namespace Ex27Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            string nome;
            string dataNascimento;

            Dictionary<string,string> lista = new Dictionary<string,string>();

            do
            {
                Console.WriteLine("Digite o comando desejado para a agenda: ");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Buscar");
                Console.WriteLine("4 - Listar");

                indice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (indice)
                {
                    case 1:
                        Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();
                        
                        Console.WriteLine("Digite a data de nascimento: ");
                        dataNascimento = Console.ReadLine();

                        lista.Add(nome,dataNascimento);
                        Console.WriteLine("Adicionado com sucesso!");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Digite o nome a ser deletado: ");
                        nome = Console.ReadLine();

                        lista.Remove(nome);

                        Console.WriteLine("Deletado com sucesso!");
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Digite o nome a ser buscado: ");
                        nome = Console.ReadLine();

                        if (lista.ContainsKey(nome))
                        {
                            dataNascimento = lista[nome];
                            Console.WriteLine($"{nome} - {dataNascimento}");
                        }
                        else
                        {
                            Console.WriteLine("Nome não encontrado!");
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Lista da agenda: ");

                        foreach (var item in lista)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Comando inválido!");
                        break;
                }
            }
            while(true);
        }
    }
}
