using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyTest1
{
    class SOY_IDIOTA
    {
        //(2.2.10.1) Crea un programa que pida al usuario dos números y escriba su máximo común divisor
        //(pista: una solución lenta pero sencilla es probar con un "for" todoS los números descendiendo a partir 
        //del menor de ambos, hasta llegar a 1; cuando encuentres un número que sea divisor de ambos, interrumpes la búsqueda).
        public static void Exercise_for2_103() //NO SE METE EN MI FUNCION
        {
            int n1 = Utils.comodin();
            int n2 = Utils.comodin();
            if (n1 < n2)
            {
                for (int i = 1; i < n1; i--)
                {
                    if ((n2 % n1) == 0)
                    {
                        System.Console.WriteLine(i + "es el común divisor");
                    }

                }

            }
            else
            {
                for (int j = 1; j < n2; j--)
                {
                    if ((n1 % n2) == 0)
                    {
                        System.Console.WriteLine(j + "es el común divisor");
                    }

                }

            }
        }

        //(2.2.10.2) Crea un programa que pida al usuario dos números y escriba su mínimo común múltiplo(pista: una solución 
        //lenta pero sencilla es probar con un "for"  todos los números a partir del mayor de ambos, de forma creciente; cuando
        //encuentres un número que sea múltiplo de ambos, interrumpes la búsqueda).

        //(2.3.1) Crea un programa que escriba los números del 1 al 10, separados por un  espacio, sin avanzar de línea.
        //No puedes usar "for", ni "while", ni "do..while", sólo "if" y "goto".
        public static void Exercise_if_goto_109()
        {
            int n = 1;
            if (n <= 10)
            {
                System.Console.Write(n + " ");
                n++;
            }
            else
            {
                goto salida;
                salida:
            }
        }
        //(2.5.1) Crea un programa que cuente cuantas veces aparece la letra 'a' en una  frase que teclee el usuario, utilizando "foreach".
        public static void Exercise_foreach_110()
        {
            Console.Write("Dime tu nombre: ");
            string a = Console.ReadLine();
            foreach (char letra in a)
            {
                Console.WriteLine(letra);
            }
        }




    }
}
