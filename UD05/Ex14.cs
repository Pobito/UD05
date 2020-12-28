using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex14
    {
        public static void ArrayRandomValor()
        {
            Random rnd = new Random(); // El objeto random

            int longitud, i, n;
            bool esta = false;

            Console.WriteLine("Di el tamaño del array");
            longitud = Int32.Parse(Console.ReadLine());
            int[] array = new int[longitud];

            for (i = 0; i < longitud; i++)
            {
                array[i] = rnd.Next(1, 11);
            }

            Console.WriteLine("Di un numero para ver si esta");
            n = Int32.Parse(Console.ReadLine());

            try // Si quito el try falla y no entiendo el porque, con el try funciona a la perfeccion
            {
                for (i = 0; i < longitud || esta; i++)
                {
                    if (n == array[i])
                    {
                        esta = true;
                    }
                }
            } catch (Exception) {}
            if (esta)
            {
                Console.WriteLine("Si que esta");
            }
            else
            {
                Console.WriteLine("No esta");
            }
        }
    }
}
