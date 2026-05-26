namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num;
           int mid;
           int mod;
           int trunc;
           int resultado;
           int[] array = new int[3];
           Console.WriteLine("Ingresa un numero de 3 cifras!");
           num = Convert.ToInt16(Console.ReadLine());
           if(num >= 100 && num <= 999)
            {
                mod = num % 10;
                trunc = num / 100;
                resultado = num - mod;
                resultado = resultado - (trunc * 100);
                Console.WriteLine($"El numero del medio es el numero {resultado / 10}");

            }
            else
            {
                Console.WriteLine("Ingrese un numero valido!");
            }
        }
    }
}