using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex13
    {
        public static void ArrayRandom()
        {
            Random rnd = new Random(); // El objeto random

            int longitud, i;

            Console.WriteLine("Di el tamaño del array");
            longitud = Int32.Parse(Console.ReadLine());
            int[] array = new int[longitud];

            for (i = 0; i < longitud; i++)
            {
                array[i] = rnd.Next(1, 11);
            }

            Console.WriteLine(""); // Linea para que no salga todo pegado

            for (i = 0; i < longitud; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
