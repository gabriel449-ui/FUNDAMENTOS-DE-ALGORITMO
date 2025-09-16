using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un año: ");
            int annio = int.Parse(Console.ReadLine());

            if (annio %4==0 && annio %100 != 0 || annio %400 == 0)
            {
                Console.WriteLine("año bisiesto");
            }
            else
            {
                Console.WriteLine("año no bisiesto");
            }

            if(annio % 2 == 0)
            {
                Console.WriteLine("año par");
            }
            else
            {
                Console.WriteLine("año impar");
            }
            Console.ReadKey();        
        }
    }
}
