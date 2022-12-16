namespace Ejercicio_35
{
    internal class Program
    {

        //static readonly char[] LETTERS = new { '' }; cada carácter y su coma
        const string LETTERS = "TRWAGMYFPDXBNJZSQVHLCKE";
        static void Main()
        {
            Console.WriteLine("Introduce tu DNI");

            int dni = int.Parse(Console.ReadLine());
            char letra = LETTERS[dni % LETTERS.Length]; //23//

            Console.WriteLine($"Tu dni es {0}{1}", dni, letra);
        }
    }
}