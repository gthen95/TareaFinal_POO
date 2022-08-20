namespace CalculoAreas
{
    public class Triangulo : DibujarFigura
    {


        public double getArea(double b, double h)
        {
            return (b * h) / 2;
        }

        public void DibujarFigura(string figura)
        {
            CrearArchivo(figura);
        }
    }
}
