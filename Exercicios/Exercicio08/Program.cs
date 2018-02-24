using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
                int N, A, B;
                N = int.Parse(Console.ReadLine());
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                for (int i=A; i<=B; i++) {
                if (i % N == 0) { 
                Console.WriteLine(i);
                }
                }
                Console.ReadLine();
         }
    }
}
