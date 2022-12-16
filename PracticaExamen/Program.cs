namespace PracticaExamen
{
    class Program
    {
        static void Main()
        {
            //Ejercicio 1
            Console.WriteLine("Introduce tu nombre");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hola " + name);

            //Ejercicio 2
            Console.WriteLine("Introduzca dos números");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + number2);

            //Ejercicio 3
            Console.WriteLine("Introduce la temperatura en ºF");
            double degrees = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((degrees-32)/9*5);

            //Ejercicio 4 
            Console.WriteLine("Introduce un número entero");
            int number3 = Convert.ToInt32(Console.ReadLine());
            string numberUnits = number3.ToString();


            Console.WriteLine(number3 % 10);

        }
    }
}