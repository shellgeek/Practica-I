/* Escriba un programa que almacene un valor en una variable numérica llamada dólar, muestre en
pantalla el monto equivalente en pesos.
Autor: RAINIER L. DE JESUS LOPEZ */

using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolares, tasa=58.58, pesos;
           Console.WriteLine(">>>>> CALCULO DOLARES (US$) A PESOS (RD$) <<<<<\n");
           Console.WriteLine("Ingrese una Cantidad en Dolares (US$)...:");
           dolares = Convert.ToDouble(Console.ReadLine());
           pesos = dolares*tasa;
           Console.WriteLine("-------------- DOLARES A PESOS ---------------\n");
           Console.WriteLine("Monto en Dolares --> {0}",dolares);
           Console.WriteLine("Tasa de Cambio --> {0}",tasa); 
           Console.WriteLine("Total en Pesos --> {0}", pesos);
        }
    }
}
