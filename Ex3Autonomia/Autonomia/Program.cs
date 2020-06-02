using System;

namespace Autonomia
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo;
            double velocidade;
            double distancia;
            double litrosUsados;

            Console.WriteLine("Vamos calcular quantos litros você gastou nessa viagem !?");

            Console.Write("Digite o tempo gasto na viagem : ");
            tempo = Double.Parse(Console.ReadLine());

            Console.Write("Digite a velocidade média do veículo na viagem : ");
            velocidade = Double.Parse(Console.ReadLine());

            distancia = Math.Round((tempo * velocidade),2);

            litrosUsados = Math.Round((distancia / 12),2);

            Console.WriteLine($"Tendo velocidade media de {velocidade}km/h e gastando o tempo de {tempo}h, temos a distância percorrida de {distancia}km e foram gastos {litrosUsados} litros na viagem");
        }
    }
}
