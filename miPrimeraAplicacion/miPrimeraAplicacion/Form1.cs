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
            if (decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                decimal valorFijoRango = 1000.01m;
                decimal valorBase = 1000m;
                decimal multiplicadorAdicional = 3m;
                decimal precioBase = 3m;

                if (monto >= valorFijoRango)
                {
                    decimal excedente = monto - valorFijoRango;
                    decimal impuesto = ((excedente / valorBase) * multiplicadorAdicional) + precioBase;


                    lblResultado.Text = $"Valor a pagar: ${Math.Round(impuesto, 2):F2}";
                }
                else
                {
                    lblResultado.Text = "El monto no supera el rango base.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          

            
        }

        private void lblCalculo_Click(object sender, EventArgs e)
        {

        }
    }
        
}
