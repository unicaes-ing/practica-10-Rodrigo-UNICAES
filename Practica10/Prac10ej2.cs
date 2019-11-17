using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practica10
{
    class Prac10ej2
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[10];
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del pais #{0}: ", i + 1);
                nombre[i] = Console.ReadLine();
            }
            string letras = string.Join(",", nombre);
            StreamWriter sinM = new StreamWriter(@"paisesUni.txt", true);
            sinM.Write(letras);
            sinM.Close();
            StreamReader archivo = new StreamReader(@"paisesUni.txt");
            Console.WriteLine();
            Console.WriteLine("Paises: ");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(archivo.ReadToEnd());
            archivo.Close();
            Console.ReadKey();
        }
    }
}
