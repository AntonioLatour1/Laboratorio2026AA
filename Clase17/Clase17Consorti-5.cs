using System;

namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fecha;
            int mes;

            Console.WriteLine("Indicar una fecha como un entero de 6 digitos:");
            fecha = Convert.ToInt32(Console.ReadLine());

            if(fecha >= 100000 && fecha <= 999999)
            {
                mes = (fecha / 100) % 100;

                Console.WriteLine($"Fecha: {fecha}");

                if(mes < 10)
                {
                    Console.WriteLine($"Mes: 0{mes}");
                }
                else
                {
                    Console.WriteLine($"Mes: {mes}");
                }
            }
            else
            {
                Console.WriteLine("Ingrese una fecha valida de 6 digitos");
            }
        }
    }
}
