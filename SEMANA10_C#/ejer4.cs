using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA10_C_
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nLista original: ");
            foreach (int i in num)
                Console.Write(i + " ");

            Console.Write("\n\nLista de pares: ");
            for (int i = 0;i < num.Length; i++)
            {
                if (num[i] %2 == 0)
                    Console.Write(num[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
