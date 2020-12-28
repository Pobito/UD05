using System;
using System.Collections.Generic;
using System.Text;

namespace UD05
{
    class Ex19
    {
        public static void ArrayRandomMayor()
        {
            Console.WriteLine("Di el tamaño del array");
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            LlenarArray(array);
            Console.WriteLine("El numero mas grnade es: " + Mayor(array));
        }
        public static void LlenarArray(int[] array)
        {
            int num = 0, i = 0, numAux = 0;
            while (i < array.Length)
            {
                numAux = GenerarRandom(num); // Guardamos lo que nos retorna aqui y comprobamos
                if (numAux != 0) // Si nos retorna 0 no es primo por tanto no nos sirve y tenemos que buscar otro
                {
                    array[i] = numAux; // si es primo lo guardamos aqui y aumentamos i para continuar con el bucle
                    i++;
                }
            }

        }
        public static int GenerarRandom(int num)
        {
            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 101); // no especificaba numero maximo asi que pongo 100

            // Si es mas pequeño o igual a 1 no es primo, asi ya nos los quitamos de encima (si no es primo retorna 0)
            if (numero <= 1)
            {
                return 0;
            }
            int cont = 0;
            // Un bucle para ir dividiendo entre todos los numeros hasta el propio numero
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0) // Si es primo entra aqui dentro y a contador se le suma 1
                {
                    cont++;
                }
            }

            if (cont > 2) // Si es mas grande de 2 no es primo ya que solo hay 2 divisores (1 y él mimso)
            {
                return 0; // (si no es primo retorna 0)
            }
            else
            {
                return numero;
            }

        }
        
        public static int Mayor(int[] array)
        {
            int mayor = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mayor)
                {
                    mayor = array[i];
                }
            }
            return mayor;
        }
    }
}
