namespace Ejercicio37
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce la cantidad de números");

            int size = int.Parse(Console.ReadLine());

            int[] numbers = CreateArray(size);

            Console.WriteLine($"[{String.Join(", ", numbers)}]");
        }

        static int[] CreateArray(int size)
        {
            int[] result = new int[size];
            Random random = new Random();

            for (int i = 0; i < result.Length; i++)
            {
                int number;

                do
                {
                    number = random.Next(5);
                }
                while (Contains(result, number));

                result[i] = random.Next(size);
            }

            return result;
        }

        static bool Contains(int[] array, int item)
        {
            bool result = false;
            foreach (int number in array)
            {
                if (number == item) result = true;
            }
            return result;


        }

    }