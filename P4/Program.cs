/* Escriba un programa que muestre en pantalla el equivalente en Celsius de 90 grados F
AUTOR: RAINIER L. DE JESUS LOPEZ */

using System;

namespace P4
{
    class Program
    {
        
        static void Main(string[] args)
        {
           int opt=0;
            Console.WriteLine("***** Convertir [ºF] Fahrenheit a [ºC] Centígrados ******");
            Console.WriteLine("1- Grados [ºF] Fahrenheit a [ºC] Centígrados");
            Console.WriteLine("2- Grados [ºC] Centígrados a [ºF] Fahrenheit");
            Console.Write("Seleccione una Opción (1/2)...:");
            opt=Convert.ToInt16(Console.ReadLine());
            if(opt==1)
            {
                double gF=0, gC=0;
                Console.WriteLine("***** Convirtiendo [ºF] a [ºC] ***** ");
                Console.Write("Ingresa Grados Fahrenheit [ºF]...:");
                gF=Convert.ToDouble(Console.ReadLine());
                gC = (gF-32) * 5/9;
                Console.WriteLine(gF + "ºF equivale  a " + gC + "ºC");
            }

            else
            {
                double gF=0, gC=0;
                Console.WriteLine("***** Convirtiendo [ºC] a [ºF] ***** ");
                Console.Write("Ingresa Grados Centigrados [ºC]...:");
                gC=Convert.ToDouble(Console.ReadLine());
                gF=(gC*9/5)+(32);
                Console.WriteLine(gC + "ºC equivale  a " + gF + "ºF");
            }

        }
    }
}
