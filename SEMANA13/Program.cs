using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "INSERTAR", "REGISTRAR", "MODIFICAR", "ELIMINAR", "ORDENAR", "SALIR" };
            int indice = 0;
            ConsoleKey tecla;
            string conti;
            do
            {
                do
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("************************************************************************************************");
                    Console.WriteLine("*                             BIENVENIDOS AL SISTEMA DE ESTUDIANTES                            *");
                    Console.WriteLine("************************************************************************************************");
                    Console.ResetColor();
                    Console.WriteLine();

                    for (int i = 0; i < menu.Length; i++)
                    {
                        if (indice == i)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("    " + menu[i] + "    ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write("    " + menu[i] + "    ");
                        }
                    }
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------");

                    ConsoleKeyInfo info = Console.ReadKey();
                    tecla = info.Key;

                    if (tecla == ConsoleKey.RightArrow)
                    {
                        indice++;
                        if (indice > menu.Length - 1)
                        {
                            indice = 0;
                        }
                    }
                    else if (tecla == ConsoleKey.LeftArrow)
                    {
                        indice--;
                        if (indice < 0)
                        {
                            indice = menu.Length - 1;
                        }
                    }
                } while (tecla != ConsoleKey.Enter);


                switch (indice)
                {
                    case 0: Console.WriteLine("hola"); break;
                    case 1: Console.WriteLine("hola1"); break;
                    case 2: Console.WriteLine("hola2"); break;
                    case 3: Console.WriteLine("hol3"); break;
                    case 4: Console.WriteLine("hol4"); break;
                    case 5: return;
                }

                while (true)
                {
                    Console.Write("\n¿Desea regresar al menú? (S/N)");
                    conti = Console.ReadLine().ToLower().Trim();
                    if (conti == "s" || conti == "n") break;
                    else Console.WriteLine("Opción invalida solo se permiten 's' o 'n'\n");
                }
            } while (conti == "s");
                    Console.ReadKey();
        }
    }
}
