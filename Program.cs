using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] 10 Primeros números primos");
                Console.WriteLine("[7] Convertir de F° a C°");
                Console.WriteLine("[8] Convertir de C° a F°");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Los 10 primeros números primos son...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el valor en F°");
                        int i = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El valor F° {0} transformado a C° es {1}", i, FtoC(i));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el valor en C°");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El valor C° {0} transformado a F° es {1}", j, CtoF(j));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }


        //Calcula a y b
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        static double Division(double a, double b)
        {
            return a / b;
        }

        //Raíz de un número
        static void Raiz()
        {
            for (int i=1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es {1}", i, Math.Sqrt(i));
            }
        }

        static void Primos()
        {

            int count = 0, num = 0, initial = 1, jump = 1;

            while (num < 10)
            {
                jump = 1;
                count = 0;
                while (jump <= initial)
                {
                    if (initial % jump == 0)
                        count++;
                    jump++;
                    
                }
                if (count == 2)
                {
                    Console.WriteLine(initial);
                    num++;
                }
                initial++;
            }

        }

        static double FtoC(double a)
        {
            a = (5*(a-32))/9;
            return a;
        }

        static double CtoF(double a)
        {
            a = ((9*a)/5)+32;
            return a;
        }

    }
}
