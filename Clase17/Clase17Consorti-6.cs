using System;

namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            double perimetro;
            double superficie;

            Console.WriteLine("Indicar el valor del lado del cuadrado:");
            lado = Convert.ToDouble(Console.ReadLine());

            if(lado > 0)
            {
                perimetro = lado * 4;
                superficie = lado * lado;

                Console.WriteLine($"Lado del cuadrado: {lado}");
                Console.WriteLine($"Perimetro: {perimetro}");
                Console.WriteLine($"Superficie: {superficie}");
            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }
        }
    }
}
