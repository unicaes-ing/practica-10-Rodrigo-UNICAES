using System;
using System.IO;

namespace Practica10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter menu = new StreamWriter(@"paises.txt", true);
                menu.Write("paises: ");
                Console.WriteLine("Menu:");
                Console.WriteLine("[1]Agregar paises");
                Console.WriteLine("[2]Mostrar paises");
                Console.WriteLine("[3]Buscar pais");
                Console.WriteLine("[4]Salir");
                Console.WriteLine("Ingrese una opción: ");
                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Cuantos paises desea agregar: ");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("Ingrese el nombre del pais: ");
                            string nombre = Console.ReadLine();
                            menu.WriteLine(nombre);
                            menu.Close();
                        }
                        break;
                    case 2:
                        StreamReader archi = new StreamReader(@"paises.txt");
                        string name;
                        name = archi.ReadToEnd();
                        Console.WriteLine(name);
                        archi.Close();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el nombre del pais que desea encontrar: ");
                        string pais = Console.ReadLine();
                        ConsoleColor color;
                        color = ConsoleColor.Yellow();
                        Console.WriteLine("Pais: {0}", pais);
                        break;
                    case 4:
                        Console.WriteLine("Hasta la proxima vez.... ");
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error al ejecutar el programa akjkjfhuivn ");
            }
        }
    }
}
