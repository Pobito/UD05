using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex15
    {
        public static void InvertirArray()
        {
            Random rnd = new Random(); // El objeto random

            int longitud, i, j;

            Console.WriteLine("Di el tamaño del array");
            longitud = Int32.Parse(Console.ReadLine());
            int[] array = new int[longitud];
            int[] arrayInvert = new int[longitud];

            // Primer array (con numeros random porque no sabia que numeros poner hehe)
            for (i = 0; i < longitud; i++)
            {
                array[i] = rnd.Next(1, 11);
            }

            //Segundo array invertido
            for (i = 0, j = longitud - 1; i < longitud; i++, j--)
            {
                arrayInvert[i] = array[j];
            }

            Console.WriteLine("Primer array");
            for (i = 0; i < longitud; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Segundo array invertido");
            for (i = 0; i < longitud; i++)
            {
                Console.WriteLine(arrayInvert[i]);
            }
        }
    }
}
