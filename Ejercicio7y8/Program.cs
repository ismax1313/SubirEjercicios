namespace Ejercicio7y8
{
    internal class Program    //Se puede poner enumerados en este
    {
        static void Main()
        {
            Console.WriteLine("Introduzca tres números");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2 && number1 == number3)
            {
                Console.WriteLine("Es Equilátero");
            }
            else if (number1 != number2 && number1 != number3 && number2 != number3)
            {
                Console.WriteLine("Es Escaleno");
            }
            else
            {
                Console.WriteLine("Es Isósceles");
            }

            Console.WriteLine("Escriba un número entero de dos cifras");
            int unitNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(unitNumber % 10 * 10 + unitNumber / 10);



        }
    }
}