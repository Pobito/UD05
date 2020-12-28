using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex05
    {
        public static void DecimalBinario()
        {
            int num;

            Console.WriteLine("Di un numero en decimal");
            num = Int32.Parse(Console.ReadLine());

            Console.WriteLine(conversorBinario(num));
        }

        public static String conversorBinario (int num)
        {
            String binarioFinal = "", binario;
            

            for (int i = num; i > 0; i /= 2)
            {
                if (i % 2 == 0)
                {
                    binario = "0";
                }
                else
                {
                    binario = "1";
                }
                binarioFinal = binario + binarioFinal;
            }

            return binarioFinal;
        }
    }
}
