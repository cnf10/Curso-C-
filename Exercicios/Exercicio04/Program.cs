using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double glicose;
            glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (glicose <= 100.0) {
            Console.WriteLine("Normal");
            }
            else if (glicose <= 140.0) {
            Console.WriteLine("Elevado");
            }
            else {
            Console.WriteLine("Diabetes");
            }
            Console.ReadLine();
        }
    }
}
