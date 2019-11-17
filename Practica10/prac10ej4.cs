using System;
using System.Collections.Generic;
using System.Text;

namespace Practica10
{
    class prac10ej4
    {
        static void Main(string[] args)
        {
            string contra;

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("intentos: " + i);
                Console.Write("Ingrese la contraseña: ");
                contra = Console.ReadLine();
                string contraseña = "Aubamenyang1001";
                if (contra == contraseña)
                {
                    Console.WriteLine("Hola a todos");
                    i = 1;
                }
                else
                {
                    Console.WriteLine("Lo sentimos se le acabo ls intentos");
                }
                Console.ReadKey();
                Console.Clear();
            }
    }
}
