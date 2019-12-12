using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using Excepciones;


namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Constructores

        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id,nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sumamos al metodo mostar datos base el estado de cuenta y la clase que toma
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos() + "ESTADO DE CUENTA: " + this.estadoCuenta + "\r\n" + "TOMA CLASES DE: " + this.ParticiparEnClase() + "\r\n");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        protected override string ParticiparEnClase()
        {
            return (this.claseQueToma.ToString());
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Un alumno es igual a una clase si toma esa clase y no es un deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases c)
        {
            bool returnValue = false;

            if((a.claseQueToma == c) && (a.estadoCuenta != EEstadoCuenta.Deudor))
            {
                returnValue = true;
            }

            return returnValue;

        }

        public static bool operator!=(Alumno a, Universidad.EClases c)
        {
            bool returnValue = false;

            if(a.claseQueToma != c)
            {
                returnValue = true;
            }
            return returnValue;
        }
        #endregion

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

    }
    

}
