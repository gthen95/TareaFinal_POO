using System;
using System.Linq;

namespace CalculoAreas
{
    public class Circulo : DibujarFigura
    {
        public const double PI = 3.1416;


        public double getArea(double radio)
        {
            return PI * Math.Pow(radio, 2);
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
