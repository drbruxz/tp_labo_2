using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    public class Universidad
    {

        #region Propiedades, Atributos y Constructor
        private List<Jornada> jornada;
        public List<Jornada> Jornada
        {
            get
            {
                return jornada;
            }
            set
            {
                jornada = value;
            }
        }

        private List<Alumno> alumnos;
        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }
            set
            {
                alumnos = value;
            }
        }

        private List<Profesor> instructores;

        public List<Profesor> Instructores
        {
            get
            {
                return instructores;
            }
            set
            {
                instructores = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }

        public Universidad()
        {
            this.jornada = new List<Clases_Instanciables.Jornada>();
            this.alumnos = new List<Alumno>();
            this.instructores = new List<Profesor>();
        }
        #endregion

        #region Operadores

        ///ENTRE UNIVERSIDAD Y ALUMNO
        public static bool operator==(Universidad u, Alumno a)
        {
            bool returnValue = false;

            foreach(Alumno item in u.alumnos)
            {
                if (item == a)
                    returnValue = true;
            }

            return returnValue;
        }
        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);
                return u;
            }
            else
            {
                throw new AlumnoRepetidoException("Alumno repetido");
            }
        }

        ///ENTRE UNIVERSIDAD Y PROFESOR
        public static bool operator==(Universidad u, Profesor p)
        {
            bool returnValue = false;

            foreach(Profesor item in u.instructores)
            {
                if (item == p)
                    returnValue = true;
            }

            return returnValue;
        }
        public static bool operator !=(Universidad u, Profesor p)
        {
            return !(u == p);
        }



        public static Profesor operator ==(Universidad u, Universidad.EClases c)
        {
            foreach(Profesor item in u.instructores)
            {
                if(item == c)
                {
                    return item;
                }
            }
            throw new SinProfesorException("No hay profesor para la clase");
        }

        public static Profesor operator !=(Universidad u, Universidad.EClases c)
        {
            foreach (Profesor item in u.instructores)
            {
                if (item != c)
                {
                    return item;
                }
            }
            return null;
        }

        public static Universidad operator +(Universidad u, Profesor p)
        {
            if (u != p)
                u.instructores.Add(p);

            return u;
        }


        ///ENTRE UNIVERSIDAD Y CLASE
        public static Universidad operator +(Universidad u, EClases c)
        {
            Profesor p;
            Jornada j;
            p = (u == c);

            j = new Jornada(c,p);

            foreach(Alumno item in u.alumnos)
            {
                if(item == c)
                {
                    j.Alumnos.Add(item);
                }
            }

            u.jornada.Add(j);
            return u;
        }
        #endregion

        #region Metodos

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Jornada item in this.jornada)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        public static bool Guardar(Universidad u)
        {
            Archivos.Xml<Universidad> xml = new Archivos.Xml<Universidad>();
            return xml.Guardar("Universidad.xml", u);
        }



        #endregion

        public enum EClases
        {
            Programacion = 1,
            Laboratorio = 2,
            Legislacion = 3,
            SPD = 4
        }
    }
    
}
