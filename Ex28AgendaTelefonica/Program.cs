using System;
using Ex28AgendaTelefonica.Models;

namespace Ex28AgendaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string telefone;
            string aniversario;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Digite o aniversario: ");
            aniversario = Console.ReadLine();

            Registro registro = new Registro(nome, telefone, aniversario);

        }
    }
}
