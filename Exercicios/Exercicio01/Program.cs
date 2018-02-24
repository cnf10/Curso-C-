using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumeInicial, vazao, tempo, volumeFinal;

            volumeInicial = int.Parse(Console.ReadLine());
            vazao = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());

            if(vazao * tempo > volumeInicial)
            {
                Console.WriteLine("NAO E POSSIVEL");

            }else{
                volumeFinal = volumeInicial - (vazao * tempo);
                Console.WriteLine(volumeFinal);
            }

            Console.ReadLine();
        }
    }
}
