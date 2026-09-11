using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class btnLooo : Form
    {
        public btnLooo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtMetros.Text, out double metros) || metros < 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida de metros cúbicos (m³).",
                                "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double cuotaAcueducto = 0;
            double cuotaAlcantarillado = 0;

            if (metros <= 10)
            {
                cuotaAcueducto = 2.29;
                cuotaAlcantarillado = 0.10;
            }
            else if (metros <= 20)
            {
                cuotaAcueducto = metros * 0.21;
                cuotaAlcantarillado = 0.10;
            }
            else if (metros <= 30)
            {
                cuotaAcueducto = metros * 0.37;
                cuotaAlcantarillado = 1.80;
            }
            else if (metros <= 40)
            {
                cuotaAcueducto = metros * 0.76;
                cuotaAlcantarillado = 3.00;
            }
            else if (metros <= 50)
            {
                cuotaAcueducto = metros * 1.65;
                cuotaAlcantarillado = 4.00;
            }
            else
            {
                cuotaAcueducto = metros * 2.20;
                cuotaAlcantarillado = 7.50;
            }

            double totalPagar = cuotaAcueducto + cuotaAlcantarillado;

            lblResultado.Text = $"Total a Pagar: ${totalPagar:F2} al mes";
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear(); 

            lblResultado.Text = "Total a pagar: $0.00";

            txtMetros.Focus();

        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
}
