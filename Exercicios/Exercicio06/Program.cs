using System;
using System.Globalization;
namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            soma = 0;
            for (int i=a; i<=b; i++) {
            if (i % 2 != 0) { // testa se i é impar
            soma = soma + i;
            }
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
