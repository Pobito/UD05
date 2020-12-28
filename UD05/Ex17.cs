using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex17
    {
        public static void DiezArrayTeclado()
        {
            int[] array = new int[10];
            PedirNums(array);
            MostrarNums(array);

        }
        public static void PedirNums(int[] array)
        {
            int i;

            Console.WriteLine("Escribe 10 numeros");
            for (i = 0; i < 10; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
        }
        public static void MostrarNums(int[] array)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("El valor del indice " + (i + 1) + " es " + array[i]);
            }
        }
    }
}
