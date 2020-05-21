using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Descubra quantos quilômetros é determinada quantidade de milhas.");
            string milhas = Console.ReadLine();
            double milha = Convert.ToDouble(milhas);
            double kms = 1.609;
            double resultado = milha * kms;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(resultado);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
