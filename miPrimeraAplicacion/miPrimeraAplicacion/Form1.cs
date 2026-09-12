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
            // 1. Lectura de variables
            int nMeses = (int)txtMeses.Value;
            decimal montoMensual = Convert.ToDecimal(txtMontoMensual.Text);

            // 2. Creación de la estructura de la tabla (DataTable)
            DataTable dt = new DataTable();
            dt.Columns.Add("N° Mes", typeof(int));
            dt.Columns.Add("Monto del Mes", typeof(decimal));
            dt.Columns.Add("Acumulado", typeof(decimal));

            // 3. Proceso de acumulación
            decimal acumulado = 0;

            for (int i = 1; i <= nMeses; i++)
            {
                acumulado += montoMensual; // Suma acumulativa

                // Agregar fila a la tabla
                dt.Rows.Add(i, montoMensual, acumulado);
            }

            // 4. Asignar datos al DataGridView
            dgvAcumulado.DataSource = dt;

            // Formato de moneda para las columnas numéricas
            dgvAcumulado.Columns["Monto del Mes"].DefaultCellStyle.Format = "C2";
            dgvAcumulado.Columns["Acumulado"].DefaultCellStyle.Format = "C2";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLooo_Load(object sender, EventArgs e)
        {

        }
    }
        
}
