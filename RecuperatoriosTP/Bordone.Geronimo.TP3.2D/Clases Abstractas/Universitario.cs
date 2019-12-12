using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Constructores

        public Universitario()
        {

        }
        
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
#endregion

        #region Operadores
        
        /// <summary>
        /// Un universitario sera igual a otro si sus legajos o sus DNI coinciden, verificando previamente que sean ambos, también, del mismo tipo.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool returnValue = false;
            if(pg1.GetType() == pg2.GetType())
            {
                if((pg1.legajo == pg2.legajo) || (pg1.DNI == pg2.DNI))
                {
                    returnValue = true;
                }
            }
            return returnValue;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion

        #region Metodos
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString() + " LEGAJO: NUMERO: " + this.legajo + "\r\n\r\n");
            return sb.ToString();
        }
        protected abstract string ParticiparEnClase();
#endregion

    }
}
