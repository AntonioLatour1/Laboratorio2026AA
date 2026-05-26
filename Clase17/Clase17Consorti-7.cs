using System;

namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorHora;
            double horasTrabajadas;
            double sueldoBruto;

            Console.WriteLine("Indicar el valor de una hora de trabajo:");
            valorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indicar la cantidad de horas trabajadas:");
            horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            if(valorHora > 0 && horasTrabajadas > 0)
            {
                sueldoBruto = valorHora * horasTrabajadas;

                Console.WriteLine($"Valor de la hora: ${valorHora}");
                Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
                Console.WriteLine($"Sueldo bruto: ${sueldoBruto}");
            }
            else
            {
                Console.WriteLine("Ingrese valores validos");
            }
        }
    }
}
