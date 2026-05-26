using System;

namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora1;
            int minuto1;
            int segundo1;
            int hora2;
            int minuto2;
            int segundo2;
            int total1;
            int total2;
            int intervalo;

            Console.WriteLine("Indicar la hora del primer instante:");
            hora1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar los minutos del primer instante:");
            minuto1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar los segundos del primer instante:");
            segundo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar la hora del segundo instante:");
            hora2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar los minutos del segundo instante:");
            minuto2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indicar los segundos del segundo instante:");
            segundo2 = Convert.ToInt32(Console.ReadLine());

            if(hora1 >= 0 && hora1 <= 23 && hora2 >= 0 && hora2 <= 23 && minuto1 >= 0 && minuto1 <= 59 && minuto2 >= 0 && minuto2 <= 59 && segundo1 >= 0 && segundo1 <= 59 && segundo2 >= 0 && segundo2 <= 59)
            {
                total1 = hora1 * 3600 + minuto1 * 60 + segundo1;
                total2 = hora2 * 3600 + minuto2 * 60 + segundo2;

                if(total2 >= total1)
                {
                    intervalo = total2 - total1;
                }
                else
                {
                    intervalo = total1 - total2;
                }

                Console.WriteLine($"Primer instante: {hora1}:{minuto1}:{segundo1}");
                Console.WriteLine($"Segundo instante: {hora2}:{minuto2}:{segundo2}");
                Console.WriteLine($"El intervalo contiene {intervalo} segundos");
            }
            else
            {
                Console.WriteLine("Ingrese horarios validos");
            }
        }
    }
}
