using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numerotxt.Text == "")
            {
                errorProvider.SetError(numerotxt, "Ingrese un valor");
                return;
            }
            errorProvider.Clear();
            string r1 = paroimpar(Convert.ToInt32(numerotxt.Text));
            string r2 = positivoonegativo(Convert.ToInt32(numerotxt.Text));
            MessageBox.Show("El numero ingresado es " + r1 + r2, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string paroimpar(int n1)
        {

            if ((n1%2)== 0)
            {
                return "par y ";
            }
            else
            {
                return "impar y ";
            }

        }

        private string positivoonegativo(int n1)
        {

            if (n1 >= 1)
            {
                return "positivo";
            }
            else if (n1 <= -1)
            {
                return "negativo";
            }

            return "";

        }



    }
}
