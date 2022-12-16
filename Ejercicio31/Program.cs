namespace Ejercicio31
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = new int[100];

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                count += numbers[i];
            }
            Console.WriteLine(count);
        }
    }
}