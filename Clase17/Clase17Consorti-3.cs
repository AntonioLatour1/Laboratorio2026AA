namespace Clase17Consorti
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double num;
           double result;
           double apoyo;
           
           Console.WriteLine("Ingresa el precio de la prenda:");
           num = Convert.ToDouble(Console.ReadLine());
           
           result = (num / 100) * 18;
           Console.WriteLine($"=============================");
           Console.WriteLine($"Precio de la prenda original {num}");
           Console.WriteLine($"El precio de la prenda con 18% de descuento: {num - result}");
           
           
           
        }
    }
}