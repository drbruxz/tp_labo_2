using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        #region Propiedades y Atributos
        private string apellido;

        /// <summary>
        /// Valida el apellido con la funcion ValidarNombreApellido antes de asginar su valor al atributo privado
        /// </summary>
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if(this.ValidarNombreApellido(value) != null)
                { 
                    apellido = value;
                }
                else
                {
                    apellido = null;
                }
            }
        }

        /// <summary>
        /// Valida el nombre con la funcion ValidarNombreApellido antes de asginar su valor al atributo privado
        /// </summary>
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (this.ValidarNombreApellido(value) != null)
                {
                    nombre = value;
                }
                else
                {
                    nombre = null;
                }
            }
        }

        /// <summary>
        /// Valida el DNI y su concordancia con la nacionalidad con la funcion validar DNI antes de asignar su valor al atributo privado
        /// En caso de que la validacion falle arrojará una excepcion NacionalidadInvalidaException con un texto adecuado
        /// </summary>
        private int dni;
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                if ((this.ValidarDni(this.nacionalidad, value) != -1))
                {
                    this.dni = value;
                }
                else
                {
                    throw new NacionalidadInvalidaException("La nacionalidad no se condice con el numero de DNI");
                }
                
            }
        }


        private ENacionalidad nacionalidad;
        public ENacionalidad Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
                nacionalidad = value;
            }
        }

        /// <summary>
        /// Validara que el dni sea exclusivamente numerico antes de asignar su valor al atributo público DNI
        /// Si la validacion fracasa arrojara una excepcion DniInvalidoException con un texto apropiado
        /// </summary>
        public string StringToDNI
        {
            set
            {
                ///LANZAR EXCEPCION

                if(this.ValidarDni(this.nacionalidad, value) != -1)
                {
                    this.DNI = int.Parse(value);
                }
                else
                {
                    throw new DniInvalidoException("DNI invalido: Debe solo contener numeros");
                }
                
            }
        }
        #endregion

        #region Constructores

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }



        #endregion

        #region Metodos

        /// <summary>
        /// Dependiendo de si es argentino o extranjero el DNI deberá estar incluido en determinados rangos numericos.
        /// Si la validacion es correcta el int devuelto será el dni intacto.
        /// De lo contrario el int devuelto será -1
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int returnValue = -1;

            switch (nacionalidad)
            {
                case Persona.ENacionalidad.Argentino:
                    if(dato >= 1 && dato<= 89999999)
                    {
                        returnValue = dato;
                    }
                    break;

                case Persona.ENacionalidad.Extranjero:
                    if(dato >= 90000000 && dato <= 99999999)
                    {
                        returnValue = dato;
                    }
                    break;
            }

            return returnValue;
        }

        /// <summary>
        /// Verifica que el dato en string pueda ser parseado a un int, si es posible el valor será asignado a un auxiliar.
        /// De tener éxito el retorno será el int ya parseado.
        /// De fracasar el valor de returnValue permanecerá como inicializado, en -1, y ese será el valor de retorno.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int returnValue = -1;
            int aux;

            if(int.TryParse(dato, out aux))
            {
                returnValue = aux;
            }

            return returnValue;
        }

        /// <summary>
        /// Valida caracter por caracter que no exista caracter que no sea una letra.
        /// Si alguno no es una letra retorna null. Si son todos letras retorna el dato intacto.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach(char c in dato)
            {
                if (!(Char.IsLetter(c)))
                {
                    return null;
                }
            }

            return dato;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1} \nNACIONALIDAD: {2}\n\n", this.Apellido, this.Nombre, this.Nacionalidad);
            return sb.ToString();
        }
        #endregion

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }

    
}
