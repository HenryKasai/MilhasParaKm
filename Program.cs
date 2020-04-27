using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra quantos quilômetros é determinada quantidade de milhas.");
            string milhas = Console.ReadLine();
            int milha = Convert.ToInt32(milhas);
            string kms = "1,609";
            decimal km = Convert.ToDecimal(kms);
            decimal resultado = milha * km;
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
