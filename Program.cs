﻿using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int formula, contador, numero;

            Console.Write("Digite um número : ");
            numero = Int32.Parse(Console.ReadLine());

            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);
            }
            Console.ReadLine();
        }
    }
}