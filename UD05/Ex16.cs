using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex16
    {
        public static void Capicua()
        {
            int[] array = { 1, 2, 3, 3, 2, 1 };
            int cont = 0;
            
            // Recorre el array de alante atras y de atras alante hasta que coinciden los indices
            for (int i = 0, j = array.Length - 1; j > i; i++, j--)
            {
                if (array[i] == array[j])
                {
                    cont++; // cuenta cuantos numeros son iguales en sus posiciones espejo
                }
            }

            if (cont == (array.Length / 2)) // Si hay la mitad de coincidencias es que es capicua
            {
                Console.WriteLine("Es capicua");
            }
            else
            {
                Console.WriteLine("No es capicua");
            }
        }
    }
}
