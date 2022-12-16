namespace Ejercicio15
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce un número entero");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int numberGroup = 0;

            for (int i = 1; i <= number1; i++)
            {
                Console.WriteLine("Introduce otro número entero");
                int number2 = Convert.ToInt32(Console.ReadLine());
                numberGroup += number2;
            }

            Console.WriteLine(numberGroup / number1);
        }
    }
}