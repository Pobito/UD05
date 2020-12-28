using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex18
    {
        public static void ArrayRandomSuma()
        {
            Console.WriteLine("Di el tamaño del array");
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            LlenarArray(array);
            MostrarArray(array);
        }

        public static void LlenarArray(int[] array)
        {
            int num = 0;
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = GenerarRandom(num);
            }
           
        }
        private static int GenerarRandom(int num)
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }
        public static void MostrarArray (int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
                Console.WriteLine("En la posicion " + (i+1) + ": " + array[i]);
            }
            Console.WriteLine("La suma de todo es: " + suma);
        }
    }
}
