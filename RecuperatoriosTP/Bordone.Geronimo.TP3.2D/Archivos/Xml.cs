using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> 
    {
        public bool Guardar(string archivo, T datos)
        {
            bool returnValue = false;
            TextWriter writer = new StreamWriter(archivo);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
             {

                serializer.Serialize(writer, datos);
                returnValue = true;
            }catch(Exception ex)
            {
                Console.WriteLine("Excepcion encontrada: " + ex.ToString());
            }
            finally 
            { 
                writer.Close();
            }
            return returnValue;
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlTextReader reader = new XmlTextReader(archivo);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            bool returnValue = false;
            try
            {
                datos = (T)ser.Deserialize(reader);
                returnValue = true;
            }catch(Exception ex)
            {
                Console.WriteLine("Excepcion encontrada: " + ex.ToString());
                datos = default(T);
            }
            finally
            {
                reader.Close();
            }
            
            return returnValue;
        }
    }
}
