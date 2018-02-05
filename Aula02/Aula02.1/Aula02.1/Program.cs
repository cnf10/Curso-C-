using System;
using System.Globalization;

namespace Aula02._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para realizar entrada de dados mesma linha

            string x;
            int y;
            double z;

            string[] vet = Console.ReadLine().Split(' ');

            x = vet[0];
            y = int.Parse(vet[1]);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
