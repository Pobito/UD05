using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex02
    {
        public static void NumRand()
        {
            int limite, num1, num2, i;

            Console.WriteLine("Introduce la cantidad de numeros que quieres");
            limite = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Di el numero de inicio");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Di el numero final");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(""); // para printar un salto de linea

            for (i = 0; i < limite; i++)
            {
                Console.WriteLine(generarRandom(num1, num2));
            }
        }
        public static int generarRandom(int num1, int num2)
        {
            Random rnd = new Random(); //Creamos el objeto random
            return rnd.Next(num1, num2 + 1);
        }
    }
}
