using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Schema;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {

            double solution;

            solution = EquationSolvers.SolveEquation2(4.0, 5.8, 9.0);

            solution = EquationSolvers.SolveEquation(6.0, 7.0);


            Console.WriteLine("Hello World!");

            double l1;
            l1 = Geometric.GetVector2DLength(5.0, 4.0);

            double G2;
            G2 = Geometric.CalculateDistance2D(0.0, 0.0, 1.0, 1.0);

            double D3;
            D3 = Geometric.CalculateDistance3D(6.0, 8.0, 5.6, 3.9, 5.0, 2.0);

            double A4;
            A4 = Geometric.GetCircleArea(6.0);

            double V4;
            V4 = Geometric.calculateVolumenCircule(8.0);

            double A5;
            A5 = Geometric.GetRectangleArea(5.0, 3.0);

            int T1;
            T1 = Utils.GetMinValue(8, -6);

            int J2;
            J2 = Utils.GetMaxValue(8, -6);

            bool Q2;
            Q2 = Utils.IsEver(44);

            Ejercicios.Ejercicio01();

            Ejercicios.Ejercicio02(13);

            Ejercicios.Ejercicio03(99);
            
            int numero = 2;

            while ( numero < 65)
            {
               if (Utils.IsPrime(numero))
                    System.Console.WriteLine(" ES PRIMO: " + numero);
                
                numero++;
            }

            Ejercicios.EjercicioSerie1();
            Ejercicios.Ejercicioserie2();
            Ejercicios.EjercicioSerie3();
            Ejercicios.EjercicioSerie04();
            Ejercicios.EjercicioSerie05();

        }


    }
}
