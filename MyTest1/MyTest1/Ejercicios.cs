﻿using System;
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
            while (i < n)
            {
                if (Utils.IsEver(i))

                    System.Console.WriteLine(i);
                i++;
            }
        }

        // Ejercicio: Hacer una función que imprima por pantalla si un Número es primo o no. lo vamos hacer en 2 partes
        //Dónde ponemos una función que nos devuelva si un número es primo o no.

        public static void Ejercicio03 (int numero)
        {
            bool es_primo = Utils.IsPrime(numero);
           
            if ( es_primo)
            {
                System.Console.WriteLine(" El numero" + numero + " es primo");
                System.Console.WriteLine(" El numero" + numero + " no es primo");
            }

        }

        //  Ejercicio: hacer una función que imprima lo siguiente: 0,1,2,3,4,5,6.....100.
        public static void EjercicioSerie1()        
        {
            int i = 0;
            while (i <= 100)
            {

                System.Console.WriteLine("La solución es:" + i);

               i++;
            }
        }

        // Ejercicio: hacer que salgan numeros pares, sin tocar lo de arriba.  se multiplica por 2 la i y te sale en pantalla los numeros pares.
        public static void Ejercicioserie2()
        {
            int i = 2;
            while (i <= 100)
            {
                System.Console.WriteLine("La solución es:" + i*2);
                i++;
            }
        }
        // Ejercicio: que salgan numeros asi: 1, 4, 7, 10, 13,.....

        public static void EjercicioSerie3()
        {

            int i = 0;

            while ( i <= 100)
            {
                System.Console.WriteLine(" La solución es " + (i * 3 + 1) );
                i++;
            }

        }
        //Ejercicio: 0, 1,4,9,16,25,36,....
        public static void EjercicioSerie04()
        {
            int i = 0;
            while ( i <= 100)
            {
                System.Console.WriteLine (" La solución es " (i * i) );
                i++;
            }

       

        }



    }




}


