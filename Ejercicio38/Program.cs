namespace Ejercicio38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

            for (int i = 1; i < numbers.Length; i += 2) //posiciones impares más leible
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}