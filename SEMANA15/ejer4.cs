using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            string conti;
            do
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE REGISTRO DE PRODUCTOS\n");
                Console.WriteLine("1.Registrar");
                Console.WriteLine("2.Mostrar");
                Console.WriteLine("3.Modificar");
                Console.WriteLine("4.Salir");

                Console.Write("Ingrese una opción: ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:return;
                        case 1:registrar(); break;
                        case 2:mostrar(); break;
                        case 3:modificar(); break;
                }
                Console.Write("\nPara regresar al menú (si): ");
                conti = Console.ReadLine();
            } while (conti =="si");
        }

        static string[,] productos = new string[0, 3];
        static int cant = 0;

        static void redimensionar(int nuevoT)
        {
            string[,] nuevo = new string[nuevoT, 3];
            for(int i = 0; i < cant; i++)
            {
                for(int j = 0; j < productos.GetLength(1); j++)
                {
                    nuevo[i,j] = productos[i, j];
                }
            }
            productos = nuevo;
        }
        static void registrar()
        {
            redimensionar(cant+1);
            Console.Write("\nIngrese nombre: ");
            productos[cant, 0] = Console.ReadLine();
            Console.Write("Ingrese stock: ");
            productos[cant, 1] = Console.ReadLine();
            Console.Write("Ingrese precio: ");
            productos[cant, 2] = Console.ReadLine();
            cant++;
            Console.WriteLine("\nProducto registrado.");
        }

        static void mostrar()
        {
            for(int i = 0;i < cant; i++)
            {
                Console.WriteLine("\nProducto N° " + (i + 1));
                Console.WriteLine("Nombre: "+productos[i,0]);
                Console.WriteLine("Stock: " + productos[i, 1]);
                Console.WriteLine("Precio: " + productos[i, 2]);
            }
        }

        static void modificar()
        {
            Console.Write("\nIngrese el número de producto: ");
            int indice = int.Parse(Console.ReadLine())-1;

            if (indice >= 0 && indice < cant)
            {
                Console.Write("\nNuevo nombre: ");
                productos[indice,0] = Console.ReadLine();
                Console.Write("Nuevo stock: ");
                productos[indice, 1] = Console.ReadLine();
                Console.Write("Nuevo precio: ");
                productos[indice, 2] = Console.ReadLine();
            }
            else Console.WriteLine("\nNo existe");
        }
    }
}
