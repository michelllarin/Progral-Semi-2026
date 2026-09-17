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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace miPrimeraAplicacion
{
    public partial class btnLooo : Form
    {
        // Diccionario: unidad -> factor de conversión a METROS CUADRADOS (unidad base)
        private Dictionary<string, double> factoresAMetros = new Dictionary<string, double>
        {
            { "Pie Cuadrado", 0.092903 },
            { "Vara Cuadrada", 0.698896 },
            { "Yarda Cuadrada", 0.836127 },
            { "Metro Cuadrado", 1.0 },
            { "Tareas", 437.5 },
            { "Manzana", 6988.96 },
            { "Hectárea", 10000.0 }
        };
        public btnLooo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carga las unidades disponibles en ambos combos
            foreach (string unidad in factoresAMetros.Keys)
            {
                cmbDesde.Items.Add(unidad);
                cmbHasta.Items.Add(unidad);
            }

            // Selección por defecto
            cmbDesde.SelectedIndex = 0;
            cmbHasta.SelectedIndex = 3; // Metro Cuadrado
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // --- Validaciones ---
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor ingrese un valor a convertir.");
                return;
            }

            double valor;
            if (!double.TryParse(textBox1.Text, out valor))
            {
                MessageBox.Show("El valor ingresado no es un número válido.");
                return;
            }

            if (cmbDesde.SelectedItem == null || cmbHasta.SelectedItem == null)
            {
                MessageBox.Show("Seleccione la unidad de origen y destino.");
                return;
            }

            string unidadDesde = cmbDesde.SelectedItem.ToString();
            string unidadHasta = cmbHasta.SelectedItem.ToString();

            // --- Conversión ---
            // 1. Convertimos el valor de la unidad de origen a metros cuadrados (unidad base)
            double valorEnMetros = valor * factoresAMetros[unidadDesde];

            // 2. Convertimos de metros cuadrados a la unidad de destino
            double resultado = valorEnMetros / factoresAMetros[unidadHasta];

            lblResultado.Text = "Resultado: " + resultado.ToString("N4") + " " + unidadHasta;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        

            
        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSueldo_Click(object sender, EventArgs e)
        {

        }

        private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        
}
