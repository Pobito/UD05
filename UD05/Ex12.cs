using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex12
    {
        public static void ArrayMedia()
        {
            int[] array = { 1, 4, 8, 9, 4, 3, 4, 7, 8, 1 };
            double suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            Console.WriteLine("La media es: " + (double) (suma / array.Length));
        }
    }
}
