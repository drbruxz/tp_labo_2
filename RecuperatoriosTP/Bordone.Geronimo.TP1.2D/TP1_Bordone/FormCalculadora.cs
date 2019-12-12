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

namespace TP1_Bordone
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            txtResultado.Text = "0";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            Numero num1 = new Numero(txtNum1.Text);
            Numero num2 = new Numero(txtNum2.Text);
            resultado = Calculadora.Operar(num1, num2, boxOperador.Text);
            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
            boxOperador.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHacerBinario_Click(object sender, EventArgs e)
        {
            Numero numResultado = new Numero();
            txtResultado.Text = numResultado.DecimalBinario(txtResultado.Text);
        }

        private void btnHacerDecimal_Click(object sender, EventArgs e)
        {
            Numero hacerDecimal = new Numero();
            txtResultado.Text = hacerDecimal.BinarioDecimal(txtResultado.Text);
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
