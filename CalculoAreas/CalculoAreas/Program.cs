using System;
using System.Linq;

namespace CalculoAreas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double area;
            int opcion = 0;
            string input, input2;

            Circulo circulo = new Circulo();
            Triangulo triangulo = new Triangulo();
            Cuadrado cuadrado = new Cuadrado();

            do
            {
                Console.WriteLine($"------------------------------------------------");
                Console.WriteLine($"***Menu Principal***");
                Console.WriteLine($"1. Calcular Area del Circulo");
                Console.WriteLine($"2. Calcular Area del Triangulo");
                Console.WriteLine($"3. Calcular Area del Cuadrado");
                Console.WriteLine($"4. Salir");
                Console.WriteLine($"------------------------------------------------\n");
                Console.Write($"Elige tu opcion....: ");


                string data = Console.ReadLine();
                if (data != null)
                {
                    opcion = int.Parse(data);
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"\n===Calculando el area del Circulo===");
                        Console.Write("Escriba el valor del radio: ");
                        input = Console.ReadLine();
                        while (!circulo.IsNumeric(input))
                        {
                            Console.WriteLine($"Caracter ingresado '{input}' no es un numero. Escriba el valor del radio: ");
                            input = Console.ReadLine();
                        }
                        double r = double.Parse(input);
                        area = circulo.getArea(r);
                        Console.WriteLine($"El area del circulo es de: {area} \n");

                        //Dibujando la Figura Indicada
                        circulo.DibujarFigura("circulo.txt");
                        break;
                    case 2:

                        Console.WriteLine($"\n===Calculando el area del Triangulo===");
                        Console.Write("Escriba el valor de la base : ");
                        input = Console.ReadLine();
                        while (!triangulo.IsNumeric(input))
                        {
                            Console.Write($"Caracter ingresado '{input}' no es un numero. Escriba el valor de la base : ");
                            input = Console.ReadLine();
                        }
                        double b = double.Parse(input);
                        Console.Write("Escriba el valor de la altura : ");
                        input2 = Console.ReadLine();
                        while (!triangulo.IsNumeric(input2))
                        {
                            Console.Write($"Caracter ingresado '{input2}' no es un numero. Escriba el valor de la altura : ");
                            input2 = Console.ReadLine();
                        }
                        double h = double.Parse(input2);
                        area = triangulo.getArea(b, h);
                        Console.WriteLine($"El area del triangulo es de: {area} \n");

                        //Dibujando la Figura Indicada
                        triangulo.DibujarFigura("triangulo.txt");
                        break;
                    case 3:
                        Console.WriteLine($"\n===Calculando el area del Cuadrado===");
                        Console.Write("Escriba el valor de uno de los lados : ");
                        input = Console.ReadLine();
                        while (!cuadrado.IsNumeric(input))
                        {
                            Console.Write($"Caracter ingresado '{input}' no es un numero. Escriba el valor de uno de los lados : ");
                            input = Console.ReadLine();
                        }
                        double l = double.Parse(input);
                        area = cuadrado.getArea(l);
                        Console.WriteLine($"El area del cuadrado es de: {area} \n");

                        //Dibujando la Figura Indicada
                        cuadrado.DibujarFigura("cuadrado.txt");
                        break;
                    case 4:
                        opcion = 4;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion del menu");
                        break;
                }
            }
            while (opcion != 4);



        }

    }
}
