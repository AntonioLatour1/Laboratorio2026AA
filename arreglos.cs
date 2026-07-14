using System.Transactions;

namespace arreglos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("=================");
                Console.WriteLine("guia ");
                Console.WriteLine("=================");
                Console.WriteLine("1 - Suma de resistencias en Serie.");
                Console.WriteLine("2 - Promedio y numero mas alto.");
                Console.WriteLine("3 - ");
                Console.WriteLine("4 - ");
                Console.WriteLine("5 - ");
                Console.WriteLine("6 - ");
                Console.WriteLine("7 - ");
                Console.WriteLine("8 - ");
                Console.WriteLine("9 - ");
                Console.WriteLine("10 - ");
                Console.WriteLine("11 - ");
                Console.WriteLine("12 - ");
                Console.WriteLine("13 - ");
                Console.WriteLine("14 - ");
                Console.WriteLine("15 - ");
                Console.WriteLine("0 - Salir");

                bool key = int.TryParse(Console.ReadLine(), out opcion);

                if (key == true)
                {
                    switch (opcion)
                    {
                        default: Console.WriteLine("Ingrese un numero valido"); break;
                        case 1: Ej1(); break;
                        case 2: Ej2(); break;
                        case 3: Ej3(); break;
                        case 4: Ej4(); break;
                        case 5: Ej5(); break;
                        case 6: Ej6(); break;
                        case 7: Ej7(); break;
                        case 8: Ej8(); break;
                        case 9: Ej9(); break;
                        case 10: Ej10(); break;
                        case 11: Ej11(); break;
                        case 12: Ej12(); break;
                        case 13: Ej13(); break;
                        case 14: Ej14(); break;
                        case 15: Ej15(); break;
                        case 16: Ej16(); break;
                        case 17: Ej17(); break;
                        case 18: Ej18(); break;
                        case 19: Ej19(); break;
                        case 20: Ej20(); break;
                    }
                }
            } while (opcion != 0);

        }

        static void Ej1()
        {
            Console.Clear();
            float[] resistencias = new float[5];
            float total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingresa el valor de la resistencia {i + 1}");
                bool key = float.TryParse(Console.ReadLine(), out resistencias[i]);

                if (key == true)
                {
                    total += resistencias[i];

                }
                else if (key == false)
                {
                    Console.WriteLine("Ingrese un numero valido");
                    break;
                }



            }

            Console.WriteLine("=================");
            Console.WriteLine($"El resultado es {total}");
            Console.WriteLine("=================");


        }

        static void Ej2()
        {
            float[] valores = new float[5];
            float prom = 1;
            float max = 1;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingresa el numero {i+1}");
                float.TryParse(Console.ReadLine(), out valores[i]);
                prom += valores[i];

                if (valores[i] > max)
                {
                    max = valores[i];
                }


            }
            Console.WriteLine($"El promedio de los numero es {prom/5} y el numero mas alto fue {max}");
        }

        static void Ej3()
        {
            Console.Clear();
            int num1;
            Console.WriteLine("=================");
            Console.WriteLine("Ingresa el numero 1");
            Console.WriteLine("=================");
            int.TryParse(Console.ReadLine(), out num1);
            int num2;
            Console.WriteLine("=================");
            Console.WriteLine("Ingresa el numero 2");
            Console.WriteLine("=================");
            int.TryParse(Console.ReadLine(), out num2);

            for( int i = num1+1; i < num2; i++)
            {
                Console.WriteLine(i);
                 

            }
        }

        static void Ej4()
        {
        }

        static void Ej5()
        {
        }

        static void Ej6()
        {
        }

        static void Ej7()
        {
        }

        static void Ej8()
        {
        }

        static void Ej9()
        {
        }

        static void Ej10()
        {
        }

        static void Ej11()
        {
        }

        static void Ej12()
        {
        }

        static void Ej13()
        {
        }

        static void Ej14()
        {
        }

        static void Ej15()
        {
        }

        static void Ej16()
        {
        }

        static void Ej17()
        {
        }

        static void Ej18()
        {
        }

        static void Ej19()
        {
        }

        static void Ej20()
        {
        }

    }
}


