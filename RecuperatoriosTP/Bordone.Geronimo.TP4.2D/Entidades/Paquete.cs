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

        public Paquete(string direccion, string trackingID)
        {
            this.direccionEntrega = direccion;
            this.trackingID = trackingID;
        }


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


        public void MockCicloDeVida()
        {
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

    }

   

    public enum EEstado
    {
        Ingresado = 0,
        EnViaje = 1,
        Entregado = 2
    }
}
