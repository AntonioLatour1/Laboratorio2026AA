using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            do
            {
                Console.WriteLine("===================");
                Console.WriteLine("Ejercicios");
                Console.WriteLine("===================");
                Console.WriteLine("1. Matriz 6x5 por posicion");
                Console.WriteLine("2. Matriz 3x3 por columnas");
                Console.WriteLine("3. Matriz 5x5 diagonal y triangulos");
                Console.WriteLine("4. Matriz 3x3 ordenada");
                Console.WriteLine("5. Sorteos de LOTO");
                Console.WriteLine("6. Socios ordenados por edad");
                Console.WriteLine("7. Menu de clientes");
                Console.WriteLine("0. Salir");

                string entrada = Console.ReadLine();
                bool esValido = int.TryParse(entrada, out int opcion);

                if (!esValido)
                {
                    Console.WriteLine("Opcion invalida, ingrese un numero");
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                            Ejercicio1();
                            break;
                        case 2:
                            Ejercicio2();
                            break;
                        case 3:
                            Ejercicio3();
                            break;
                        case 4:
                            Ejercicio4();
                            break;
                        case 5:
                            Ejercicio5();
                            break;
                        case 6:
                            Ejercicio6();
                            break;
                        case 7:
                            Ejercicio7();
                            break;
                        case 0:
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }

            } while (continuar);
        }

        static void Ejercicio1()
        {
            int[,] matriz = new int[6, 5];

            for (int fila = 0; fila < 6; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Console.WriteLine("Ingrese el número de fila donde desea reemplazar el elemento. Seleccione 0 para salir: ");
                    int f = Convert.ToInt16(Console.ReadLine());

                    if (f == 0)
                    {
                        Console.WriteLine("Fin");
                        return;
                    }

                    Console.WriteLine("Ingrese el número de columna donde desea reemplazar el elemento: ");
                    int c = Convert.ToInt16(Console.ReadLine());

                    Console.Write($"Ingrese un número para la fila {f}, columna {c}: ");
                    matriz[f, c] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz:");

            for (int fila = 0; fila < 6; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Ejercicio2()
        {
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1)
                    {
                        Console.WriteLine($"ingrese el contenido de la matriz {i},{j}");
                        matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"ingrese el contenido de la matriz {i},{j}");
                        matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.WriteLine($"ingrese el contenido de la matriz {i},{j}");
                        matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("\nMatriz:");

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Ejercicio3()
        {
            int[,] matriz = new int[5, 5];

            Console.WriteLine("Ingrese los valores de la primera diagonal");
            for (int i = 0; i < 5; i++)
            {
                matriz[i, i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Ingrese los valores del triangulo superior");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese los valores del triangulo inferior");
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    matriz[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Ejercicio4()
        {
            int[,] matriz = new int[3, 3];
            int[] array = new int[9];
            int asd = 0;

            for (int i = 0; i < 9; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 9 - 1; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    matriz[fila, columna] = array[asd];
                    asd += 1;
                }
            }

            Console.WriteLine("\nMatriz:");

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Ejercicio5()
        {
            int[,] sorteos = new int[3, 6];
            int[] contadores = new int[43];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int num = 0;
                    bool valido = false;

                    do
                    {
                        Console.WriteLine($"Ingrese el numero {j + 1} del sorteo {i + 1} (de 0 a 42)");
                        num = Convert.ToInt32(Console.ReadLine());

                        if (num < 0 || num > 42)
                        {
                            Console.WriteLine("El numero debe estar entre 0 y 42");
                            valido = false;
                        }
                        else
                        {
                            valido = true;

                            for (int k = 0; k < j; k++)
                            {
                                if (sorteos[i, k] == num)
                                {
                                    valido = false;
                                }
                            }

                            if (valido == false)
                            {
                                Console.WriteLine("Ese numero ya salio en este sorteo");
                            }
                        }

                    } while (valido == false);

                    sorteos[i, j] = num;
                    contadores[num] += 1;
                }
            }

            int n = 0;
            bool validoN = false;

            do
            {
                Console.WriteLine("Ingrese el numero N (de 0 a 42)");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 0 || n > 42)
                {
                    Console.WriteLine("El numero debe estar entre 0 y 42");
                }
                else
                {
                    validoN = true;
                }

            } while (validoN == false);

            int maximo = 0;

            for (int i = 0; i < 43; i++)
            {
                if (contadores[i] > maximo)
                {
                    maximo = contadores[i];
                }
            }

            Console.WriteLine($"\nNumero/s que mas veces salio, con {maximo} apariciones:");

            for (int i = 0; i < 43; i++)
            {
                if (contadores[i] == maximo)
                {
                    Console.WriteLine("Numero: " + i);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6 - 1; j++)
                {
                    for (int k = j + 1; k < 6; k++)
                    {
                        if (sorteos[i, j] > sorteos[i, k])
                        {
                            int aux = sorteos[i, j];
                            sorteos[i, j] = sorteos[i, k];
                            sorteos[i, k] = aux;
                        }
                    }
                }
            }

            Console.WriteLine("\nSorteos ordenados de menor a mayor:");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Sorteo {i + 1}:\t");

                for (int j = 0; j < 6; j++)
                {
                    Console.Write(sorteos[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nEl numero {n} se repite {contadores[n]} veces entre todos los sorteos");
        }

        static void Ejercicio6()
        {
            int contador = 0;
            int socio;
            int[] edades = new int[10];
            int[,] matriz = new int[10, 2];

            do
            {
                Console.WriteLine("Ingrese el numero de socio");
                socio = Convert.ToInt32(Console.ReadLine());

                if (socio != 0)
                {
                    Console.WriteLine("Ingrese la edad");
                    edades[contador] = Convert.ToInt32(Console.ReadLine());

                    matriz[contador, 0] = socio;
                    matriz[contador, 1] = edades[contador];

                    contador += 1;
                }

            } while (contador < 10 && socio != 0);

            for (int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (edades[i] > edades[j])
                    {
                        int auxEdad = edades[i];
                        edades[i] = edades[j];
                        edades[j] = auxEdad;

                        int auxMatrizEdad = matriz[i, 1];
                        matriz[i, 1] = matriz[j, 1];
                        matriz[j, 1] = auxMatrizEdad;

                        int auxSocio = matriz[i, 0];
                        matriz[i, 0] = matriz[j, 0];
                        matriz[j, 0] = auxSocio;
                    }
                }
            }

            Console.WriteLine("Lista ordenada por edad:");

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Socio: " + matriz[i, 0] + " - Edad: " + matriz[i, 1]);
            }
        }

        static void Ejercicio7()
        {
            double[,] excel = new double[10, 10];

            bool continuar = true;
            int opcion = 1;

            int check2 = -1;

            bool check = true;

            do
            {
                Console.Clear();

                Console.WriteLine("===================");
                Console.WriteLine("1. Elegir cliente");
                Console.WriteLine("2. Cerrar");
                Console.WriteLine("===================");

                string entrada2 = Console.ReadLine();
                bool check3 = int.TryParse(entrada2, out check2);

                if (check3 == true)
                {
                    switch (check2)
                    {
                        case 1:

                            Console.Clear();

                            Console.WriteLine("===================");
                            Console.WriteLine("Ingrese el numero de cliente");
                            Console.WriteLine("===================");

                            string entrada1 = Console.ReadLine();
                            bool check1 = int.TryParse(entrada1, out int clienteNum);

                            if (check1)
                            {
                                continuar = true;

                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("===================");
                                    Console.WriteLine($"N° Cliente {clienteNum}");
                                    Console.WriteLine("===================");
                                    Console.WriteLine("Bienvendio al Menu");
                                    Console.WriteLine("===================");
                                    Console.WriteLine("1. Deposito");
                                    Console.WriteLine("2. Extraccion");
                                    Console.WriteLine("3. Comisiones deducidas");
                                    Console.WriteLine("4. Intereses acreditados");
                                    Console.WriteLine("5. Info");
                                    Console.WriteLine("0. Salir");

                                    string entrada = Console.ReadLine();
                                    bool esValido = int.TryParse(entrada, out opcion);

                                    if (!esValido)
                                    {
                                        Console.WriteLine("Opcion invalida, ingrese un numero");
                                    }
                                    else
                                    {
                                        switch (opcion)
                                        {
                                            case 1:

                                                double tempD = a();

                                                excel[clienteNum, 5] += tempD;

                                                excel[clienteNum, opcion] += tempD;

                                                break;
                                            case 2:

                                                double tempE = b();

                                                excel[clienteNum, 5] -= tempE;

                                                excel[clienteNum, opcion] += tempE;

                                                break;
                                            case 3:

                                                double tempC = c();

                                                excel[clienteNum, 5] -= tempC;

                                                excel[clienteNum, opcion] += tempC;

                                                break;
                                            case 4:

                                                double tempI = d();

                                                excel[clienteNum, 5] += tempI;

                                                excel[clienteNum, opcion] += tempI;

                                                break;
                                            case 5:

                                                int numC = e();

                                                Console.WriteLine($"Numero de cliente: {numC} | Total depositos: {excel[numC, 1]} | Total Extracciones: {excel[numC, 2]} | Total Comisiones: {excel[numC, 3]} | Total Intereses: {excel[numC, 4]} | Saldo Total: {excel[numC, 5]}");
                                                Console.ReadLine();

                                                break;
                                            case 0:
                                                continuar = false;
                                                break;
                                            default:
                                                Console.WriteLine("Opcion invalida");
                                                break;
                                        }
                                    }

                                } while (continuar);
                            }
                            break;
                        case 2:

                            check = false;
                            break;
                        default:

                            Console.WriteLine("Ingrese una opcion valida");
                            break;
                    }
                }

            } while (check);
        }

        static public double a()
        {
            Console.Clear();
            Console.WriteLine($"Ingrese el monto a depositar");
            double num = Convert.ToDouble(Console.ReadLine());

            return num;
        }

        static public double b()
        {
            Console.Clear();
            Console.WriteLine($"Ingrese el monto a extraer");
            double num = Convert.ToDouble(Console.ReadLine());

            return num;
        }

        static public double c()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el total de comisiones");
            double num = Convert.ToDouble(Console.ReadLine());

            return num;
        }

        static public double d()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el total de intereses");
            double num = Convert.ToDouble(Console.ReadLine());

            return num;
        }

        static public int e()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el numero de cliente para ver sus numeros.");
            int numC = Convert.ToInt16(Console.ReadLine());

            return numC;
        }
    }
}
