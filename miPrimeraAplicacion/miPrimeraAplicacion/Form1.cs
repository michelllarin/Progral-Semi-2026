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
            // 1. Validar que la entrada sea un número decimal válido
            if (!decimal.TryParse(txtSueldo.Text, out decimal sueldo) || sueldo <= 0)
            {
                MessageBox.Show("Por favor ingrese un sueldo válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSueldo.Focus();
                return;
            }
            // 2. Descuentos básicos
            decimal isss = Math.Min(sueldo * 0.03m, 30.00m); // ISSS 3%, máximo $30.00
            decimal afp = sueldo * 0.0725m;                  // AFP 7.25%

            // 3. Salario Gravable para el ISR
            decimal gravable = sueldo - isss - afp;
            decimal isr = 0.00m;

            // 4. Cálculo del ISR según tramos de ley
            if (gravable > 2038.10m)
            {
                isr = ((gravable - 2038.10m) * 0.30m) + 288.57m;
            }
            else if (gravable > 895.24m)
            {
                isr = ((gravable - 895.24m) * 0.20m) + 60.00m;
            }
            else if (gravable > 472.00m)
            {
                isr = ((gravable - 472.00m) * 0.10m) + 17.67m;
            }

            // 5. Totales
            decimal totalDeducciones = isss + afp + isr;
            decimal salarioNeto = sueldo - totalDeducciones;

            // 6. Imprimir en pantalla con formato de moneda ($0.00)
            lblISSS.Text = "ISSS (3%): " + isss.ToString("C2");
            lblAFP.Text = "AFP (7.25%): " + afp.ToString("C2");
            lblISR.Text = "ISR (Renta): " + isr.ToString("C2");
            lblTotal.Text = "Total de Deducciones: " + totalDeducciones.ToString("C2");
            lblSalarioaResibir.Text = "Salario a Recibir: " + salarioNeto.ToString("C2");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblISSS.Text = "ISSS (3%):";
            lblAFP.Text = "AFP (7.25%):";
            lblISR.Text = "ISR (Renta):";
            lblTotal.Text = "Total de Deducciones:";
            lblSalarioaResibir.Text = "Salario a Recibir:";

            
        }
    }
        
}
