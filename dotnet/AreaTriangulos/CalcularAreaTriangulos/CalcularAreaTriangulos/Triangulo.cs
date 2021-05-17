using System;

namespace CalcularAreaTriangulos
{
    class Triangulo
    {
        //+------------------+
        //|    TRIANGULO     |
        //+------------------+
        //| - A:double       |
        //| - B:double       |
        //| - C:double       |
        //+------------------+
        //| + Area(): double |
        //+------------------+

        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
