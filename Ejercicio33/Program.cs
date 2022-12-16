namespace Ejercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce números separados por coma");

            string numeros = Console.ReadLine();
            string[] numerosDivididos = numeros.Split(',');

            foreach (string numero in numerosDivididos)
            {
                int number = int.Parse(numero);
                if (number % 2 == 0) Console.WriteLine(number);
            }
        }
    }
}