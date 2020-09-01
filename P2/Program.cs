/* Escriba un programa que usando dos números cuales quiera, muestre el resultado en pantalla
correspondiente a su suma, su resta y su multiplicación. 
AUTOR: RAINIER L. DE JESUS LOPEZ */

using System;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne, numTwo;
            Console.WriteLine("Ingrese una Cantidad...:");
            numOne= double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otra Cantidad...:");
            numTwo=double.Parse(Console.ReadLine());
            Console.WriteLine("----------OPERACIONES ARITMETICAS---------\n");
            Console.WriteLine("La suma de " + numOne + " + " + numTwo +" es {0}", numOne + numTwo) ;
            Console.WriteLine("La resta de " + numOne + " - " + numTwo +" es {0}", numOne - numTwo) ;
            Console.WriteLine("La multiplicación de " + numOne + " x " + numTwo +" es {0}", numOne * numTwo) ;
            Console.WriteLine("La divición de " + numOne + " / " + numTwo +" es {0}", numOne / numTwo) ;
        }
    }
}
