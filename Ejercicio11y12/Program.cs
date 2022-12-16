namespace Ejercicio11y12
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduzca un número");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (i == 2 || i == 3)
                {
                    Console.WriteLine(i);
                }
                else if (i % i == 0 && i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 11 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Escriba una palabra");
            string word = Console.ReadLine();
            //word = word.Replace(" ", "");
            bool palindromo = true;

            for (int j = 0; j <= word.Length - 1; j++)
            {
                for (int k = word.Length - 1; k >= 0; k--)  //por qué era el -1
                {
                    if (word[j] != word[k])
                    {
                        palindromo = false;
                    }
                    else if (word[k] == word[j])
                    {
                        palindromo = true;
                    }
                }
            }

            if (palindromo == true)
            {
                Console.WriteLine("Es un palíndromo");
            }
            else
            {
                Console.WriteLine("No es un palíndromo");
            }
        }
    }
}