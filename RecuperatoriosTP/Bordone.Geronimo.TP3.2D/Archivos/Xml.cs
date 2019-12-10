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
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(archivo);
            serializer.Serialize(writer, datos);
            writer.Close();
            return true;
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlTextReader reader;
            XmlSerializer ser;
            reader = new XmlTextReader(archivo);
            ser =  new XmlSerializer(typeof(T));
            datos = (T)ser.Deserialize(reader);
            reader.Close();
            return true;
        }
    }
}
