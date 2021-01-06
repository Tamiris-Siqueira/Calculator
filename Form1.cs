using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double total = 0;

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 9;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 6;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 3;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNumero.Text += 0;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "-";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "/";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "*";
        }

        private void btnLimpaT_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            int l = txtNumero.Text.Length - 1;
            if (l >= 0)
                txtNumero.Text = txtNumero.Text.Substring(0, l);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                total = Convert.ToDouble(new DataTable().Compute(txtNumero.Text, null));
                txtNumero.Text = total.ToString();
            }
            catch (System.Data.EvaluateException)
            {
                txtNumero.Text = "Erro.";
            }
            catch (System.Data.SyntaxErrorException)
            {
                txtNumero.Text = "Erro.";
            }

            if (total < 0)
                txtNumero.BackColor = Color.Red;
            else if (total == 0)
                txtNumero.BackColor = Color.Yellow;
            else
                txtNumero.BackColor = Color.Green;
        }
        private void btnVir_Click(object sender, EventArgs e)
        {
            txtNumero.Text += ".";
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
                txtNumero.BackColor = Color.White;
        }

        private void btnPorc_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "%";

        }

        public Form1()
        {
            InitializeComponent();
            txtNumero.Text = "";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            txtNumero.Text += "√";
        }
    }
}
