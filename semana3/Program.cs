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
            ejer4();
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
            Console.Write("Ingrese un número decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(num);
            double redo = Math.Round(num, 2);
            double cubo = Math.Pow(num, 3);
            double cubica = Math.Pow(num, 1 / 3d);

            Console.WriteLine("Raiz cuadrada: " + raiz);
            Console.WriteLine("Redondeado: " + redo);
            Console.WriteLine("Elevado a 3: " + cubo);
            Console.WriteLine("Raiz cubica: " + cubica);
        }

        static void ejer5()
        {
            Console.Write("Ingrese un número: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("Resto: " + (entero % 2));
            Console.WriteLine("Decimal: " + (deci / 3));

        }

        static void ejer6()
        {

        }
    }
}
