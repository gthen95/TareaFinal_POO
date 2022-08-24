﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreas
{
    public class Funciones
    {
        public static void AlinearTitulos(string title)
        {
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
        }

        public static void RepetirCaracter(string caracter)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(caracter);

            }
            Console.WriteLine();
        }


        public static string ConsoleStringYesOrNot(string dato)
        {
            string resultado = string.Empty;
            while (resultado == string.Empty)
            {
                Console.Write(dato);
                var input = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("\nDebe completar la informacion solicitada...");
                    resultado = string.Empty;
                }
                else if (input.ToUpper() != "S" && input.ToUpper() != "N")
                {
                    Console.WriteLine("\nSolo se aceptan los caracteres S o N...");
                    resultado = string.Empty;
                }
                else
                {
                    resultado = input;
                }
            }

            return resultado;
        }

        public static double ConsoleDouble(string dato)
        {
            double resultado = -1;
            while (resultado == -1)
            {
                Console.Write(dato);
                var valor = Console.ReadLine();

                double.TryParse(valor, out double n);
                if (n == 0 || n < 0)
                {
                    Console.WriteLine("\nEl valor debe ser numerico y mayor que cero");
                    resultado = -1;
                }
                else
                {
                    resultado = n;
                }

            }

            return resultado;
        }

    }
}
