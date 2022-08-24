using System;
using System.Linq;

namespace CalculoAreas
{
    internal class Program
    {
        private static string[] OpcionesMenu = new string[]
        {
            "1. Calcular Area del Circulo",
            "2. Calcular Area del Triangulo",
            "3. Calcular Area del Cuadrado",
            "4. Salir"
        };

        private static int x;
        private static int y;

        private static void Main(string[] args)
        {

            double area;
            Circulo circulo = new Circulo();
            Triangulo triangulo = new Triangulo();
            Cuadrado cuadrado = new Cuadrado();

            bool Loop = true;
            int counter = 0;
            ConsoleKeyInfo Tecla;
            bool isFirst = true;

            while (Loop)
            {
                if (!isFirst)
                {
                    string resp = Funciones.ConsoleStringYesOrNot("Deseas realizar otra operacion: {S/N): ");


                    if (resp.ToUpper() == "N")
                    {
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    }
                    Console.Clear();
                }
                else
                {
                    isFirst = false;
                }

                Console.CursorVisible = false;
                Console.WriteLine("Seleccione una opcion del menu y presione ENTER" + System.Environment.NewLine);
                x = Console.CursorLeft;
                y = Console.CursorTop;
                string Resultado = Menu(OpcionesMenu, counter);

                while ((Tecla=Console.ReadKey(true)).Key != ConsoleKey.Enter)
                {
                    switch (Tecla.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (counter == OpcionesMenu.Length - 1) continue;
                            counter++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (counter == 0) continue;
                            counter--;
                            break;
                        default:
                            break;
                    }
                    Console.CursorLeft = x;
                    Console.CursorTop = y;

                    Resultado= Menu(OpcionesMenu,counter);

                }

                switch (counter)
                {
                    case 0:
                        Console.CursorVisible = true;
                        Funciones.RepetirCaracter("=");
                        Funciones.AlinearTitulos("|  Calculando el area del Circulo  |");
                        double r = Funciones.ConsoleDouble("Escriba el valor del radio: ");
                        area = circulo.getArea(r);
                        Console.WriteLine($"El area del circulo es de: {area} \n");

                        //Dibujando la Figura Indicada
                        circulo.DibujarFigura("circulo.txt");
                        break;
                    case 1:
                        Console.CursorVisible = true;
                        Funciones.RepetirCaracter("=");
                        Funciones.AlinearTitulos("|  Calculando el area del Triangulo  |");
                        double b = Funciones.ConsoleDouble("Escriba el valor de la base : ");
                        double h = Funciones.ConsoleDouble("Escriba el valor de la altura : ");
                        area = triangulo.getArea(b, h);
                        Console.WriteLine($"El area del triangulo es de: {area} \n");

                        //Dibujando la Figura Indicada
                        triangulo.DibujarFigura("triangulo.txt");
                        break;
                    case 2:
                        Console.CursorVisible = true;
                        Funciones.RepetirCaracter("=");
                        Funciones.AlinearTitulos("|  Calculando el area del Cuadrado  |");
                        double l = Funciones.ConsoleDouble("Escriba el valor de uno de los lados : ");
                        area = cuadrado.getArea(l);
                        Console.WriteLine($"El area del cuadrado es de: {area} \n");

                        //Dibujando la Figura Indicada
                        cuadrado.DibujarFigura("cuadrado.txt");
                        break;
                    case 3:
                        Loop = false;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                }
            }
        }

        private static string Menu(string[] items, int opcion)
        {
            string SeleccionActual = string.Empty;
            int destacado = 0;

            Array.ForEach(items, element =>
            {
                if(destacado == opcion)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor= ConsoleColor.Red;
                    Console.WriteLine(" > " + element + " < ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    SeleccionActual = element;
                }
                else
                {
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.CursorLeft = 0;
                    Console.WriteLine(element);
                }
                destacado++;
            });

            return SeleccionActual;
        }

    }
}
