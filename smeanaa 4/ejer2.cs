using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smeanaa_4
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año: ");
            int annio = int.Parse(Console.ReadLine());

            if (annio % 4 == 0 && annio % 100 != 0 || annio % 400 == 0)
            {
                Console.WriteLine("Año bisiesto");
            }
            else
            {
                Console.WriteLine("Año no bisiestro");
            }
            if (annio % 2 == 0)
            {
                Console.WriteLine("Año par");
            }
            else
            {
                Console.WriteLine("Año impar");
            }
            Console.ReadKey();
        }
    }
}
