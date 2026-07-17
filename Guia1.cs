using System;

class Program
{
    static void Main()
    {
        int opcion = -1;
        do
        {
            for (int i = 1; i <= 47; i++)
            {
                Console.WriteLine(i + ") Ejercicio " + i);
            }
            Console.WriteLine("0) Salir");
            Console.Write("Ingrese una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());




            if (opcion == 1) { Ej1(); }
            else if (opcion == 2) { Ej2(); }
            else if (opcion == 3) { Ej3(); }
            else if (opcion == 4) { Ej4(); }
            else if (opcion == 5) { Ej5(); }
            else if (opcion == 6) { Ej6(); }
            else if (opcion == 7) { Ej7(); }
            else if (opcion == 8) { Ej8(); }
            else if (opcion == 9) { Ej9(); }
            else if (opcion == 10) { Ej10(); }
            else if (opcion == 11) { Ej11(); }
            else if (opcion == 12) { Ej12(); }
            else if (opcion == 13) { Ej13(); }
            else if (opcion == 14) { Ej14(); }
            else if (opcion == 15) { Ej15(); }
            else if (opcion == 16) { Ej16(); }
            else if (opcion == 17) { Ej17(); }
            else if (opcion == 18) { Ej18(); }
            else if (opcion == 19) { Ej19(); }
            else if (opcion == 20) { Ej20(); }
            else if (opcion == 21) { Ej21(); }
            else if (opcion == 22) { Ej22(); }
            else if (opcion == 23) { Ej23(); }
            else if (opcion == 24) { Ej24(); }
            else if (opcion == 25) { Ej25(); }
            else if (opcion == 26) { Ej26(); }
            else if (opcion == 27) { Ej27(); }
            else if (opcion == 28) { Ej28(); }
            else if (opcion == 29) { Ej29(); }
            else if (opcion == 30) { Ej30(); }
            else if (opcion == 31) { Ej31(); }
            else if (opcion == 32) { Ej32(); }
            else if (opcion == 33) { Ej33(); }
            else if (opcion == 34) { Ej34(); }
            else if (opcion == 35) { Ej35(); }
            else if (opcion == 36) { Ej36(); }
            else if (opcion == 37) { Ej37(); }
            else if (opcion == 38) { Ej38(); }
            else if (opcion == 39) { Ej39(); }
            else if (opcion == 40) { Ej40(); }
            else if (opcion == 41) { Ej41(); }
            else if (opcion == 42) { Ej42(); }
            else if (opcion == 43) { Ej43(); }
            else if (opcion == 44) { Ej44(); }
            else if (opcion == 45) { Ej45(); }
            else if (opcion == 46) { Ej46(); }
            else if (opcion == 47) { Ej47(); }
            else if (opcion == 0) { }
            else { Console.WriteLine("Opcion invalida"); }

            Console.WriteLine();
        } while (opcion != 0);
    }

    static void Ej1()
    {
        Console.Write("Ingrese el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(numero1);
        Console.WriteLine(numero2);
    }

    static void Ej2()
    {
        Console.Write("Ingrese lado a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese lado b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double perimetro = 2 * a + 2 * b;
        double area = a * b;
        Console.WriteLine("Perimetro: " + perimetro);
        Console.WriteLine("Area: " + area);
    }

    static void Ej3()
    {
        Console.Write("Ingrese cantidad de hombres postulados: ");
        int hombres = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese cantidad de mujeres postuladas: ");
        int mujeres = Convert.ToInt32(Console.ReadLine());
        int total = hombres + mujeres;
        double porcentajeHombres = hombres * 100.0 / total;
        double porcentajeMujeres = mujeres * 100.0 / total;
        Console.WriteLine("Porcentaje de hombres: " + porcentajeHombres + "%");
        Console.WriteLine("Porcentaje de mujeres: " + porcentajeMujeres + "%");
    }

    static void Ej4()
    {
        Console.Write("Ingrese la fuerza en N: ");
        double fuerza = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el area en m2: ");
        double area = Convert.ToDouble(Console.ReadLine());
        double presion = fuerza / area;
        Console.WriteLine("La presion es: " + presion);
    }

    static void Ej5()
    {
        double total = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ingrese resistencia " + i + ": ");
            double resistencia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Resistencia " + i + ": " + resistencia);
            total = total + resistencia;
        }
        Console.WriteLine("Resistencia total: " + total);
    }

    static void Ej6()
    {
        Console.Write("Ingrese un numero entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        double octavaParte = numero / 8.0;
        Console.WriteLine("La octava parte es: " + octavaParte);
    }

    static void Ej7()
    {
        Console.Write("Ingrese el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        if (numero1 > numero2)
        {
            Console.WriteLine("El mayor es: " + numero1);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("El mayor es: " + numero2);
        }
        else
        {
            Console.WriteLine("Los dos numeros son iguales");
        }
    }

    static void Ej8()
    {
        Console.Write("Ingrese cantidad de horas: ");
        double horas = Convert.ToDouble(Console.ReadLine());
        if (horas < 20)
        {
            horas = 20;
        }
        Console.Write("Ingrese la edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        double importeSinImpuestos = horas * 50;
        double descuento = 0;
        if (edad > 70)
        {
            descuento = 0.50;
        }
        else if (edad > 60)
        {
            descuento = 0.30;
        }
        else if (edad > 50)
        {
            descuento = 0.20;
        }
        importeSinImpuestos = importeSinImpuestos - importeSinImpuestos * descuento;
        double importeConImpuestos = importeSinImpuestos + importeSinImpuestos * 0.33;
        Console.WriteLine("Importe sin impuestos: " + importeSinImpuestos);
        Console.WriteLine("Importe con impuestos: " + importeConImpuestos);
    }

    static void Ej9()
    {
        Console.Write("Ingrese categoria (A, B o C): ");
        string categoria = Console.ReadLine();
        Console.Write("Ingrese horas trabajadas: ");
        double horas = Convert.ToDouble(Console.ReadLine());
        double valorHora = 0;
        if (categoria == "A")
        {
            valorHora = 200;
        }
        else if (categoria == "B")
        {
            valorHora = 180;
        }
        else if (categoria == "C")
        {
            valorHora = 150;
        }
        double sueldo = horas * valorHora;
        Console.WriteLine("El sueldo ganado es: " + sueldo);
    }

    static void Ej10()
    {
        Console.Write("Ingrese sueldo basico: ");
        double sueldoBasico = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese categoria (1, 2 u otro): ");
        int categoria = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese cantidad de hijos: ");
        int hijos = Convert.ToInt32(Console.ReadLine());
        double adicionalHijos = hijos * 300;
        if (hijos > 4)
        {
            adicionalHijos = adicionalHijos + 200;
        }
        double adicionalCategoria = 0;
        if (categoria == 1)
        {
            adicionalCategoria = sueldoBasico * 0.10;
        }
        else if (categoria == 2)
        {
            adicionalCategoria = sueldoBasico * 0.20;
        }
        double sueldoFinal = sueldoBasico + adicionalHijos + adicionalCategoria;
        Console.WriteLine("El sueldo final es: " + sueldoFinal);
    }

    static void Ej11()
    {
        Console.Write("Ingrese peso en Kg: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese altura en metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());
        double imc = peso / (altura * altura);
        if (imc < 20)
        {
            Console.WriteLine("Estado: Bajo peso");
        }
        else if (imc <= 25)
        {
            Console.WriteLine("Estado: Peso ideal");
        }
        else
        {
            Console.WriteLine("Estado: Excedido");
        }
    }

    static void Ej12()
    {
        Console.Write("Ingrese superficie del pais 1: ");
        double superficie1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese poblacion del pais 1: ");
        double poblacion1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese superficie del pais 2: ");
        double superficie2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese poblacion del pais 2: ");
        double poblacion2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese superficie del pais 3: ");
        double superficie3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese poblacion del pais 3: ");
        double poblacion3 = Convert.ToDouble(Console.ReadLine());
        double densidad1 = poblacion1 / superficie1;
        double densidad2 = poblacion2 / superficie2;
        double densidad3 = poblacion3 / superficie3;
        if (densidad1 >= densidad2 && densidad1 >= densidad3)
        {
            Console.WriteLine("El pais 1 es el mas densamente poblado");
        }
        else if (densidad2 >= densidad1 && densidad2 >= densidad3)
        {
            Console.WriteLine("El pais 2 es el mas densamente poblado");
        }
        else
        {
            Console.WriteLine("El pais 3 es el mas densamente poblado");
        }
    }

    static void Ej13()
    {
        Console.Write("Ingrese el primer valor: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo valor: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el tercer valor: ");
        int valor3 = Convert.ToInt32(Console.ReadLine());
        if (valor1 == valor2 && valor2 == valor3)
        {
            Console.WriteLine("Los tres valores son iguales");
        }
        else if (valor1 != valor2 && valor1 != valor3 && valor2 != valor3)
        {
            Console.WriteLine("Los tres valores son distintos");
        }
        else
        {
            Console.WriteLine("Dos valores son iguales y uno distinto");
        }
    }

    static void Ej14()
    {
        Console.Write("Ingrese horas: ");
        int horas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese minutos: ");
        int minutos = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese segundos: ");
        int segundos = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese unidad final (1=segundos, 2=minutos, 3=horas): ");
        int unidadFinal = Convert.ToInt32(Console.ReadLine());
        int totalSegundos = horas * 3600 + minutos * 60 + segundos;
        if (unidadFinal == 1)
        {
            Console.WriteLine("Total en segundos: " + totalSegundos);
        }
        else if (unidadFinal == 2)
        {
            double totalMinutos = totalSegundos / 60.0;
            Console.WriteLine("Total en minutos: " + totalMinutos);
        }
        else if (unidadFinal == 3)
        {
            double totalHoras = totalSegundos / 3600.0;
            Console.WriteLine("Total en horas: " + totalHoras);
        }
    }

    static void Ej15()
    {
        Console.Write("Ingrese el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el tercer numero: ");
        int numero3 = Convert.ToInt32(Console.ReadLine());
        if (numero1 < numero2 && numero2 < numero3)
        {
            Console.WriteLine("Los numeros fueron ingresados en forma ascendente");
        }
        else
        {
            Console.WriteLine("Los numeros no fueron ingresados en forma ascendente");
        }
    }

    static void Ej16()
    {
        for (int i = 0; i <= 9; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void Ej17()
    {
        double suma = 0;
        int mayor = 0;
        for (int i = 1; i <= 15; i++)
        {
            Console.Write("Ingrese numero " + i + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());
            suma = suma + numero;
            if (i == 1 || numero > mayor)
            {
                mayor = numero;
            }
        }
        double promedio = suma / 15;
        Console.WriteLine("El promedio es: " + promedio);
        Console.WriteLine("El mayor numero es: " + mayor);
    }

    static void Ej18()
    {
        Console.Write("Ingrese el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        if (numero1 < numero2)
        {
            for (int i = numero1 + 1; i < numero2; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = numero2 + 1; i < numero1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    static void Ej19()
    {
        Console.Write("Ingrese un numero entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("El factorial es: " + factorial);
    }

    static void Ej20()
    {
        Console.Write("Ingrese la base: ");
        int baseNumero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el exponente: ");
        int exponente = Convert.ToInt32(Console.ReadLine());
        long potencia = 1;
        for (int i = 1; i <= exponente; i++)
        {
            potencia = potencia * baseNumero;
        }
        Console.WriteLine("El resultado es: " + potencia);
    }

    static void Ej21()
    {
        double sumaGeneral = 0;
        for (int alumno = 1; alumno <= 30; alumno++)
        {
            double sumaAlumno = 0;
            for (int materia = 1; materia <= 10; materia++)
            {
                Console.Write("Ingrese nota de la materia " + materia + " del alumno " + alumno + ": ");
                double nota = Convert.ToDouble(Console.ReadLine());
                sumaAlumno = sumaAlumno + nota;
            }
            double promedioAlumno = sumaAlumno / 10;
            Console.WriteLine("Promedio del alumno " + alumno + ": " + promedioAlumno);
            sumaGeneral = sumaGeneral + promedioAlumno;
        }
        double promedioGeneral = sumaGeneral / 30;
        Console.WriteLine("Promedio general del curso: " + promedioGeneral);
    }

    static void Ej22()
    {
        double totalGeneral = 0;
        double mayorVentaDiaria = 0;
        int vendedorMayorVenta = 0;
        for (int vendedor = 1; vendedor <= 20; vendedor++)
        {
            double totalVendedor = 0;
            for (int dia = 1; dia <= 15; dia++)
            {
                Console.Write("Ingrese unidades vendidas por el vendedor " + vendedor + " el dia " + dia + ": ");
                double unidades = Convert.ToDouble(Console.ReadLine());
                totalVendedor = totalVendedor + unidades;
                if (unidades > mayorVentaDiaria)
                {
                    mayorVentaDiaria = unidades;
                    vendedorMayorVenta = vendedor;
                }
            }
            Console.WriteLine("Total vendido por el vendedor " + vendedor + ": " + totalVendedor);
            totalGeneral = totalGeneral + totalVendedor;
        }
        Console.WriteLine("Total general: " + totalGeneral);
        Console.WriteLine("El vendedor con mayor venta diaria es el vendedor " + vendedorMayorVenta + " con " + mayorVentaDiaria + " unidades");
    }

    static void Ej23()
    {
        int negativos = 0;
        int positivos = 0;
        int ceros = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese numero " + i + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 0)
            {
                negativos = negativos + 1;
            }
            else if (numero > 0)
            {
                positivos = positivos + 1;
            }
            else
            {
                ceros = ceros + 1;
            }
        }
        Console.WriteLine("Negativos: " + negativos);
        Console.WriteLine("Positivos: " + positivos);
        Console.WriteLine("Ceros: " + ceros);
    }

    static void Ej24()
    {
        int mayores = 0;
        int menores = 0;
        for (int i = 1; i <= 20; i++)
        {
            Console.Write("Ingrese sueldo de la persona " + i + ": ");
            double sueldo = Convert.ToDouble(Console.ReadLine());
            if (sueldo > 2000)
            {
                mayores = mayores + 1;
            }
            else if (sueldo < 2000)
            {
                menores = menores + 1;
            }
        }
        Console.WriteLine("Cantidad que gana mas de $2000: " + mayores);
        Console.WriteLine("Cantidad que gana menos de $2000: " + menores);
    }

    static void Ej25()
    {
        for (int i = 1; i <= 15; i++)
        {
            Console.Write("Ingrese nombre del alumno " + i + ": ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese nota del alumno " + i + ": ");
            double nota = Convert.ToDouble(Console.ReadLine());
            if (nota > 8)
            {
                Console.WriteLine(nombre);
            }
        }
    }

    static void Ej26()
    {
        Console.Write("Ingrese el dia: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el mes: ");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el año: ");
        int anio = Convert.ToInt32(Console.ReadLine());
        bool valida = true;
        if (mes < 1 || mes > 12)
        {
            valida = false;
        }
        else if (dia < 1 || dia > 31)
        {
            valida = false;
        }
        else if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30)
        {
            valida = false;
        }
        else if (mes == 2)
        {
            bool bisiesto = false;
            if (anio % 4 == 0 && anio % 100 != 0)
            {
                bisiesto = true;
            }
            else if (anio % 400 == 0)
            {
                bisiesto = true;
            }
            if (bisiesto == true && dia > 29)
            {
                valida = false;
            }
            else if (bisiesto == false && dia > 28)
            {
                valida = false;
            }
        }
        if (valida == true)
        {
            Console.WriteLine("La fecha es valida");
        }
        else
        {
            Console.WriteLine("La fecha no es valida");
        }
    }

    static void Ej27()
    {
        double[] importePorProducto = new double[1001];
        int[] cantidadPorProducto = new int[1001];
        int numeroProducto = 0;
        do
        {
            Console.Write("Ingrese numero de factura: ");
            int numeroFactura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese precio unitario: ");
            double precioUnitario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese numero de producto (999 para finalizar): ");
            numeroProducto = Convert.ToInt32(Console.ReadLine());
            if (numeroProducto != 999)
            {
                cantidadPorProducto[numeroProducto] = cantidadPorProducto[numeroProducto] + cantidad;
                importePorProducto[numeroProducto] = importePorProducto[numeroProducto] + cantidad * precioUnitario;
            }
        } while (numeroProducto != 999);

        int productoMasVendido = 0;
        int mayorCantidad = 0;
        double mayorImporte = 0;
        int productoMayorImporte = 0;
        for (int i = 0; i <= 1000; i++)
        {
            if (cantidadPorProducto[i] > mayorCantidad)
            {
                mayorCantidad = cantidadPorProducto[i];
                productoMasVendido = i;
            }
            if (importePorProducto[i] > mayorImporte)
            {
                mayorImporte = importePorProducto[i];
                productoMayorImporte = i;
            }
        }
        Console.WriteLine("Producto mas vendido: " + productoMasVendido);
        Console.WriteLine("Producto con mayor importe vendido: " + productoMayorImporte + " con $" + mayorImporte);
    }

    static void Ej28()
    {
        double sumaPromedios = 0;
        double mejorPromedio = 0;
        int alumnoMejorPromedio = 0;
        int alumnosConDosOMenosNotas = 0;
        int alumnosConTPAprobado = 0;

        for (int alumno = 1; alumno <= 50; alumno++)
        {
            Console.Write("Ingrese nota de TP del alumno " + alumno + ": ");
            double notaTP = Convert.ToDouble(Console.ReadLine());
            double sumaNotas = notaTP;
            int cantidadNotas = 1;
            double nota = 0;
            do
            {
                Console.Write("Ingrese nota de actividad del alumno " + alumno + " (negativo para finalizar): ");
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota >= 0)
                {
                    sumaNotas = sumaNotas + nota;
                    cantidadNotas = cantidadNotas + 1;
                }
            } while (nota >= 0);

            double promedioAlumno = sumaNotas / cantidadNotas;
            Console.WriteLine("Promedio del alumno " + alumno + ": " + promedioAlumno);
            sumaPromedios = sumaPromedios + promedioAlumno;

            if (promedioAlumno > mejorPromedio)
            {
                mejorPromedio = promedioAlumno;
                alumnoMejorPromedio = alumno;
            }
            if (cantidadNotas <= 2)
            {
                alumnosConDosOMenosNotas = alumnosConDosOMenosNotas + 1;
            }
            if (notaTP >= 6)
            {
                alumnosConTPAprobado = alumnosConTPAprobado + 1;
            }
        }
        double promedioCurso = sumaPromedios / 50;
        Console.WriteLine("Alumno con mayor promedio: " + alumnoMejorPromedio);
        Console.WriteLine("Promedio general del curso: " + promedioCurso);
        Console.WriteLine("Alumnos con 2 o menos notas ingresadas: " + alumnosConDosOMenosNotas);
        Console.WriteLine("Alumnos con TP aprobado: " + alumnosConTPAprobado);
    }

    static void Ej29()
    {
        int hombres = 0;
        int mujeres = 0;
        int total = 0;
        int menores = 0;
        int dniMenor30M = 0;
        int dni = 0;
        do
        {
            Console.Write("Ingrese DNI (negativo para finalizar): ");
            dni = Convert.ToInt32(Console.ReadLine());
            if (dni >= 0)
            {
                Console.Write("Ingrese sexo (M o F): ");
                string sexo = Console.ReadLine();
                Console.Write("Ingrese año de nacimiento: ");
                int anioNacimiento = Convert.ToInt32(Console.ReadLine());

                total = total + 1;
                if (sexo == "M")
                {
                    hombres = hombres + 1;
                }
                else if (sexo == "F")
                {
                    mujeres = mujeres + 1;
                }

                int edad = 2026 - anioNacimiento;
                if (edad < 18)
                {
                    menores = menores + 1;
                }
                if (dni < 30000000)
                {
                    dniMenor30M = dniMenor30M + 1;
                }
            }
        } while (dni >= 0);

        double porcentajeMenores = menores * 100.0 / total;
        Console.WriteLine("Cantidad de hombres: " + hombres);
        Console.WriteLine("Cantidad de mujeres: " + mujeres);
        Console.WriteLine("Porcentaje de menores de edad: " + porcentajeMenores + "%");
        Console.WriteLine("Cantidad de personas con DNI menor a 30 millones: " + dniMenor30M);
    }

    static void Ej30()
    {
        Console.Write("Ingrese un numero entero mayor o igual a 0: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("El factorial de " + numero + " es: " + factorial);
    }

    static void Ej31()
    {
        Console.Write("Ingrese un numero entero entre 1 y 10: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + numero * i);
        }
    }

    static void Ej32()
    {
        Console.Write("Ingrese el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int menor = numero1;
        int mayor = numero2;
        if (numero2 < numero1)
        {
            menor = numero2;
            mayor = numero1;
        }
        int suma = 0;
        for (int i = menor; i <= mayor; i++)
        {
            if (i % 5 == 0)
            {
                suma = suma + i;
            }
        }
        Console.WriteLine("La suma de los multiplos de 5 es: " + suma);
    }

    static void Ej33()
    {
        Console.Write("Ingrese el primer numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int producto = 0;
        for (int i = 1; i <= numero2; i++)
        {
            producto = producto + numero1;
        }
        Console.WriteLine("El producto es: " + producto);
    }

    static void Ej34()
    {
        Console.Write("Ingrese el numero a (dividendo): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el numero b (divisor): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int cociente = 0;
        int resto = a;
        while (resto >= b)
        {
            resto = resto - b;
            cociente = cociente + 1;
        }
        Console.WriteLine("El resultado de la division entera es: " + cociente);
    }

    static void Ej35()
    {
        Console.Write("Ingrese el numero a (dividendo): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el numero b (divisor): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int resto = a;
        while (resto >= b)
        {
            resto = resto - b;
        }
        Console.WriteLine("El resto es: " + resto);
    }

    static void Ej36()
    {
        Console.Write("Ingrese un año: ");
        int anio = Convert.ToInt32(Console.ReadLine());
        bool bisiesto = false;
        if (anio % 4 == 0 && anio % 100 != 0)
        {
            bisiesto = true;
        }
        else if (anio % 400 == 0)
        {
            bisiesto = true;
        }
        if (bisiesto == true)
        {
            Console.WriteLine("El año es bisiesto");
        }
        else
        {
            Console.WriteLine("El año no es bisiesto");
        }
    }

    static void Ej37()
    {
        Console.Write("Ingrese un numero de 4 digitos: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int digito1 = numero / 1000;
        int digito2 = (numero / 100) % 10;
        int digito3 = (numero / 10) % 10;
        int digito4 = numero % 10;
        if (digito1 == digito4 && digito2 == digito3)
        {
            Console.WriteLine("El numero es capicua");
        }
        else
        {
            Console.WriteLine("El numero no es capicua");
        }
    }

    static void Ej38()
    {
        Console.Write("Ingrese un numero de 6 digitos (ddmmaa): ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int dia = numero / 10000;
        int mes = (numero / 100) % 100;
        int anio = numero % 100;
        Console.WriteLine("Dia: " + dia);
        Console.WriteLine("Mes: " + mes);
        Console.WriteLine("Año: " + anio);
    }

    static void Ej39()
    {
        Console.Write("Ingrese un numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                suma = suma + i;
            }
        }
        if (suma == numero)
        {
            Console.WriteLine("El numero es perfecto");
        }
        else
        {
            Console.WriteLine("El numero no es perfecto");
        }
    }

    static void Ej40()
    {
        Console.Write("Ingrese P: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese Q: ");
        int q = Convert.ToInt32(Console.ReadLine());

        long factorialP = 1;
        for (int i = 1; i <= p; i++)
        {
            factorialP = factorialP * i;
        }
        long factorialQ = 1;
        for (int i = 1; i <= q; i++)
        {
            factorialQ = factorialQ * i;
        }
        long factorialPQ = 1;
        for (int i = 1; i <= p - q; i++)
        {
            factorialPQ = factorialPQ * i;
        }
        double resultado = factorialP / (double)(factorialPQ * factorialQ);
        Console.WriteLine("El resultado es: " + resultado);
    }

    static void Ej41()
    {
        Console.Write("Ingrese cuantos numeros de la secuencia quiere mostrar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        long anterior = 0;
        long actual = 1;
        for (int i = 1; i <= cantidad; i++)
        {
            Console.WriteLine(actual);
            long siguiente = anterior + actual;
            anterior = actual;
            actual = siguiente;
        }
    }

    static void Ej42()
    {
        Console.Write("Ingrese la cantidad de pisos: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int fila = 1; fila <= n; fila++)
        {
            for (int espacio = 1; espacio <= n - fila; espacio++)
            {
                Console.Write(" ");
            }
            for (int asterisco = 1; asterisco <= 2 * fila - 1; asterisco++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Ej43()
    {
        Console.Write("Ingrese el dia: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el mes: ");
        int mes = Convert.ToInt32(Console.ReadLine());
        string signo = "";
        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
            signo = "Aries";
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
            signo = "Tauro";
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
            signo = "Geminis";
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
            signo = "Cancer";
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
            signo = "Leo";
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
            signo = "Virgo";
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
            signo = "Libra";
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
            signo = "Escorpio";
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
            signo = "Sagitario";
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
            signo = "Capricornio";
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
            signo = "Acuario";
        }
        else
        {
            signo = "Piscis";
        }
        Console.WriteLine("El signo del horoscopo es: " + signo);
    }

    static void Ej44()
    {
        Console.Write("Ingrese el precio: ");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el efectivo dado: ");
        double efectivo = Convert.ToDouble(Console.ReadLine());
        double vuelto = efectivo - precio;
        Console.WriteLine("El vuelto es: " + vuelto);
    }

    static void Ej45()
    {
        Console.Write("Ingrese la cantidad de numeros a ingresar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        int primero = 0;
        int anterior = 0;
        int ultimo = 0;
        bool ascendente = true;
        bool descendente = true;

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Ingrese numero " + i + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                primero = numero;
            }
            else
            {
                if (numero < anterior)
                {
                    ascendente = false;
                }
                if (numero > anterior)
                {
                    descendente = false;
                }
            }
            anterior = numero;
            ultimo = numero;
        }

        if (ascendente == true)
        {
            Console.WriteLine("Los numeros fueron ingresados de forma ascendente");
        }
        else if (descendente == true)
        {
            Console.WriteLine("Los numeros fueron ingresados de forma descendente");
        }
        else
        {
            Console.WriteLine("Los numeros fueron ingresados de forma desordenada");
        }
        Console.WriteLine("La suma entre el primero y el ultimo es: " + (primero + ultimo));
    }

    static void Ej46()
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("1) Salir");
            Console.WriteLine("2) Fibonacci");
            Console.WriteLine("3) Factorial");
            Console.Write("Ingrese una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 2)
            {
                Console.Write("Ingrese cuantos numeros de fibonacci quiere mostrar: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                long anterior = 0;
                long actual = 1;
                for (int i = 1; i <= cantidad; i++)
                {
                    Console.WriteLine(actual);
                    long siguiente = anterior + actual;
                    anterior = actual;
                    actual = siguiente;
                }
            }
            else if (opcion == 3)
            {
                Console.Write("Ingrese un numero para calcular el factorial: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                long factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("El factorial es: " + factorial);
            }
        } while (opcion != 1);
    }

    static void Ej47()
    {
        Console.Write("Ingrese la cantidad de personas encuestadas: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        int eligieronA = 0;
        int eligieronB = 0;
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write("Persona " + i + " - Ingrese 1 si eligio producto A, 0 si no: ");
            int productoA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Persona " + i + " - Ingrese 1 si eligio producto B, 0 si no: ");
            int productoB = Convert.ToInt32(Console.ReadLine());
            if (productoA == 1)
            {
                eligieronA = eligieronA + 1;
            }
            if (productoB == 1)
            {
                eligieronB = eligieronB + 1;
            }
        }
        double porcentajeA = eligieronA * 100.0 / cantidad;
        double porcentajeB = eligieronB * 100.0 / cantidad;
        Console.WriteLine("Total de personas encuestadas: " + cantidad);
        Console.WriteLine("Porcentaje que eligio A: " + porcentajeA + "%");
        Console.WriteLine("Porcentaje que eligio B: " + porcentajeB + "%");
    }
}

