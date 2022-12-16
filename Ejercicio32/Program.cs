namespace Ejercicio_32
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i} => {numbers[i]}");
            }
        }
        static void CrearArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}