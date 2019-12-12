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

        /// <summary>
        /// Antes de guardar con el StreamWriter verifica que el archivo exista previamente.
        /// Si exista la variable checkfileExistence pasara de false a true.
        /// La variable checkFileExistence se usa para determinar el valor del Append del constructor del StreamWriter.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            bool checkFileExistence = false;
            bool returnValue = false;

            string nombre = archivo;
            ///La ruta es el escritorio.- Ruta final es la combinacion de la ruta con el nombre del archivo.
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
