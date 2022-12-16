namespace Ejercicio18
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduzca cuántos número quiere realizar");
            int many = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            for (int i = 1; i <= many; i++)
            {
                Console.WriteLine("Introduzca el número");
                double numbers = Convert.ToInt32(Console.ReadLine());
                
                result += Math.Pow(numbers, 2);
            }
            Console.WriteLine(Math.Sqrt(result / many));
        }
    }
}