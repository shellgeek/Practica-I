/*Escriba un programa que defina tres variables para guardar tres notas de un estudiante (n1, n2,
n3, por ejemplo), almacene en una cuarta variable el promedio de esas notas y finalmente
muestre el resultado en pantalla.
AUTOR: RAINIER L. DE JESUS LOPEZ */

using System;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
           int nota1,nota2, nota3, prom;
            Console.WriteLine("***** CALCULO PROMEDIO DE NOTAS *****");
            Console.Write("Ingrese la Primera Nota...:");
            nota1 =Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese la Segunda Nota...:");
            nota2 =Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese la Tercera Nota...:");
            nota3 =Convert.ToInt16(Console.ReadLine());
            prom = (nota1+nota2+nota3) / 3;
            Console.WriteLine("El promedio de las notas es...:{0}", prom);
        }
    }
}
