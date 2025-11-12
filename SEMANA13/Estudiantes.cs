using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA13
{
    internal class Estudiantes
    {
        string[] nombres = new string[0];
        byte[] edades = new byte[0];
        int pos = 0;

        public int buscar(string nom)
        {
            for(int i = 0; i < nombres.Length; i++)
            {
                if(nom == nombres[i])  return i;
            }
            return -1;
        }

        public void modificar()
        {
            Console.Write("Ingrese el nombre a modicar: ");
            string nom = Console.ReadLine();

            int indice = buscar(nom);

            if (indice != -1)
            {
                Console.Write("Ingrese su nuevo nombre: ");
                nombres[indice] = Console.ReadLine();
                Console.Write("Ingrese su nueva edad ");
                edades[indice] = byte.Parse(Console.ReadLine());
            }
            else Console.WriteLine("No existe");
        }

        public void eliminar()
        {
            Console.Write("Ingrese el nombre a eliminar: ");
            string nom = Console.ReadLine();

            int indice = buscar(nom);

            if (indice != -1)
            {
                for(int i = indice;i < nombres.Length-1; i++)
                {
                    nombres[i] = nombres[i+1];
                    edades[i] = edades[i+1];
                }
                Array.Resize(ref edades, nombres.Length-1);
                Array.Resize(ref nombres, nombres.Length-1);
                pos--;
            }
            else Console.WriteLine("No existe");
        }
    }
}
