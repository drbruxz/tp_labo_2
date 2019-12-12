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
            bool returnValue = false;
            bool append = (File.Exists(archivo));
            StreamWriter sw = new StreamWriter(archivo, append);
            try {

                sw.WriteLine(datos);
                returnValue = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Excepcion encontrada: " + ex.ToString());
            }
            finally
            {
                if(returnValue ==true)
                    sw.Close();
            }
            return returnValue;
        }

        public static bool Leer(string archivo, out string datos)
        {
            StreamReader sr = new StreamReader(archivo);
            bool returnValue = false;
            try
            { 
                datos = sr.ReadToEnd();
                returnValue = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Excepcion hallada: " + ex.ToString());
                datos = null;
            }
            finally
            {
                sr.Close();
            }

            return returnValue;
        }
    }
}
