namespace Ejercicio9y10
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce un carácter 'C' , 'S' , 'V' , 'D' ");
            string character = Console.ReadLine();
            character = character.ToUpper();

            switch (character)
            {
                case "C":
                    Console.WriteLine("Casado");
                    break ;
                case "S":
                    Console.WriteLine("Soltero");
                    break ;
                case "V":
                    Console.WriteLine("Viudo");
                    break;
                case "D":
                    Console.WriteLine("Divorciado");
                    break;
                default:
                    Console.WriteLine("Este estado no existe");
                    break;
            }

            Console.WriteLine("Introduzca un número entero");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}