using System;
using System.Globalization;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade, soma, count;
            double media;

            soma = 0;
            count = 0;

            idade = int.Parse(Console.ReadLine());

        while (idade >= 0) {
            soma = soma + idade;
            count = count + 1;
            //count++ Tambem pode ser utilizado;
            idade = int.Parse(Console.ReadLine());
        }

        if(count == 0){
            Console.WriteLine("IMPOSSIVEL CALCULAR");
            
        }else{

        media = (double)soma / count;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }

        Console.ReadLine();




            
        }
    }
}
