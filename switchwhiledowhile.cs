namespace Whiles1
{
    internal class System;

    namespace ConsoleApp1
        {
            internal class Program
            {
                static void Main(string[] args)
                {
                    int opcion;
                    do
                    {
                        
                        Console.WriteLine("guia ");
                        Console.WriteLine("==============");
                        Console.WriteLine("switch");
                        Console.WriteLine("1 - Dias de la semana");
                        Console.WriteLine("2 - Meses del año");
                        Console.WriteLine("3 - Calculadora basica");
                        Console.WriteLine("4 - Conversor de unidades");
                        Console.WriteLine("5 - Cajero automatico");
                        Console.WriteLine("while");
                        Console.WriteLine("6 - Contar del 1 al 10");
                        Console.WriteLine("7 - Contar del 10 al 1");
                        Console.WriteLine("8 - Suma de N numeros");
                        Console.WriteLine("9 - Promedio de notas");
                        Console.WriteLine("10 - Menu repetitivo");
                        Console.WriteLine("do-while");
                        Console.WriteLine("11 - Contar 1 al 10 (do-while)");
                        Console.WriteLine("12 - Ingreso de nombres");
                        Console.WriteLine("13 - Suma de numeros");
                        Console.WriteLine("14 - Calculadora con menu");
                        Console.WriteLine("15 - Registro de alumnos");
                        Console.WriteLine("0 - Salir");

                        bool key = int.TryParse(Console.ReadLine(), out opcion);
                        
                        if(key == true)
                        { 
                            switch(opcion)
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
                            }
                        }
                        
                        
                        

                    } while (opcion != 0);
                }

               
                static void Ej1()
                {
                    Console.Clear();
                    int num;

                    Console.WriteLine("Ingrese un numero del 1 al 7:");
                    num = Convert.ToInt16(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Lunes");
                            break;
                        case 2:
                            Console.WriteLine("Martes");
                            break;
                        case 3:
                            Console.WriteLine("Miercoles");
                            break;
                        case 4:
                            Console.WriteLine("Jueves");
                            break;
                        case 5:
                            Console.WriteLine("Viernes");
                            break;
                        case 6:
                            Console.WriteLine("Sabado");
                            break;
                        case 7:
                            Console.WriteLine("Domingo");
                            break;
                        default:
                            Console.WriteLine("Dia invalido");
                            break;
                    }
                }

                
                static void Ej2()
                {
                    Console.Clear();
                    int num;

                    Console.WriteLine("Ingrese un numero del 1 al 12:");
                    num = Convert.ToInt16(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Enero");
                            break;
                        case 2:
                            Console.WriteLine("Febrero");
                            break;
                        case 3:
                            Console.WriteLine("Marzo");
                            break;
                        case 4:
                            Console.WriteLine("Abril");
                            break;
                        case 5:
                            Console.WriteLine("Mayo");
                            break;
                        case 6:
                            Console.WriteLine("Junio");
                            break;
                        case 7:
                            Console.WriteLine("Julio");
                            break;
                        case 8:
                            Console.WriteLine("Agosto");
                            break;
                        case 9:
                            Console.WriteLine("Septiembre");
                            break;
                        case 10:
                            Console.WriteLine("Octubre");
                            break;
                        case 11:
                            Console.WriteLine("Noviembre");
                            break;
                        case 12:
                            Console.WriteLine("Diciembre");
                            break;
                        default:
                            Console.WriteLine("Mes invalido");
                            break;
                    }
                }

             
                static void Ej3()
                {
                    Console.Clear();
                    double num1, num2;
                    int op;

                    Console.WriteLine("Ingrese el primer numero:");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero:");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("1 - Sumar");
                    Console.WriteLine("2 - Restar");
                    Console.WriteLine("3 - Multiplicar");
                    Console.WriteLine("4 - Dividir");
                    Console.WriteLine("Ingrese la opcion:");
                    op = Convert.ToInt16(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine($"Resultado: {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"Resultado: {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"Resultado: {num1 * num2}");
                            break;
                        case 4:
                            if (num2 != 0)
                                Console.WriteLine($"Resultado: {num1 / num2}");
                            else
                                Console.WriteLine("No se puede dividir entre cero");
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            break;
                    }
                }

              
                static void Ej4()
                {
                    Console.Clear();
                    double metros;
                    int op;

                    Console.WriteLine("Ingrese los metros:");
                    metros = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("1 - Centimetros");
                    Console.WriteLine("2 - Milimetros");
                    Console.WriteLine("3 - Kilometros");
                    Console.WriteLine("4 - Pulgadas");
                    Console.WriteLine("Ingrese la opcion:");
                    op = Convert.ToInt16(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine($"Resultado: {metros * 100} centimetros");
                            break;
                        case 2:
                            Console.WriteLine($"Resultado: {metros * 1000} milimetros");
                            break;
                        case 3:
                            Console.WriteLine($"Resultado: {metros / 1000} kilometros");
                            break;
                        case 4:
                            Console.WriteLine($"Resultado: {metros * 39.37} pulgadas");
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            break;
                    }
                }

                static void Ej5()
                {
                    Console.Clear();
                    double saldo = 100000;
                    int op;
                    double monto;
                    bool salir = false;

                    while (!salir)
                    {
                        Console.WriteLine("===== CAJERO =====");
                        Console.WriteLine("1 - Consultar saldo");
                        Console.WriteLine("2 - Depositar");
                        Console.WriteLine("3 - Extraer");
                        Console.WriteLine("4 - Salir");
                        Console.WriteLine("Ingrese la opcion:");
                        op = Convert.ToInt16(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                Console.WriteLine($"Saldo disponible: ${saldo}");
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el monto a depositar:");
                                monto = Convert.ToDouble(Console.ReadLine());
                                saldo += monto;
                                Console.WriteLine($"Deposito realizado. Saldo disponible: ${saldo}");
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el monto a retirar:");
                                monto = Convert.ToDouble(Console.ReadLine());
                                if (monto <= saldo)
                                {
                                    saldo -= monto;
                                    Console.WriteLine($"Extraccion realizada. Saldo disponible: ${saldo}");
                                }
                                else
                                    Console.WriteLine("Saldo insuficiente");
                                break;
                            case 4:
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Opcion incorrecta");
                                break;
                        }
                    }
                }

               
                static void Ej6()
                {
                    Console.Clear();
                    int num = 1;

                    while (num <= 10)
                    {
                        Console.WriteLine(num);
                        num++;
                    }
                }

              
                static void Ej7()
                {
                    Console.Clear();
                    int num = 10;

                    while (num >= 1)
                    {
                        Console.WriteLine(num);
                        num--;
                    }
                }

               
                static void Ej8()
                {
                    Console.Clear();
                    int n;
                    int i = 1;
                    int suma = 0;

                    Console.WriteLine("Ingrese un numero entero positivo:");
                    n = Convert.ToInt16(Console.ReadLine());

                    while (i <= n)
                    {
                        suma += i;
                        i++;
                    }

                    Console.WriteLine($"La suma es: {suma}");
                }

             
                static void Ej9()
                {
                    Console.Clear();
                    int cant;
                    int i = 1;
                    double suma = 0;
                    double nota;

                    Console.WriteLine("Ingrese la cantidad de alumnos:");
                    cant = Convert.ToInt16(Console.ReadLine());

                    while (i <= cant)
                    {
                        Console.WriteLine($"Nota {i}:");
                        nota = Convert.ToDouble(Console.ReadLine());
                        suma += nota;
                        i++;
                    }

                    Console.WriteLine($"Suma: {suma}");
                    Console.WriteLine($"Promedio: {suma / cant}");
                }

                static void Ej10()
                {
                    Console.Clear();
                    int op = -1;

                    while (op != 0)
                    {
                        Console.WriteLine("===== MENU =====");
                        Console.WriteLine("1 - Saludar");
                        Console.WriteLine("2 - Mostrar la fecha");
                        Console.WriteLine("3 - Mostrar un mensaje");
                        Console.WriteLine("0 - Salir");
                        Console.WriteLine("Ingrese la opcion:");
                        op = Convert.ToInt16(Console.ReadLine());

                        if (op == 1)
                            Console.WriteLine("Hola!");
                        if (op == 2)
                            Console.WriteLine($"Fecha actual: {DateTime.Now}");
                        if (op == 3)
                            Console.WriteLine("Bienvenido al programa");
                        if (op != 0 && op != 1 && op != 2 && op != 3)
                            Console.WriteLine("Opcion invalida");
                    }
                }

                static void Ej11()
                {
                    Console.Clear();
                    int num = 1;

                    do
                    {
                        Console.WriteLine(num);
                        num++;
                    } while (num <= 10);
                }

              
                static void Ej12()
                {
                    Console.Clear();
                    char resp;
                    string nom;

                    do
                    {
                        Console.WriteLine("Ingrese un nombre:");
                        nom = Console.ReadLine();
                        Console.WriteLine("Desea ingresar otro nombre (S/N):");
                        resp = Convert.ToChar(Console.ReadLine());
                    } while (resp == 'S' || resp == 's');

                    Console.WriteLine("Carga finalizada");
                }

                static void Ej13()
                {
                    Console.Clear();
                    char resp;
                    double num;
                    double suma = 0;
                    int cant = 0;

                    do
                    {
                        Console.WriteLine("Ingrese un numero:");
                        num = Convert.ToDouble(Console.ReadLine());
                        suma += num;
                        cant++;

                        Console.WriteLine("Desea continuar (S/N):");
                        resp = Convert.ToChar(Console.ReadLine());
                    } while (resp == 'S' || resp == 's');

                    Console.WriteLine($"Cantidad de numeros: {cant}");
                    Console.WriteLine($"Suma total: {suma}");
                }

          
                static void Ej14()
                {
                    Console.Clear();
                    int op;
                    double num1, num2;
                    bool salir = false;

                    do
                    {
                        Console.WriteLine("===== CALCULADORA =====");
                        Console.WriteLine("1 - Sumar");
                        Console.WriteLine("2 - Restar");
                        Console.WriteLine("3 - Multiplicar");
                        Console.WriteLine("4 - Dividir");
                        Console.WriteLine("0 - Salir");
                        Console.WriteLine("Ingrese la opcion:");
                        op = Convert.ToInt16(Console.ReadLine());

                        if (op == 0)
                        {
                            salir = true;
                        }
                        if (op == 1)
                        {
                            Console.WriteLine("Ingrese el primer numero:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero:");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {num1 + num2}");
                        }
                        if (op == 2)
                        {
                            Console.WriteLine("Ingrese el primer numero:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero:");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {num1 - num2}");
                        }
                        if (op == 3)
                        {
                            Console.WriteLine("Ingrese el primer numero:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero:");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Resultado: {num1 * num2}");
                        }
                        if (op == 4)
                        {
                            Console.WriteLine("Ingrese el primer numero:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero:");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            if (num2 != 0)
                                Console.WriteLine($"Resultado: {num1 / num2}");
                            else
                                Console.WriteLine("No se puede dividir entre cero");
                        }
                        if (op != 0 && op != 1 && op != 2 && op != 3 && op != 4)
                            Console.WriteLine("Opcion invalida");

                    } while (!salir);
                }

           
                static void Ej15()
                {
                    Console.Clear();
                    char resp;
                    string nom;
                    int edad;
                    double nota;
                    double suma = 0;
                    int cant = 0;
                    double notaMayor = -1;
                    double notaMenor = 11;

                    do
                    {
                        Console.WriteLine("Nombre:");
                        nom = Console.ReadLine();
                        Console.WriteLine("Edad:");
                        edad = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Nota:");
                        nota = Convert.ToDouble(Console.ReadLine());

                        suma += nota;
                        cant++;

                        if (nota > notaMayor)
                            notaMayor = nota;
                        if (nota < notaMenor)
                            notaMenor = nota;

                        Console.WriteLine("Desea ingresar otro alumno (S/N):");
                        resp = Convert.ToChar(Console.ReadLine());
                    } while (resp == 'S' || resp == 's');

                    Console.WriteLine($"Cantidad de alumnos: {cant}");
                    Console.WriteLine($"Promedio: {suma / cant}");
                    Console.WriteLine($"Nota mas alta: {notaMayor}");
                    Console.WriteLine($"Nota mas baja: {notaMenor}");
                }
            }
    }

}