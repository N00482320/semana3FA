using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace semana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey(); //detenimeinto de consola
        }
        static void ejer1()
        {
            string nombre = "", carrera;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso" + $"de Fundamentos de Algoritmo {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Sebastian\"");
        }

        static void ejer3()
        {

        }

        static void ejer4()
        {

        }

        static void ejer5()
        {

        }

        static void ejer6()
        {

        }
    }
}
