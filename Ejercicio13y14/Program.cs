namespace Ejercicio13y14
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce un número entero");
            int number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(1, number+1);
                Console.WriteLine(randomNumber);

                if (randomNumber == number)
                {
                    Console.WriteLine("Coincide el número aleatorio");
                }
            }

            //int randomNumber = random.Next(1, numero + 1);

            Console.WriteLine("Inserta dos números enteros");
            int number1 = Convert.ToInt32(Console.ReadLine()); 
            int number2 = Convert.ToInt32(Console.ReadLine());

            Random random2 = new Random(number1);

            for (int j = 1; j <= number2; j++)
            {
                int randomNumber2 = random2.Next(0, 256);
                char tablaASCII = Convert.ToChar(randomNumber2);
                Console.WriteLine($"{randomNumber2} = {tablaASCII}");

            }
        }
    }
}