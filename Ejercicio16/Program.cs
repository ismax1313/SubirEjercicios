namespace Ejercicio16
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba un número natural");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahora introduce la base a ser intercambiada");
            int @base = Convert.ToInt32(Console.ReadLine());

            string space  = "";

            try
            {
                if (@base < 2 || @base > 9)
                {
                    throw new Exception ("Inserta una base entre 2 y 9 por favor, le introduciremos en base 2");
                }

            }
            catch (Exception convert)
            {
                @base = 2;  
            }

            for (; 0 < number1 / @base; number1 /= @base)
            {
                space += number1 % @base;
            }

            space = space + number1;

            for (int i = space.Length - 1; i >= 0; i--)
            {
                Console.Write(space[i]);
            }

            
            

            

        }
    }
}