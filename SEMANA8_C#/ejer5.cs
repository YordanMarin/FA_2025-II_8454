using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA8_C_
{
    internal class ejer5
    {
        static void Main(string[] args)
        {
            string conti;
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO AL SISTEMA DE CALCULADORA BÁSICA\n");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Mutiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");

                Console.Write("\nIngrese una opción: ");
                int opc = int.Parse(Console.ReadLine());

                Console.Write("\nIngrese el primer número: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                int b = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: suma(a,b); break;
                    case 2: resta(a, b); break;
                    case 3: multi(a, b); break;
                    case 4: divi(a, b); break;
                    case 5: Environment.Exit(0); break;
                    default: Console.WriteLine("\nOpción no válida."); break;
                }

                Console.Write("\n¿Desea continuar? presione (y): ");
                conti = Console.ReadLine();
            } while (conti == "y");
        }

        static void suma(int a, int b)
        {
            Console.WriteLine("\nLa suma es: " + (a + b));
        }
        static void resta(int a, int b)
        {
            Console.WriteLine("\nLa resta es: " + (a - b));
        }
        static void multi(int a, int b)
        {
            Console.WriteLine("\nLa multiplicación es: " + (a * b));
        }
        static void divi(int a, int b)
        {
            if (b != 0) Console.WriteLine("\nLa división es: " + (a / b));
            else Console.WriteLine("\nError. No se puede dividir entre 0");
        }
    }
}
