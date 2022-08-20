using System;

namespace CalculoAreas
{
    public class Circulo : DibujarFigura
    {
        public const double PI = 3.1416;


        public double getArea(double radio)
        {
            return PI * Math.Pow(radio, 2);
        }


        public void DibujarFigura(string figura)
        {
            CrearArchivo(figura);
        }


    }
}
