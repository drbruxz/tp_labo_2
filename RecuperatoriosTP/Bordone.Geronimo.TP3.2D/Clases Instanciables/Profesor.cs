using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
namespace Clases_Instanciables
{

    public sealed class Profesor : Universitario
    {

        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores
        public Profesor()
        {

        }
        static Profesor()
        {
            
            random = new Random();

        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this.RandomClases();
        }

#endregion

        #region Operadores
        /// <summary>
        /// Un profesor sera igual a una clase si esa esta en su lista de clases del día
        /// </summary>
        /// <param name="p"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor p, Universidad.EClases c)
        {
            bool returnValue = false;

            foreach(Universidad.EClases item in p.clasesDelDia)
            {
                if (c == item)
                    returnValue = true;
            }
            return returnValue;
        }

        public static bool operator!=(Profesor p, Universidad.EClases c)
        {
            return !(p == c);
        }

#endregion

        #region Metodos
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Universidad.EClases item in this.clasesDelDia)
            {
                sb.Append(item.ToString());
            }
            return ("CLASES DEL DIA: " + sb.ToString()); 
        }


        public override string ToString()
        {
            return (this.MostrarDatos() + "\n");
        }

        /// <summary>
        /// Añade a los datos base las clases en las que el docente participa
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos() + this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Generacion de clases aleatoria con random.Next, casteando el numero luego a valores del enum EClases
        /// </summary>
        private void RandomClases()
        {

            int i, j;


            i = random.Next(1, 4);
            j = random.Next(1, 4);

            clasesDelDia.Enqueue((Universidad.EClases)i);
            clasesDelDia.Enqueue((Universidad.EClases)j);

        }
        #endregion

    }
}
