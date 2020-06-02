using System;

namespace Ex9PesoPlaneta
{
    class Program
    {
        static void Main(string[] args)
        {
            double pTerra = 0;
            double pPlaneta = 0;
            double[] pesoPlaneta = {0.37, 0.88, 0.38, 2.64, 1.15, 1.17};
            string[] nomePlaneta = {"Mercúrio", "Vênus", "Marte", "Júpiter", "Saturno", "Urano"};

            Console.Write("Digite o peso na Terra: ");
            pTerra = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o planeta a ser calculado o peso:");
            Console.WriteLine();
            Console.WriteLine("|   | Gravidade Relativa | Planeta  |");
            Console.WriteLine("|---|--------------------|----------|");
            Console.WriteLine("| 1 | 0,37               | Mercúrio |");
            Console.WriteLine("| 2 | 0,88               | Vênus    |");
            Console.WriteLine("| 3 | 0,38               | Marte    |");
            Console.WriteLine("| 4 | 2,64               | Júpiter  |");
            Console.WriteLine("| 5 | 1,15               | Saturno  |");
            Console.WriteLine("| 6 | 1,17               | Urano    |");

            int planeta = int.Parse(Console.ReadLine());

            pPlaneta = (pTerra / 10) * (pesoPlaneta[planeta-1]);

            /*switch (planeta)
            {
                case 1:
                    pPlaneta = (pTerra / 10) * 0.37;
                    break;
                
                case 2:
                    pPlaneta = (pTerra / 10) * 0.88;
                    break;

                case 3:
                    pPlaneta = (pTerra / 10) * 0.38;
                    break;

                case 4:
                    pPlaneta = (pTerra / 10) * 2.64;
                    break;

                case 5:
                    pPlaneta = (pTerra / 10) * 1.15;
                    break;

                case 6:
                    pPlaneta = (pTerra / 10) * 1.17;
                    break;

                default:
                    Console.WriteLine("Planeta inválido");
                    break;
            }*/

            Console.WriteLine($"O peso em {nomePlaneta[planeta-1]} seria {pPlaneta.ToString("0.00")}kg");
        }
    }
}
