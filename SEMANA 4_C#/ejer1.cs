using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_C_
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            if(edad < 18)
            {
                Console.WriteLine("menor de edad");
            }
            else
            {
                if(edad <= 64)
                {
                    Console.WriteLine("adulto");

                }
                else
                {
                    Console.WriteLine("adulto mayor");

                }
            }
            Console.ReadKey();
        }
    }
}
