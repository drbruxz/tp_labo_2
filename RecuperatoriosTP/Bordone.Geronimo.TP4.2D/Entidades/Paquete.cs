using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region Propiedades y Atributos
        private string direccionEntrega;
        public string DireccionEntrega
        {
            get
            {
                return direccionEntrega;
            }
            set
            {
                direccionEntrega = value;
            }
        }

        private EEstado estado;
        public EEstado Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }

        private string trackingID;
        public string TrackingID
        {
            get
            {
                return trackingID;
            }
            set
            {
                trackingID = value;
            }
        }

        public event DelegadoException EventoException; 
        
        #endregion
        
        public Paquete(string direccion, string trackingID)
        {
            this.direccionEntrega = direccion;
            this.trackingID = trackingID;
        }

        #region Metodos
        /// <summary>
        /// Implementa la interfaz IMostrar con el tipo Paquete
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            string returnValue = null;

            returnValue = String.Format("{0} para {1}", this.trackingID, this.direccionEntrega);

            return returnValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Dir: " + this.DireccionEntrega + " ");
            sb.Append("ID: " + this.TrackingID + " ");
            sb.Append("Estado: " + this.Estado + " ");

            return sb.ToString();
        }

        /// <summary>
        /// Siempre y cuando el estado del paquete no sea Entregado realizará el loop.
        /// Loop: Sleep por cuatro segundos, si está en viaje pasará a entregado, si esta ingresado pasará a en viaje. Invocará el evento InformarEstado
        /// Al finalizar insertará el paquete en la base de datos.
        /// </summary>
        public void MockCicloDeVida()
        {
            //Informa de inmediato el estado para que figure como ingresado en el acto. 
            this.InformarEstado.Invoke(this, EventArgs.Empty); 

            while (this.estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);

                if (this.estado == EEstado.EnViaje)
                {
                    this.estado = EEstado.Entregado;
                }

                if (this.estado == EEstado.Ingresado)
                { 
                    this.estado = EEstado.EnViaje;
                }

                this.InformarEstado.Invoke(this, EventArgs.Empty);
            }
                PaqueteDAO.Insertar(this);
        }
        #endregion

        #region Operadores
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool returnValue = false;

            if (string.Compare(p1.TrackingID, p2.TrackingID) == 0)
                returnValue = true;
            return returnValue;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public delegate void DelegadoEstado(object sender, EventArgs e);

        public event DelegadoEstado InformarEstado;
#endregion
    }

    public delegate void DelegadoException(Exception ex);

    public enum EEstado
    {
        Ingresado = 0,
        EnViaje = 1,
        Entregado = 2
    }
}
