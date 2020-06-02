using System;

namespace Ex14VerbosInfinitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            string ultimaLetra;
            string penultimaLetra;

            Console.WriteLine("Digite um verbo: ");
            palavra = Console.ReadLine();

            char[] letras = palavra.ToCharArray();

            ultimaLetra = Convert.ToString(letras[letras.Length - 1]);
            penultimaLetra = Convert.ToString(letras[letras.Length - 2]);

            if ((penultimaLetra == "a") && (ultimaLetra == "r"))
            {
                Console.WriteLine($"A palavra {palavra} é um verbo da 1ª conjugação");
            }
            else if((penultimaLetra == "e") && (ultimaLetra == "r"))
            {
                Console.WriteLine($"A palavra {palavra} é um verbo da 2ª conjugação");
            }
            else if((penultimaLetra == "i") && (ultimaLetra == "r"))
            {
                Console.WriteLine($"A palavra {palavra} é um verbo da 3ª conjugação");
            }
            else {
                Console.WriteLine($"O verbo {palavra} não está no infinitivo");
            }
        }
    }
}
