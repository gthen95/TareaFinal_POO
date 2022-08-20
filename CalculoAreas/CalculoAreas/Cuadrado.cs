using System;

namespace CalculoAreas
{
    public class Cuadrado : DibujarFigura
    {


        public double getArea(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public void DibujarFigura(string figura)
        {
            CrearArchivo(figura);
        }
    }
}
