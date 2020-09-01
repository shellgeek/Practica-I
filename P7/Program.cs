/* Escriba un programa que calcule el área de un triangulo [f: (base x altura) / 2], cree las variables
necesarias.
AUTOR: RAINIER L. DE JESUS LOPEZ */

using System;

namespace P7
{
    class Program
    {
        static void Main(string[] args)
        {
            double  area, @base, altura; 
            Console.WriteLine("***** CALCULO DEL AREA DE UN TRIANGULO *****");
            Console.Write("Ingrese la Base...:");
            @base=Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la Altura...:");
            altura=Convert.ToDouble(Console.ReadLine());
            area= (@base*altura)/2;
            Console.WriteLine("El area de este triangulo es...:{0}",area);
            Console.ReadKey();
        }
    }
}
