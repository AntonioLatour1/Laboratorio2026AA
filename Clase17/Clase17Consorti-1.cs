namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num;
           int dec;
           int cent;
           int[] array = new int[2];
           Console.WriteLine("Ingresa un numero:");
           num = Convert.ToInt16(Console.ReadLine());
           if(num >= 10 && num <= 99)
            {
                dec = num / 10;
                cent = num % 10;
                Console.WriteLine($"La cifra de la centena es {cent}");
                Console.WriteLine($"La cifra de la unidad es {dec}");
            }
            else 
            {
                
                Console.WriteLine("Ingrese un numero de dos cifras");
            }
           
           
           
           
        }
    }
}