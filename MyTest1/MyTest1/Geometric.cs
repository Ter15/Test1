using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo2
{
    class Geometric
    {
        public static double GetVector2DLength(double vx, double vy)

        {
            double aux = vx * vx + vy * vy;
            return System.Math.Sqrt(aux);
        }

        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {

            double vx = x2 - x1;
            double vy = y2 - y1;

            return GetVector2DLength(vx, vy);

        }

        public static double GetVector3DLength(double vx, double vy, double vz)
        {
            double aux = vx * vx + vy * vy + vz * vz;
            return System.Math.Sqrt(aux);
        }

        public static double CalculateDistance3D(double x1, double y1, double x2, double y2, double z1, double z2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            double vz = z2 - z1;

            return GetVector3DLength(vx, vy, vz);
        }

        public static double GetCircleArea(double r)
        {
            double area;

            area = System.Math.PI * r * r;

            return area;

        }

        public static double calculateVolumenCircule(double r)
        {
            double volumen;

            volumen = (4.0 * System.Math.PI * r * r * r) / (3);

            return volumen;


        }

        public static double GetRectangleArea(double width, double height)
        {
            double area;

            area = width * height;

            return area;




        }









    }
}