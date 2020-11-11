
using ejemplo2;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Resources;
using System.Threading.Tasks.Dataflow;

namespace MyTest1
{
    class Ejercicios_EXAMEN
    {
        // HACER UNA FUNCIÓN QUE RECIBA 2 NUMEROS ENTEROS Y DEVUEKVA LA SUMA DE LOS 2. NO TENGO QUE PASARLE EL RESULTADO ( EN LOS PARENTESIS NO VA). 
        //una funcion no imprime cosas por pantalla a no ser que se pida explicitamente

        public static int SumarNumeros(int a, int b)
        {

            int result = a + b;
            return result;

        }
        //hacer una funcion que reciba 2 reales y que devuleva la resta de los 2 reales.
        public static int RestaReales(int a, int b)
        {

            int result = a - b;
            return result;
        }
        // hace 2 funciones que que reciban 2 reaales la primera que devuleva el menor de los
        //dos reales y la segunda que devuleva el mayor d elos 2 reales.
        public static int EsMayor(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static int EsMenor(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;
        }
        //hacer una función que se le pasen 3 enteros y que devuelva el mayor d elos 3
        public static int EsMayorDe3(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b > c)
                    return b;
                else
                    return c;
            }
        }
        // hacer una funcion que reciba dos enteros 
        //y devuleva -1 si el primero es menos que el segundo y 1 si el segundo es menor que el primero y 0 si son iguales 
        public static int DEVOLVER(int a, int b)
        {
            if (a < b)
            {
                return -1;
            }
            if (a > b)
            {
                return 0;
            }
            return 1;
        }
        // hacer una función que reciba un codiog de error y muestre por pantalla lo siguiente:
        // " error grave" si el error es 0
        // " error moderado"  si el error es 1
        // " error leve"  si el error es 2
        // " error desconocido"  en cualquier otro caso
        public static void ErrorCodigo(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine(" ERROR GRAVE");
                    break;
                case 1:
                    System.Console.WriteLine(" Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine(" Error leve");
                    break;
                default:
                    System.Console.WriteLine(" Error desconocido");
                    break;

            }
        }
        // haced una función que reciba un numero y en funcion de ese numero escriba la siguiente serie:
        // ejemplo : 0,3,6,9,12...   función(10) : 0,3,6,9.
        public static void SerieNumeros(int code)
        {
            int i = 0;

            while (i <= code)
            {
                System.Console.Write(i + ",");

                i += 3;
            }
        }
        // HACER UNA FUNCIÓN QUE RECIBA UN NUMERO ENTERO E IMPRIMA TODOS LOS NUMEROS DESDE EL 0 HASTA ESE NUMERO. HAY QUE UTILIZAR UN FOR
        public static void ImprimirTodosLosNumeros(int numero)
        {

            for (int i = 0; i <= numero; i++)
                System.Console.Write(i + ",");

        }
        // hacer lo mismo que el ejercicio anterior pero sin "," al final   
        public static void ImprimirUltimoSinComa(int numero)
        {
            int i; // se declara la variable fuera para que pueda cogerla el if de abajo.
            for (i = 0; i < numero; i++)
                System.Console.Write(i + ",");

            if (numero > 0) ;
            System.Console.Write(numero);
        }
        // quiero una funcion que devuelva el mayor de 6 enteros. quiero que esa funcion ocupe una linea. HECHO EN LA LIBRETA
        public static int MayorDe6(int a, int b, int c, int d, int e, int f)
        {
            return EsMayor(EsMayorDe3(a, b, c), EsMayorDe3(d, e, f));
        }
        // hacer una funcion que se le pase un entero e imprima tantos astericos como ese entero que se le pasa. Ejemoplo: 
        // SI SE EL NUEMRO DE VECES QUE SE CA A EJECUTAR UN BUCLE ES ACONSEJABLE EL FOR
        public static void Asteriscos(int numero)
        {
            for (int i = 0; i <= numero; i++)
                System.Console.Write("*");
        }
        //lo mismo pero en vez de imprimer asterisco imprme lo siguiente: *+*(3) *+*+*+*(7)
        public static void SerieAsteriscosSumas(int numero)
        {

            for (int i = 0; i <= numero; i++)
            {
                if ((i % 2) == 0)   // esta es la mejor forma que no te ha salido    if ( utils.IsEven(i))
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }

        }
        //igual  que la funcion de arriba pero tiene que imprimir lo siguiente: *+-/*+-/....
        public static void SerieMasCompleja(int numero)
        {
            for (int i = 0; i <= numero; i++)
            {
                switch (i % 4)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;

                }
            }

        }
        //HACER UNA FUNCION QUE RECIBA UN NUMERO Y EN FUNCION DE ESE NUMERO 
        //QUE IMPRIMA LO SIGUIENTE: SI LE PASO UN 3 HACER UNA UN CUADRADO DE 3X3 CON ASTERISCOS. aqui cuidado con el igual q sino te imprime un numero mas del q pides
        public static void HacerCuadrados(int numero)
        {
            for (int f = 0; f < numero; f++) // f de fila en castellano, en ingles i
            {
                for (int c = 0; c < numero; c++) // c de columna en castellano, en ingles j

                    System.Console.Write("*");

                System.Console.WriteLine();
            }

        }
        // otro ejercicio: 
        public static void VarienteCuadrados(int numero)
        {
            int f;
            int c;
            for (f = 0; f < numero; f++)
            {
                for (c = 0; c < numero; c++)
                {
                    if ((f % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }
        // *+*+
        //  +*+*
        //  *+*+
        //  +*+*
        public static void AsteriscoSuma(int numero)
        {
            int f;
            int c;

            for (f = 0; f < numero; f++)
            {
                for (c = 0; c < numero; c++)
                {
                    int flag = c + f;

                    if ((flag % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }
        public static void AsterisEscalera(int numero)
        {
            int f;
            int c;

            for (f = 0; f < numero; f++)
            {
                for (c = 0; c <= f; c++)
                {
                    System.Console.Write("*");

                }
                System.Console.WriteLine();
            }
        }
        public static void AsteriscosEscaleraInversa(int numero)
        {
            int f;
            int c;
            for (f = 0; f < numero; f++)
            {
                int nEspacios = numero - f - 1;
                int nAsteriscos = f + 1;

                for (c = 0; c < nEspacios; c++)
                    System.Console.Write(" ");

                for (c = 0; c < nAsteriscos; c++)
                    System.Console.Write("*");

                System.Console.WriteLine();
            }
        }
        public static void Piramide(int numero)
        {
            int f;
            int c;
            for (f = 0; f < numero; f++)
            {
                int nAsterisco1 = numero - f - 1;
                int nAsteriscos2 = f * 2;

                for (c = 0; c < nAsterisco1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");



                for (c = 0; c < nAsteriscos2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                System.Console.WriteLine(" ");

            }
        }
        //PIRAMIDE 2.0
        public static void Piramide2(int numero)
        {

            int f;
            int c;
            for (f = 0; f < numero; f++)
            {
                int nAsterisco1 = numero - f - 1;
                int nAsteriscos2 = f * 2 - 1; // MaxValue (0, 2 * f -1) para que cuando f sea 0, la solucion no sea -1

                for (c = 0; c < nAsterisco1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                for (c = 0; c < nAsteriscos2; c++)
                    System.Console.Write(" ");
                if (f != 0)
                    System.Console.Write("*");

                System.Console.WriteLine(" ");


            }
        }

        // piramide 3

        public static void Piramide3(int numero)
        {
            int f;
            int c;
            for (f = 0; f < numero; f++)
            {
                int nAsterisco1 = f;
                int nAsteriscos2 = (numero - f - 1) * 2;

                for (c = 0; c < nAsterisco1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                for (c = 0; c < nAsteriscos2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");

                System.Console.WriteLine(" ");

            }

        }
        // Rombo
        public static void Rombo(int numero)
        {
            Piramide(numero);
            Piramide3(numero);

        }

        // BANDERA AMERICANA
        public static void BanderaAmericana()
        {
            int f;
            int c;

            for (f = 0; f < 10; f++)
            {
                for (c = 0; c < 20; c++)
                {
                    int f2 = f / 2;

                    if (0 <= c && c <= 8 && 0 <= f && f <= 2)
                    {
                        int flag = c + f;
                        if (Utils.IsEven(flag))
                        {
                            System.Console.Write("+");
                        }
                        else
                        {
                            System.Console.Write(" ");
                        }
                    }
                    else if (Utils.IsEven(f2))
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
        }

        public static void BnaderaJaponesa()
        {
            double f;
            double c;
            //int d;
            for (f = 0; f < 19; f++)
            {
                for (c = 0; c < 74; c++)
                {
                    if (c == 0 || c == 74 || f == 0 || f == 19)
                    {
                        System.Console.Write("*");
                    }
                    else if (Geometric.CalculateDistance2D( 37, 10, c, f) < 5.0)                                       //( d = Math.Sqrt (Math.Pow((20 - f), 2) + Math.Pow((50 - c), 2) < 5.0))
                    {
                        System.Console.Write("0");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
            }
        }
    }
}
   