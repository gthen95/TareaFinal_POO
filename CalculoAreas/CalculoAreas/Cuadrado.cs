using System;
using System.Linq;

namespace CalculoAreas
{
    public class Cuadrado : DibujarFigura
    {


        public double getArea(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public bool IsNumeric(string n)
        {
            if (n.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void DibujarFigura(string figura)
        {
            CrearArchivo(figura);
        }
    }
}
