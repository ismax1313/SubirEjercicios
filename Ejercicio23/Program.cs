namespace Ejercicio23
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba dos números enteros");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (number1 >= 1 && number2 >= 1)
                {
                    Console.WriteLine(number1 / number2);
                }
                else
                {
                    throw new Exception("Acción no válida");
                }
            }
            catch (Exception numbers)
            {
                Console.WriteLine("Hemos cambiado los valores por 1, no puedes dividir entre 0");
                number1 = 1;
                number2 = 1; 
                Console.WriteLine(number1 / number2);

            }

        }
    }
}