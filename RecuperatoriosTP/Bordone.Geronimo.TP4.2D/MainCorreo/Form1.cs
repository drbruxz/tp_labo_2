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

            this.ActualizarEstados();
        }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }
    }
}
