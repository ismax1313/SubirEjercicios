namespace Ejercicio28
{
    internal class Program
    {
        enum Formas { Circulo, Cuadrado, Triangulo};
        static void Main()
        {
            Console.WriteLine("Qué figura quieres calcular Circulo(0) , Triangulo(1) o Cuadrado(2)");
            

            Formas forma = (Formas)int.Parse(Console.ReadLine());

            switch (forma)
            {
                case Formas.Circulo:
                    forma = Formas.Circulo;
                    Console.WriteLine("Introduzca el radio");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"El área es {Math.Pow(radio, 2) * Math.PI}");
                    break;
                case Formas.Triangulo:
                    forma = Formas.Triangulo;
                    Console.WriteLine("Introduzca primero la base y luego la altura");
                    double @base = Convert.ToDouble(Console.ReadLine());
                    double altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"El área es {(@base*altura)/2}");
                    break;
                case Formas.Cuadrado:
                    forma = Formas.Cuadrado;
                    Console.WriteLine("Introduzca el lado");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"El área es {Math.Pow(lado, 2)}");
                    break;
                default:
                    Console.WriteLine("No eligió ninguna figura");
                    break;
            }
        }
    }
}