using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex07
    {
        public static void ConvertirMonedas()
        {
            String eleccion;
            double valor;

            Console.WriteLine("Di la moneda a la cual quieres convertir:\nDolar\nYen\nLibra");
            eleccion = Console.ReadLine().ToLower();
            Console.WriteLine("Di la cantidad que quieres canvertir");
            valor = Double.Parse(Console.ReadLine());
            cambiar(valor, eleccion);
        }

        public static void cambiar (double valor, String eleccion)
        {
            double cambio = 0.0;
            bool error = true; // Para controlar algun error al introducir la moneda

            switch (eleccion)
            {
                case ("dolar"):
                    cambio = valor * 1.28611;
                    break;
                case ("yen"):
                    cambio = valor * 129.852;
                    break;
                case ("libra"):
                    cambio = valor * 0.86;
                    break;
                default:
                    Console.WriteLine("Error, valor introducido erroneo");
                    error = false;
                    break;
            }

            if (error)
            {
                Console.WriteLine(cambio);
            }
        }
    }
}
