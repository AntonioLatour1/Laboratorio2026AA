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
           Console.WriteLine("Ingresa un numero de 2 cifras!:");
           num = Convert.ToInt16(Console.ReadLine());
           if(num >= 10 && num <= 99)
            {
                dec = num / 10;
                cent = num % 10;
                Console.WriteLine($"El numero original era {num}");
                Console.WriteLine($"El numero con sus cifras permutadas es : {cent}{dec}");
            }
            else 
            {
                
                Console.WriteLine("Ingrese un numero de dos cifras");
            }
           
           
           
           
        }
    }
}