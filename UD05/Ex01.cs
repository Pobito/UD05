using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    public class Ex01
    {
        public static void calculoArea()
        {
            String eleccion;
            double resultado = 0;

            Console.WriteLine("Elige una opcion:\nCirculo\nTriangulo\nCuadrado");
            eleccion = Console.ReadLine().ToLower();

            switch (eleccion)
            {
                case "circulo":
                    Console.WriteLine("Introduce el radio");
                    int radio = Int32.Parse(Console.ReadLine());
                    resultado = areaC(radio);
                    break;
                case "triangulo":
                    Console.WriteLine("Introduce la base");
                    int ba = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce la altura");
                    int altura = Int32.Parse(Console.ReadLine());
                    resultado = areaT(ba, altura);
                    break;
                case "cuadrado":
                    Console.WriteLine("Introduce el lado");
                    int lado = Int32.Parse(Console.ReadLine());
                    resultado = areaCua(lado);
                    break;
                default:
                    Console.WriteLine("Valor erroneo");
                    break;
            }

            Console.WriteLine("El area del {0} es {1}", eleccion, resultado);
        }

        public static double areaC(int radio)
        {
            return Math.Pow(radio, 2) * Math.PI;
        }
        public static double areaT(int ba, int altura)
        {
            return ba * altura / 2;
        }
        public static double areaCua(int lado)
        {
            return lado * lado;
        }
    }
}
