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
