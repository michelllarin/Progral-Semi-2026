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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
          Metros, Cm, Pulgadas, Pies, Varas, Yardas, Km, Millas
        */
        String[][] etiquetas =
        {
            new string[]{"Metros", "Cm", "Pulgadas", "Pies", "Varas", "Yardas", "Km", "Millas"},//Longuitud
            new string[]{"Dolar","Quetzal","Lempira","Cordobas","Colon CR","Peso Chil","Sol", "Boliviano","Peso Méx","Yen jan"},//Monedas
            new string[]{"Gramo","Tonelada","Kilogramo","Miligramo","Microgramo","Tonelada larga","Tonelada corta","Stone","Libra","Onza"},//Masa
            new string[]{"Litro","Galón estadounidense","Cuarto estadounidense","Pinta estadounidense","Taza americana oficial","Onza líquida estadounidense","Cucharada estadounidense","Cucharadita estadounidence","Metro cúbico","Mililitro","Galón imperial","Cuarto imperial","Pinta imperial","Taza imperial","Onza líquida imperial","Cucharada imperial","Cucharadita imperial","Pie cúbico","Pulgada cúbica"},//Volumen
            new string[]{"Bit", "Kilobit", "Megabit", "Gigabit", "Terabit", "Petabit", "Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte"},//Almacenamiento
            new string[]{"Segundos","Nanosegundo","Microsegundo","Milisegundo","Minuto","Hora","Día","Semana","Mes","Año","Década","Siglo"}//Tiempo
        };
        Double[][] valores = {
            new double[]{ 1, 100, 39.3701, 3.28084, 1.1963, 1.09361, 0.001, 0.000621371},
            new double[]{1, 7.63, 26.81, 36.80, 449.23, 925.93, 3.37, 11.58, 17.06, 159.61},
            new double[]{1, 1e-6, 0.001, 1000, 1e+6, 9.8421e-7, 1.1023e-6, 0.000157473, 0.00220462, 0.035274},
            new double[]{1, 0.264172, 1.05669, 2.11338, 4.16667, 33.814, 67.628, 202.884, 0.001, 1000, 0.219969, 0.879877, 1.75975, 3.51951, 35.1951, 56.3121, 168.936, 0.0353147, 61.0237},
            new double[]{1, 0.001, 1e-6, 1e-9, 1e-12, 1e-15, 0.125, 0.000125, 1.25e-7, 1.25e-10, 1.25e-13, 1.25e-16},
            new double[]{1, 1e+9, 1e+6, 1000, 0.0166667, 0.000277778, 1.1574e-5, 1.6534e-6, 3.8052e-7, 3.171e-8, 3.171e-9, 3.171e-10}
            };

        private void Form1_Load(object sender, EventArgs e) { 
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int de = cboDe.SelectedIndex, a = cboA.SelectedIndex, opcion = cboOpciones.SelectedIndex;
            double cantidad = Double.Parse(txtCantidad.Text);

            double respuesta = valores[opcion][a] / valores[opcion][de] * cantidad;

            lblRespuesta.Text = respuesta.ToString();
                   
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiamos los valores anteriores
            cboDe.Items.Clear();
            cboA.Items.Clear();
            //Asignamos los nuevos valores
            int opcion = cboOpciones.SelectedIndex;
            cboDe.Items.AddRange(etiquetas[opcion]);
            cboA.Items.AddRange(etiquetas[opcion]);
        }
    }
}
