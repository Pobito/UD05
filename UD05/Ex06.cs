using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex06
    {
        public static void NumCifras()
        {
            int num = 100;
            do
            {
                Console.WriteLine("Dime un numero");
                num = Int32.Parse(Console.ReadLine());
            } while (num < 0);

            Console.WriteLine("Cifras: " + calcularCifras(num));
        }
        public static int calcularCifras (int num)
        {
            int cont = 0, i;

            for (i = num; i > 0; i /= 10)
            {
                cont++;
            }
            return cont;
        }
    }
}
