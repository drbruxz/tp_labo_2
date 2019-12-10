using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            bool checkFileExistence = false;
            bool returnValue = false;

            string nombre = archivo;
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaFinal = Path.Combine(ruta, archivo);

            if (File.Exists(rutaFinal))
                checkFileExistence = true;

            StreamWriter sw = new StreamWriter(rutaFinal, checkFileExistence);
            sw.WriteLine(texto);
            sw.Close();
            returnValue = true;

            return returnValue;
        }

    }
}
