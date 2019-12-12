using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Propiedades y Atributos

        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }
        /// <summary>
        /// Constructor por defecto inicializa ambas listas.
        /// </summary>
        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        #endregion

        #region Operadores
        /// <summary>
        /// Añade un paquete a la lista de paquetes del correo, siempre y cuando el paquete no exista previamente
        /// Si el paquete existe lanza la excepcion con su texto personalizado
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.paquetes)
            {
                if (p == item)
                {
                    throw new TrackingIdRepetidoException("Id de paquete repetido! Paquete ya existe");
                }
            }
            c.paquetes.Add(p);

            Thread hiloPaquete = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hiloPaquete);
            hiloPaquete.Start();
            
            return c;
        }
        #endregion

        #region Metodos
        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            string returnValue = null;
            foreach (Paquete p in this.paquetes)
            {
                returnValue += String.Format("{0} para {1} ({2}) \n", p.TrackingID, p.DireccionEntrega, p.Estado);
            }

            return returnValue;
        }

        /// <summary>
        /// Llama al metodo aborto con todos los threads en la lista de mockPaquetes
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread item in this.mockPaquetes)
            {
                item.Abort();
            }
        }

#endregion

    }


}
