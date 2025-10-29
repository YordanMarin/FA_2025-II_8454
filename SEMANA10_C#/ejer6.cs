using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA10_C_
{
    internal class ejer6
    {
        static void Main(string[] args)
        {
            string[] nom = new string[5];
            int reg = 0;

            for(int i = 0; reg < nom.Length; i++)
            {
                Console.Write($"Ingrese producto {reg+1}: ");
                string pro = Console.ReadLine();
                bool buscar = false;

                for (int j = 0; j < reg; j++)
                {
                    if(nom[j] == pro)
                    {
                        Console.WriteLine("Producto existente.\n");
                        buscar = true;
                        break;
                    }
                }
                if(buscar == false)
                {
                    nom[reg] = pro;
                    reg++;
                }
            }

        }
    }
}
