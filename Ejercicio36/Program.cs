﻿namespace Ejercicio36
{
    internal class Program  //cambiar
    {
        static void Main()
        {
            Console.WriteLine("Introduce números enteros separados por comas");

            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(',');
            int[] numerosDeVerdad = new int[numerosDivididos.Length];

            int aux;
            for (int i = 0; i < numerosDeVerdad.Length - 1; i++)
            {
                for (int j = 0; j < numerosDeVerdad.Length - 1; j++)
                {
                    if (numerosDeVerdad[j] > numerosDeVerdad[j + 1])
                    {
                        aux = numerosDeVerdad[j];
                        numerosDeVerdad[j] = numerosDeVerdad[j + 1];
                        numerosDeVerdad[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numerosDeVerdad));
        }
    }
}