using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
namespace Archivos
{
    public class Texto
    {
        public static bool Guardar(string archivo, string datos)
        {
            StreamWriter sw = new StreamWriter(archivo);
            sw.WriteLine(datos);
            sw.Close();

            return true;
        }

        public static bool Leer(string archivo, out string datos)
        {
            StreamReader sr = new StreamReader(archivo);
            datos = sr.ReadToEnd();
            return true;
        }
    }
}
