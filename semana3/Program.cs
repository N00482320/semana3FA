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
            ejer3();
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
            Console.Write("Ingrese núnmero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese núnmero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num2 / (double)num2;
            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicación: " + (num1 * num2));
            Console.WriteLine("División: " + divi);

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
