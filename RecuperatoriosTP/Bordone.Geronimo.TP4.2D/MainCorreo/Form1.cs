using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class Form1 : Form
    {
        private Correo correo;

        public Form1()
        {
            
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            correo = new Correo();

        }

        /// <summary>
        /// Crea un nuevo paquete usando los datos ingresados.
        /// Suma paq_InformaEstado como manejador del evento InformarEstado del paquete.
        /// Intenta añadir el paquete al correo, manejando cualquier excepción posible.
        /// Llama a la funcion ActualizarEstados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paq = new Paquete(txtDireccion.Text,mskIdText.Text);
            paq.InformarEstado += paq_InformaEstado;
            try
            {
                correo += paq;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Se invoca a su mismo hasta que deje de ser necesario. Luego 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }

        }

        /// <summary>
        /// Limpia todos los controles del groupbox1 del tipo ListBox.
        /// Ingresa los paquetes al listbox adecuado a su paquete.
        /// </summary>
        private void ActualizarEstados()
        {
            foreach(Control item in groupBox1.Controls)
            {
                if(item.GetType() == typeof(ListBox))
                {
                    ((ListBox)item).Items.Clear();
                }
            }

            foreach (Paquete p in correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case EEstado.Ingresado:
                        lstIngresado.Items.Add(p);
                        break;
                    case EEstado.EnViaje:
                        lstEnViaje.Items.Add(p);
                        break;
                    case EEstado.Entregado:
                        lstEntregado.Items.Add(p);
                        break;
                }
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        /// <summary>
        /// Implemente el metodo mostrar datos del elemento que implemente la interface IMostrar (verificando previamente que no sea null)
        /// Lo guarda en un archivo txt con el nombre Backup, manejando cualquier excepcion posible.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            
            string guardar = null;
            if(elemento != null)
            {
                txtMostrar.Clear();
                txtMostrar.Text = elemento.MostrarDatos(elemento);
                guardar = elemento.MostrarDatos(elemento);
            }
            try
            {
                guardar.Guardar("Backup.txt");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void menMostrar_Click(object sender, EventArgs e)
        {
            if(this.lstEntregado.SelectedIndex != -1)
            {
                this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEntregado.SelectedItem);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }
    }
}
