using System;

namespace Ex15Meses
{
    class Program
    {
        enum Meses : uint
        {
            Janeiro = 1,
            Fevereiro,
            Março,
            Abril,
            Maio,
            Junho,
            Julho,
            Agosto,
            Setembro,
            Outubro,
            Novembro,
            Dezembro
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do mês desejado: ");
            int codigo = int.Parse(Console.ReadLine());

            if (codigo >= 1 && codigo <= 12)
            {
                Meses mes = (Meses)codigo;

                Console.Write("O número corresponde ao mês de " + mes);
            }
            else
            {
                Console.Write("Não existe mês correspondente ao número digitado.");
            }
        }
    }
}
