using System.Diagnostics.CodeAnalysis;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            String[] serie = txtSerie.Text.Split(',');
            double[] miSerie = serie.Select(n => double.Parse(n)).ToArray();
            double suma = 0;
            for (int i = 0; i < serie.Length; i++)
                suma += miSerie[i];

        }
          double media = Suma / miSerie.Length;
        ltsValores.Items.Add("La media es:" + media); 
            //Tarea: La media armonica.
        }
    }

