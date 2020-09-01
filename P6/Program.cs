/* Escriba un programa que a partir del valor de millas almacenado en una variable, muestre en
pantalla la equivalencia en kilómetros.
AUTOR: RAINIER L. DE JESUS LOPEZ */

using System;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt=0;
            Console.WriteLine("***** Convertir de Millas a Kilometros ******");
            Console.WriteLine("1- Millas a Kilometros...:");
            Console.WriteLine("2- Kilometros a Millas...:");
            Console.Write("Seleccione una Opción (1/2)...:");
            opt=Convert.ToInt16(Console.ReadLine());
            if(opt==1)
            {
                double mi, km;
                Console.WriteLine("***** Convirtiendo Millas a Kilometros ***** ");
                Console.Write("Ingresa la Distancia en Millas (mi)...:");
                mi=Convert.ToDouble(Console.ReadLine());
                km = mi*1.609;
                Console.WriteLine(mi + " Millas equivale  a " + km + " Kilometros");
            }

            else
            {
                double mi, km;
                Console.WriteLine("***** Convirtiendo Kilometros a Millas ***** ");
                Console.Write("Ingresa la Distancia en Kilometros (Km)...:");
                km=Convert.ToDouble(Console.ReadLine());
                mi=km* 0.62137;
                Console.WriteLine(km + " Kilometros equivale  a " + mi + " Millas");
            }
        }
    }
}
