using System;
using System.IO;

namespace CalculoAreas
{
    public class DibujarFigura
    {
        public void CrearArchivo(string figura)
        {
            string rutaInicial = AppDomain.CurrentDomain.BaseDirectory + "Figuras_Ejemplos";
            string rutaFinal = AppDomain.CurrentDomain.BaseDirectory + "Dibujos_FigurasNuevas";
            string file = rutaInicial + "\\" + figura;
            string fileNew = $"{rutaFinal}\\Nuevo_{figura}";

            if (!(Directory.Exists(rutaFinal)))
            {
                Directory.CreateDirectory(rutaFinal);
            }

            if (File.Exists(file))
            {
                File.Copy(file, fileNew, true);
            }

            System.Diagnostics.Process.Start("notepad.exe", fileNew);

        }
    }
}
