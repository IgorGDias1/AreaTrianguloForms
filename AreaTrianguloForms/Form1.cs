using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class fmAreaTriangulo : Form
    {
        public fmAreaTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores dos textboxes:
                double numbase, numaltura;
                numbase = double.Parse(txbBase.Text);
                numaltura = double.Parse(txbAltura.Text);

                // Calcular a área: 
                txbResultado.Text = ((numbase * numaltura) / 2).ToString();
            }
            catch
            {
                MessageBox.Show("Dados inválidos informados!");
                txbResultado.Clear();
                txbAltura.Clear();
                txbBase.Clear();
            }
        }

        private void txbBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmAreaTriangulo_Load(object sender, EventArgs e)
        {

        }

        private void txbResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
