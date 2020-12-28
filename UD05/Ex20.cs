using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex20
    {
        public static void DosArrays()
        {
            Random rnd = new Random();

            int n, i;
            Console.WriteLine("Escribe el tamañno del array");
            n = Int32.Parse(Console.ReadLine());

            int[] primerArray = new int[n];
            int[] segundoArray;

            for (i = 0; i < n; i++)
            {
                primerArray[i] = rnd.Next(1, 101);
            }

            segundoArray = primerArray;
            primerArray = new int[n];

            for (i = 0; i < n; i++)
            {
                primerArray[i] = rnd.Next(1, 101);
            }

            int[] tercerArray = Multiplicacion(primerArray, segundoArray);

            Console.WriteLine("Primer Array");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(primerArray[i]);
            }

            Console.WriteLine("Segundo Array");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(segundoArray[i]);
            }

            Console.WriteLine("Tercer Array");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(tercerArray[i]);
            }
        }
        
        public static int[] Multiplicacion(int[] primerArray, int[] segundoArray)
        {
            int[] tercerArray = new int[primerArray.Length];
            for (int i = 0; i < primerArray.Length; i++)
            {
                tercerArray[i] = primerArray[i] * segundoArray[i];
            }
            return tercerArray;
        }

        
    }
}
