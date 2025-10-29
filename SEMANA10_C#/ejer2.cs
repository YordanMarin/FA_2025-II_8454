using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA10_C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };
            
            /*
            int[] num2 = new int[7];
            num2[0] = -2;
            num2[1] = 5;
            num2[2] = -1;
            num2[3] = 0;
            num2[4] = 8;
            num2[5] = -6;
            num2[6] = 3;
            */

            Console.Write("Lista original: ");
            foreach (int i in num)
                Console.Write(i + " ");

            for (int i = 0; i < num.Length; i++)
            {
                if(num[i]< 0)
                    num[i] = 0;
            }

            Console.Write("\nLista reemplazada: ");
            foreach(int i in num)
                Console.Write(i+" ");

            Console.ReadKey();
        }
    }
}
