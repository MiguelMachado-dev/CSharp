﻿using System;

namespace P12_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando projeto Fatorial");

            int fatorial = 1;

            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine($"Fatorial de {i} = {fatorial}");
            }

            Console.ReadLine();
        }
    }
}
