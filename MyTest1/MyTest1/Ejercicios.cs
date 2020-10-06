using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo2
{
    class Ejercicios
    {
        //Ejercicio: hacer una función que imprima por pantalla los números del 0 al 99.
        public static void Ejercicio01()
        {
            int contador = 0;

            while (contador <= 99)
            {
                System.Console.WriteLine(contador);
                contador = contador + 1;

            }

        }

        // Ejercicio: haz una función que imprima por pantalla todos los números pares desde el 0 hasta n

        public static void Ejercicio02(int n)
        {
            int i = 0;
            while (1 < n)
            {
                if (Utils.IsEver(i))

                    System.Console.WriteLine(i);
                i++;
            }
        }
    }




}


