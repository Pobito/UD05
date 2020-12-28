using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex11
    {
        public static void ArraySuma()
        {
            int[] array = { 1, 4, 8, 9, 4, 3, 4, 7, 8, 1 };
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            Console.WriteLine("La suma es: " + suma);
        }
    }
}
