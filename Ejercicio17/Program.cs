using System.Globalization;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba un texto");
            string texto = Console.ReadLine();
            texto = texto.ToLower();

            string space = "";

            for (int i = 0; i < texto.Length; i++)
            {
                int counter = 0;

                if (space.Contains(texto[i]))
                { }
                else
                {
                    space += texto[i];
                    for (int j = 0; j < texto.Length; j++)
                    {
                        if (texto[j] == texto[i])
                        {
                           counter++;
                        }
                        
                    }

                    Console.WriteLine($"{texto[i]}={counter}");
                }
            }
        }
    }
}