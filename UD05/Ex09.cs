using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex09
    {
        public static void ArrayEx09()
        {
            int i = 6, j;
            int[] array = new int[i];

            Console.WriteLine("El array tiene una longitud de " + i);

            // Para guardar los valores
            for (j = 0; j < i; j++)
            {
                Console.WriteLine("Introduce el numero " + (j + 1));
                array[j] = Int32.Parse(Console.ReadLine());
            }

            // Para mostrarlos por pantalla
            for (j = 0; j < i; j++)
            {
                Console.WriteLine(array[j]);
            }
        }
    }
}
