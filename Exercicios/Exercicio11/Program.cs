﻿using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
           
        int volume, comando;
        volume = int.Parse(Console.ReadLine());
        comando = int.Parse(Console.ReadLine());
        while (comando != 0) {
        volume = volume + comando;
        if (volume < 0) {
        volume = 0;
        }
        if (volume > 100) {
        volume = 100;
        }
        Console.WriteLine(volume);
        comando = int.Parse(Console.ReadLine());
        }
        Console.ReadLine();
        
        }
    }
}
