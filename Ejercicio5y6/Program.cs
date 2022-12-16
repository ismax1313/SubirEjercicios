namespace Ejercicio5y6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce un número");
            int numberEntero = Convert.ToInt32(Console.ReadLine());
            if (numberEntero % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }

            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 65)
            {
                Console.WriteLine("Jubilado");
            }
            else if ((age >= 18) && (age < 65))
            {
                Console.WriteLine("Activo");
            }
            else
            {
                Console.WriteLine("Menor de Edad");
            }
        }
    }
}