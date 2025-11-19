using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2;
            while (true)
            {
                Console.Write("Ingrese el primer nombre: ");
                nom1 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom1)) break;
                else Console.WriteLine("No se permiten vacios.\n");
            }
            while (true)
            {
                Console.Write("Ingrese el segundo nombre: ");
                nom2 = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(nom2)) break;
                else Console.WriteLine("No se permiten vacios.\n");
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Cantidad caracteres nombre1: " + nom1.Length);
            Console.WriteLine("Cantidad caracteres nombre2: " + nom2.Length);
            Console.WriteLine("Nombre 1 mayusculas: "+nom1.ToUpper());
            Console.WriteLine("nombre 2 minusculas: "+nom2.ToLower());
            if (nom1.CompareTo(nom2) == 0) Console.WriteLine("Nombres son iguales");
            else Console.WriteLine("Nombres son diferentes");
            if (nom1.Contains("an")) Console.WriteLine("Si existe 'an'");
            else Console.WriteLine("No existe 'an'");
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            if (nom1.IndexOf("a") != -1)
                Console.WriteLine("La primera pos de 'a' es " + nom1.IndexOf("a"));
            else Console.WriteLine("No existe 'a'");
            if (nom2.LastIndexOf("a") != -1)
                Console.WriteLine("La ultima pos de 'a' es " + nom2.LastIndexOf("a"));
            else Console.WriteLine("No existe 'a'");
            Console.WriteLine("Insertando upn al inicio: "+nom1.Insert(0,"UPN"));
            Console.WriteLine("Insertando sistemas al final: " + nom2.Insert(nom2.Length, "SISTEMAS"));
            Console.ResetColor(); //restauramos colores
            if (nom2.Length > 5)
                Console.WriteLine("Elimando desde 5ta pos: " + nom2.Remove(5));
            else Console.WriteLine("No hay almenos 5 caracteres");

            Console.BackgroundColor = ConsoleColor.Green;

            if (nom1.Contains("a"))
                Console.WriteLine("Reemplaanzo a por @: " + nom1.Replace("a", "@"));
            else Console.WriteLine("No existe 'a'");
            Console.ResetColor();

            if (nom1.Contains("a"))
            {
                Console.Write("Disión de palabaras: ");
                string[] partes = nom1.Split('a');
                for(int i = 0;i<partes.Length;i++)
                    Console.Write(partes[i]+" -> ");
            }
            else Console.WriteLine("No existe 'a'");

            if (nom2.Length > 4) Console.WriteLine("Sub cadena: " + nom2.Substring(4));
            else Console.WriteLine("No tiene almenos 4 caracteres");

            char[] nom = nom1.ToCharArray();
            for (int i = 0; i < nom.Length; i++)
                Console.WriteLine(nom[i]);

            for (int i = nom.Length-1; i >=0 ; i--)
                Console.Write(nom[i]);

            Array.Sort(nom);
            string ordenado = new string(nom);
            Console.WriteLine("\nOrdenado: "+ordenado);

            Console.ReadKey();
        }
    }
}
