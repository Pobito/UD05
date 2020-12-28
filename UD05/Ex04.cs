using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex04
    {
        
        public static void Factorial()
        {
            int num, resu = 0;

            Console.WriteLine("Dime un numero");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(factor(num));
        }

        public static int factor (int num)
        {
            int res = num, i;
            for (i = num - 1; i>0; i--)
            {
                res *= i;
            }
            return res;
        }
    }
}
