namespace Ejercicio19
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduzca la dimensión del diamante");
            int dimension = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < dimension * 2; i++)
            {
                if (i <= 1)
                {
                    Console.WriteLine(new String(' ', dimension * 2 - i) + new String('*', i));
                }
                else if (i <= dimension && i != 1)
                {
                    Console.WriteLine(new String(' ', dimension * 2 - i) + new String('*', i + i -1));
                }

                else if (i >= dimension)
                {
                    Console.Write(new String(' ', i) + new String('*', dimension * 2 - i));
                    Console.WriteLine(new String ('*', dimension * 2 - (i + 1)));

                }
            }
        }
    }
}