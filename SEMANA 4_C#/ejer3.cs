using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_4_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un monto en soles: ");
            double soles = double.Parse(Console.ReadLine());
            Console.WriteLine("\nseleccione una opcion: ");
            Console.WriteLine("1. dolares");
            Console.WriteLine("2. euros");
            int opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1: Console.Write($"USD: { (soles / 3.75): F2}"); break;
                case 2: Console.Write($"EUROS: {(soles / 4.05): F2}"); break;
                default: Console.Write("opcion incorrecta"); break;
            }
            Console.ReadKey();
        }
    }
}
