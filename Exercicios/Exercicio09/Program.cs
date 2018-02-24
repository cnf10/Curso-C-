using System;
using System.Globalization;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempoTotal, tempoRestante, tempoJogado;
            int N;
            tempoTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N = int.Parse(Console.ReadLine());
            tempoRestante = tempoTotal;
            for (int i=0; i<N; i++) {
            tempoJogado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tempoRestante = tempoRestante - tempoJogado;
            if (tempoRestante < 0.0) {
            Console.WriteLine("recarregar");
            }
            else {
            Console.WriteLine(tempoRestante);
            }
            }
            Console.ReadLine();
        }
    }
}
