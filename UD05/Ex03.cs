using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex03
    {
        public static void NumPrimos()
        {
            int num;

            Console.WriteLine("Dime un numero");
            num = Int32.Parse(Console.ReadLine());

            Console.WriteLine(comprobarPrimo(num));
        }
        public static bool comprobarPrimo(int num)
        {
            // Si es mas pequeño o igual a 1 no es primo, asi ya nos los quitamos de encima
            if (num <= 1)
            {
                return false;
            }

            int cont = 0;
            // Un bucle para ir dividiendo entre todos los numeros hasta el propio numero
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) // Si es primo entra aqui dentro y a contador se le suma 1
                {
                    cont++;
                }
            }

            if (cont > 2) // Si es mas grande de 2 no es primo ya que solo hay 2 divisores (1 y él mimso)
            {
                return false;
            }
            else // Sino solo tendra 2 divisores y por ende sera primo
            {
                return true;
            }
        }

    }
}
