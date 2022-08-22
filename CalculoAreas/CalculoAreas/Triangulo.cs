using System.Linq;

namespace CalculoAreas
{
    public class Triangulo : DibujarFigura
    {


        public double getArea(double b, double h)
        {
            return (b * h) / 2;
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
