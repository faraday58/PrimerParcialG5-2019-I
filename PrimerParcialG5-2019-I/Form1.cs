using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrimerParcialG5_2019_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            SumaElemento sumaElemento = new SumaElemento();
            try
            {
                float[] arreglo = sumaElemento.Leer(txtbSumar.Text);
                float suma = 0;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    suma += arreglo[i];
                }
                lbSumar.Text = suma.ToString();
            }
            catch( FormatException error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprime imprime = new Imprime();

            imprime.Leer(txtbImprimir.Text);
            if(rdbIngresado.Checked  )
            {
              lbImprimir.Text =  imprime.Ingresado();
            }
            if(rdbInverso.Checked)
            {
                lbImprimir.Text = imprime.Inverso();
            }
            if(rdbPar.Checked)
            {
                lbImprimir.Text = imprime.Par();
            }


        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            float [] calficaciones=alumno.Leer(txtbPromediar.Text);
            alumno.Promedio();
            lbPromediar.Text = alumno.ToString();
        }
    }
}
