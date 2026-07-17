using System;

class Program
{
    static void Main()
    {
        int opcion = -1;
        bool continuar = true;
        do
        {
            Console.WriteLine();
            Console.WriteLine("1) Resistencias en serie");
            Console.WriteLine("2) Promedio y mayor de 5 numeros");
            Console.WriteLine("3) Numeros intermedios");
            Console.WriteLine("4) Promedio de 30 alumnos");
            Console.WriteLine("5) Vendedores");
            Console.WriteLine("6) Sueldos mayores y menores a 2000");
            Console.WriteLine("7) Posicion de notas mayores a 8");
            Console.WriteLine("8) Fibonacci");
            Console.WriteLine("9) Ascendente, descendente o desordenado");
            Console.WriteLine("10) Suma, producto, promedio y menores al promedio");
            Console.WriteLine("11) Menor valor y repetidos en vector de 100");
            Console.WriteLine("12) Ordenar ascendente, descendente y multiplicar");
            Console.WriteLine("13) Elementos pares (valor)");
            Console.WriteLine("14) Elementos en posiciones pares");
            Console.WriteLine("15) Tercer vector con impares y pares");
            Console.WriteLine("16) Vector C(i) = A(i) * B(N-i-1)");
            Console.WriteLine("17) Invertir vector");
            Console.WriteLine("18) Analizar vector (igual, creciente, decreciente, otro)");
            Console.WriteLine("19) Años bisiestos");
            Console.WriteLine("20) Productos y precios");
            Console.WriteLine("0) Salir");
            Console.Write("Opcion: ");
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
                    case 8:
                        Ejercicio8();
                        break;
                    case 9:
                        Ejercicio9();
                        break;
                    case 10:
                        Ejercicio10();
                        break;
                    case 11:
                        Ejercicio11();
                        break;
                    case 12:
                        Ejercicio12();
                        break;
                    case 13:
                        Ejercicio13();
                        break;
                    case 14:
                        Ejercicio14();
                        break;
                    case 15:
                        Ejercicio15();
                        break;
                    case 16:
                        Ejercicio16();
                        break;
                    case 17:
                        Ejercicio17();
                        break;
                    case 18:
                        Ejercicio18();
                        break;
                    case 19:
                        Ejercicio19();
                        break;
                    case 20:
                        Ejercicio20();
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
        double[] resistencias = new double[5];
        double total = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Resistencia " + (i + 1) + ": ");
            resistencias[i] = Convert.ToDouble(Console.ReadLine());
            total = total + resistencias[i];
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Resistencia " + (i + 1) + " = " + resistencias[i]);
        }
        Console.WriteLine("Resistencia total = " + total);
    }

    static void Ejercicio2()
    {
        int[] numeros = new int[5];
        int suma = 0;
        int mayor;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Numero " + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            suma = suma + numeros[i];
        }
        mayor = numeros[0];
        for (int i = 1; i < 5; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }
        double promedio = suma / 5.0;
        Console.WriteLine("Promedio = " + promedio);
        Console.WriteLine("Mayor = " + mayor);
    }

    static void Ejercicio3()
    {
        int n1, n2, menor, mayor;
        Console.Write("Primer numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        if (n1 < n2)
        {
            menor = n1;
            mayor = n2;
        }
        else
        {
            menor = n2;
            mayor = n1;
        }
        int cantidad = mayor - menor - 1;
        if (cantidad <= 0)
        {
            Console.WriteLine("No hay numeros intermedios");
        }
        else
        {
            int[] vector = new int[cantidad];
            int valor = menor + 1;
            for (int i = 0; i < cantidad; i++)
            {
                vector[i] = valor;
                valor = valor + 1;
            }
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }

    static void Ejercicio4()
    {
        double[] notas = new double[30];
        double suma = 0;
        for (int i = 0; i < 30; i++)
        {
            Console.Write("Nota del alumno " + (i + 1) + ": ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            suma = suma + notas[i];
        }
        double promedio = suma / 30;
        Console.WriteLine("Promedio general del curso = " + promedio);
    }

    static void Ejercicio5()
    {
        int[,] ventas = new int[20, 15];
        int totalUnidades = 0;
        int mayorVentaDiaria = 0;
        int vendedorMayor = 0;
        for (int v = 0; v < 20; v++)
        {
            for (int d = 0; d < 15; d++)
            {
                Console.Write("Vendedor " + (v + 1) + " dia " + (d + 1) + ": ");
                ventas[v, d] = Convert.ToInt32(Console.ReadLine());
                totalUnidades = totalUnidades + ventas[v, d];
                if (ventas[v, d] > mayorVentaDiaria)
                {
                    mayorVentaDiaria = ventas[v, d];
                    vendedorMayor = v + 1;
                }
            }
        }
        Console.WriteLine("Total unidades vendidas = " + totalUnidades);
        Console.WriteLine("Vendedor con mayor venta diaria = " + vendedorMayor + " (" + mayorVentaDiaria + " unidades)");
    }

    static void Ejercicio6()
    {
        double[] sueldos = new double[20];
        int mayores = 0;
        int menores = 0;
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Sueldo " + (i + 1) + ": ");
            sueldos[i] = Convert.ToDouble(Console.ReadLine());
            if (sueldos[i] > 2000)
            {
                mayores = mayores + 1;
            }
            else
            {
                menores = menores + 1;
            }
        }
        Console.WriteLine("Ganan mas de 2000: " + mayores);
        Console.WriteLine("Ganan menos o igual a 2000: " + menores);
    }

    static void Ejercicio7()
    {
        double[] notas = new double[15];
        for (int i = 0; i < 15; i++)
        {
            Console.Write("Nota del alumno " + (i + 1) + ": ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Alumnos con nota mayor a 8:");
        for (int i = 0; i < 15; i++)
        {
            if (notas[i] > 8)
            {
                Console.WriteLine("Posicion " + (i + 1));
            }
        }
    }

    static void Ejercicio8()
    {
        int[] fib = new int[10];
        fib[0] = 1;
        fib[1] = 1;
        for (int i = 2; i < 10; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Write(fib[i] + " ");
        }
        Console.WriteLine();
    }

    static void Ejercicio9()
    {
        Console.Write("Cantidad de numeros a ingresar: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] vector = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Numero " + (i + 1) + ": ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }
        bool ascendente = true;
        bool descendente = true;
        for (int i = 0; i < n - 1; i++)
        {
            if (vector[i] > vector[i + 1])
            {
                ascendente = false;
            }
            if (vector[i] < vector[i + 1])
            {
                descendente = false;
            }
        }
        if (ascendente)
        {
            Console.WriteLine("Los numeros fueron ingresados en forma ascendente");
        }
        else if (descendente)
        {
            Console.WriteLine("Los numeros fueron ingresados en forma descendente");
        }
        else
        {
            Console.WriteLine("Los numeros fueron ingresados en forma desordenada");
        }
        Console.WriteLine("Suma entre el primero y el ultimo = " + (vector[0] + vector[n - 1]));
    }

    static void Ejercicio10()
    {
        int[] vector = new int[10];
        int suma = 0;
        long producto = 1;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
            suma = suma + vector[i];
            producto = producto * vector[i];
        }
        double promedio = suma / 10.0;
        int cantidadMenores = 0;
        for (int i = 0; i < 10; i++)
        {
            if (vector[i] < promedio)
            {
                cantidadMenores = cantidadMenores + 1;
            }
        }
        Console.WriteLine("Suma = " + suma);
        Console.WriteLine("Producto = " + producto);
        Console.WriteLine("Promedio = " + promedio);
        Console.WriteLine("Cantidad de elementos por debajo del promedio = " + cantidadMenores);
    }

    static void Ejercicio11()
    {
        int[] vector = new int[100];
        for (int i = 0; i < 100; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }
        int menor = vector[0];
        for (int i = 1; i < 100; i++)
        {
            if (vector[i] < menor)
            {
                menor = vector[i];
            }
        }
        bool hayRepetido = false;
        int elementoRepetido = 0;
        int vecesRepetido = 0;
        for (int i = 0; i < 100 && !hayRepetido; i++)
        {
            int contador = 0;
            for (int j = 0; j < 100; j++)
            {
                if (vector[j] == vector[i])
                {
                    contador = contador + 1;
                }
            }
            if (contador > 1)
            {
                hayRepetido = true;
                elementoRepetido = vector[i];
                vecesRepetido = contador;
            }
        }
        Console.WriteLine("Elemento mas pequeño = " + menor);
        if (hayRepetido)
        {
            Console.WriteLine("Elemento repetido = " + elementoRepetido);
            Console.WriteLine("Cantidad de veces que se repite = " + vecesRepetido);
        }
        else
        {
            Console.WriteLine("No hay elementos repetidos");
        }
    }

    static void Ejercicio12()
    {
        int[] original = new int[20];
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            original[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] ascendente = new int[20];
        int[] descendente = new int[20];
        for (int i = 0; i < 20; i++)
        {
            ascendente[i] = original[i];
            descendente[i] = original[i];
        }
        for (int i = 0; i < 19; i++)
        {
            for (int j = 0; j < 19 - i; j++)
            {
                if (ascendente[j] > ascendente[j + 1])
                {
                    int aux = ascendente[j];
                    ascendente[j] = ascendente[j + 1];
                    ascendente[j + 1] = aux;
                }
            }
        }
        for (int i = 0; i < 19; i++)
        {
            for (int j = 0; j < 19 - i; j++)
            {
                if (descendente[j] < descendente[j + 1])
                {
                    int aux = descendente[j];
                    descendente[j] = descendente[j + 1];
                    descendente[j + 1] = aux;
                }
            }
        }
        int[] producto = new int[20];
        for (int i = 0; i < 20; i++)
        {
            producto[i] = ascendente[i] * descendente[i];
        }
        Console.WriteLine("Vector ascendente:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(ascendente[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Vector descendente:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(descendente[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Vector producto:");
        for (int i = 0; i < 20; i++)
        {
            Console.Write(producto[i] + " ");
        }
        Console.WriteLine();
    }

    static void Ejercicio13()
    {
        int[] vector = new int[6];
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Elementos pares:");
        for (int i = 0; i < 6; i++)
        {
            if (vector[i] % 2 == 0)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }

    static void Ejercicio14()
    {
        int[] vector = new int[6];
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Elementos en posiciones pares:");
        for (int i = 0; i < 6; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }

    static void Ejercicio15()
    {
        int[] vectorA = new int[10];
        int[] vectorB = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Vector A elemento " + (i + 1) + ": ");
            vectorA[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Vector B elemento " + (i + 1) + ": ");
            vectorB[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] vectorC = new int[10];
        int pos = 0;
        for (int i = 0; i < 10; i++)
        {
            if ((i + 1) % 2 != 0)
            {
                vectorC[pos] = vectorA[i];
                pos = pos + 1;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                vectorC[pos] = vectorB[i];
                pos = pos + 1;
            }
        }
        Console.WriteLine("Vector C:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(vectorC[i] + " ");
        }
        Console.WriteLine();
    }

    static void Ejercicio16()
    {
        int[] vectorA = new int[6];
        int[] vectorB = new int[6];
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Vector A elemento " + (i + 1) + ": ");
            vectorA[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 6; i++)
        {
            Console.Write("Vector B elemento " + (i + 1) + ": ");
            vectorB[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] vectorC = new int[6];
        for (int i = 0; i < 6; i++)
        {
            vectorC[i] = vectorA[i] * vectorB[6 - i - 1];
        }
        Console.WriteLine("Vector C:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write(vectorC[i] + " ");
        }
        Console.WriteLine();
    }

    static void Ejercicio17()
    {
        Console.Write("Cantidad de elementos: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] vector = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] invertido = new int[n];
        for (int i = 0; i < n; i++)
        {
            invertido[i] = vector[n - i - 1];
        }
        Console.WriteLine("Vector invertido:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(invertido[i] + " ");
        }
        Console.WriteLine();
    }

    static void Ejercicio18()
    {
        int[] vector = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Elemento " + (i + 1) + ": ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }
        bool iguales = true;
        bool creciente = true;
        bool decreciente = true;
        for (int i = 0; i < 9; i++)
        {
            if (vector[i] != vector[i + 1])
            {
                iguales = false;
            }
            if (vector[i] >= vector[i + 1])
            {
                creciente = false;
            }
            if (vector[i] <= vector[i + 1])
            {
                decreciente = false;
            }
        }
        if (iguales)
        {
            Console.WriteLine(1);
        }
        else if (creciente)
        {
            Console.WriteLine(2);
        }
        else if (decreciente)
        {
            Console.WriteLine(3);
        }
        else
        {
            Console.WriteLine(4);
        }
    }

    static void Ejercicio19()
    {
        int[] anios = new int[15];
        for (int i = 0; i < 15; i++)
        {
            Console.Write("Año " + (i + 1) + ": ");
            anios[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] bisiestos = new int[15];
        int cantidad = 0;
        for (int i = 0; i < 15; i++)
        {
            if ((anios[i] % 4 == 0 && anios[i] % 100 != 0) || anios[i] % 400 == 0)
            {
                bisiestos[cantidad] = anios[i];
                cantidad = cantidad + 1;
            }
        }
        Console.WriteLine("Años bisiestos:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(bisiestos[i]);
        }
    }

    static void Ejercicio20()
    {
        Console.Write("Cantidad de productos: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] codigos = new string[n];
        double[] precios = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Codigo del producto " + (i + 1) + ": ");
            codigos[i] = Console.ReadLine();
            Console.Write("Precio del producto " + (i + 1) + ": ");
            precios[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (precios[j] > precios[j + 1])
                {
                    double auxPrecio = precios[j];
                    precios[j] = precios[j + 1];
                    precios[j + 1] = auxPrecio;

                    string auxCodigo = codigos[j];
                    codigos[j] = codigos[j + 1];
                    codigos[j + 1] = auxCodigo;
                }
            }
        }
        Console.WriteLine("Productos ordenados por precio:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(codigos[i] + " (" + (i + 1) + ") - " + precios[i]);
        }
        Console.WriteLine("Precios actualizados con aumento del 15%:");
        for (int i = 0; i < n; i++)
        {
            precios[i] = precios[i] + precios[i] * 0.15;
            Console.WriteLine(codigos[i] + " (" + (i + 1) + ") - " + precios[i]);
        }
    }
}

