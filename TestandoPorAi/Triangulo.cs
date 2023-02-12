using System;
namespace TestandoPorAi

{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //Calculo da área do triangulo
        public double Area()
        {
            double areaTriangulo = (A + B + C) / 2.0;
            return Math.Sqrt(areaTriangulo * (areaTriangulo - A) *
                                     (areaTriangulo - B) * (areaTriangulo - C));

        }
    }
}
