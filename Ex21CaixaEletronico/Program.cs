using System;

namespace Ex21CaixaEletronico {
    class Program {
        static void Main (string[] args) 
        {
            int qtNotas = 0;

            Console.Write("Digite o valor do saque : ");
            int valor = int.Parse(Console.ReadLine());

            if ((valor >= 20) && (valor < 100))
            {
                if (valor % 20 == 0)
                {
                    qtNotas = valor / 20;
                }
                else if (valor % 50 == 0)
                {
                    qtNotas = 1;
                }
                else
                {
                    qtNotas = (valor - 50) / 20;
                    qtNotas++;
                }
            }
            else if (valor >= 100)
            {
                int notasDeCem = valor / 100;
                int resto = valor - (notasDeCem * 100);

                if (resto == 50)
                {
                    qtNotas = notasDeCem + 1;
                }
                else if (resto < 50)
                {
                    qtNotas = notasDeCem + (resto / 20);
                }
                else if (resto > 50)
                {
                    if (!(resto % 20 == 0))
                    {
                        qtNotas = notasDeCem + ((resto - 50) / 20) + 1;
                    }
                    else
                    {
                        qtNotas = notasDeCem + (resto / 20);
                    }
                }
            }
            
            Console.WriteLine($"Você receberá {qtNotas} cédulas !");

        }
    }
}