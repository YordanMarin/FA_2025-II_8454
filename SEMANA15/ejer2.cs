using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamano: ");
            int t = int.Parse(Console.ReadLine());

            int[,] matriz = new int[t, t];
            Random rnd = new Random();

            Console.WriteLine("\nMATRIZ ORIGINAL: ");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    matriz[i, j] = rnd.Next(40,51);
                    Console.Write(matriz[i,j]+"\t");
                }
                Console.WriteLine();
            }

            int[,] transpuesta = new int[t, t];
            Console.WriteLine("\nMATRIZ TRANSPUESTA: ");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    transpuesta[i, j] = matriz[j,i];
                    Console.Write(transpuesta[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
