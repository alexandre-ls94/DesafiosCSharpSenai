using System;

namespace Ex16IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso = 0;
            double altura = 0;
            double imc = 0;
            string nomeDoPaciente;

            Console.WriteLine("Vamos calcular seu IMC !");
            Console.WriteLine();

            Console.Write("Digite seu nome: ");
            nomeDoPaciente = Console.ReadLine();
            
            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            imc = Math.Round(imc, 2);

            Console.WriteLine();

            if (imc < 20)
            {
                Console.Write($"{nomeDoPaciente}, você está abaixo do peso.");
            }
            else if ((imc >= 20) && (imc <= 25))
            {
                Console.Write($"{nomeDoPaciente}, você está com o peso ideal.");
            }
            else if ((imc > 25) && (imc <= 30))
            {
                Console.Write($"{nomeDoPaciente}, você está com excesso de peso.");
            }
            else if ((imc > 30) && (imc <= 35))
            {
                Console.Write($"{nomeDoPaciente}, você está obeso.");
            }
            else
            {
                Console.Write($"{nomeDoPaciente}, você está com obesidade mórbida.");
            }
        }
    }
}
