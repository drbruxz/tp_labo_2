using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using Archivos;

namespace Clases_Instanciables
{
    public class Jornada
    {

        #region Propiedades y Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }

            set
            {
                this.alumnos = value;
            }
        }
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }

            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region Constructores
        private Jornada()
        {
            Alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clase = clase; 
            this.instructor = instructor;
        }
#endregion

        #region Operadores
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool returnValue = false;

            foreach(Alumno item in j.alumnos)
            {
                if(item == a)
                    returnValue = true;
            }

            return returnValue;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.alumnos.Add(a);
            return j;
        }
#endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CLASE DE: {0} POR {1}\r\n\r\n", this.clase.ToString(),this.instructor.ToString());
            foreach(Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }


        public static bool Guardar(Jornada jornada)
        {
            Texto.Guardar("Jornada.txt", jornada.ToString());
            return true;
        }

        public static bool Leer(Jornada jornada, out string dato)
        {
            Texto.Leer("Jornada.txt", out dato);
            return true;
        }
#endregion

    }
}
