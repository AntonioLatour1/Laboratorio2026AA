using System;

namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int centenas;
            int decenas;
            int unidades;

            Console.WriteLine("Indicar un numero de 3 digitos:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num >= 100 && num <= 999)
            {
                centenas = num / 100;
                decenas = (num / 10) % 10;
                unidades = num % 10;

                Console.WriteLine($"Valor ingresado: {num}");
                Console.WriteLine($"Unidades: {unidades}");
                Console.WriteLine($"Decenas: {decenas}");
                Console.WriteLine($"Centenas: {centenas}");
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido de 3 digitos");
            }
        }
    }
}
