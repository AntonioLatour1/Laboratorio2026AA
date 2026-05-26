using System;

namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double centigrados;

            Console.WriteLine("Indicar temperatura en grados Fahrenheit:");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            centigrados = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit}");
            Console.WriteLine($"Temperatura en grados centigrados: {centigrados}");
        }
    }
}
