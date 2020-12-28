using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex10
    {
        public static void TablaMultiplicar()
        {
            int num, i;
            int[] tabla = new int[11]; // 11 porque tambien se guarda el valor 0

            Console.WriteLine("Di el numero de la tabla de multiplicar");
            num = Int32.Parse(Console.ReadLine());

            // Para guardar en el array toda la tabla
            for (i = 0; i < tabla.Length; i++)
            {
                tabla[i] = num * i;
            }

            Console.WriteLine(""); // Salto de linea para que no salga todo junto
            // Para mostrar el array con la tabla
            for (i = 0; i < tabla.Length; i++)
            {
                Console.WriteLine(tabla[i]);
            }
        }
    }
}
