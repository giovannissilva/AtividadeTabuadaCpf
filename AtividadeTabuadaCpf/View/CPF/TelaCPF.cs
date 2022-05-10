using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeTabuadaCpf.View.CPF
{
    public partial class TelaCPF : Form
    {
        public TelaCPF()
        {
            InitializeComponent();
        }
    private void validaCpf()
        {
            if (string.IsNullOrWhiteSpace(tbxCPF.Text))
            {
                MessageBox.Show("CPF É Obrigatório","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                tbxCPF.Focus();
                tbxCPF.SelectAll();
                return;
            }
            string cpfInformar = tbxCPF.Text.Replace(".", "").Replace("-", "");


            if(cpfInformar.Length != 11)
            {

                lblResultado.Text = "Informe seu CPF com 11 digitos.";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            string cpf = cpfInformar.Substring(0, 9);

            int soma = 0;
            int valorRef = 10;

            for (int i = 0; i <= 8; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }
            int dv1 = (int) soma % 11;

            if (dv1 < 2)
            {
                dv1 = 0;
            }
            else
            {
                dv1 = 11 - dv1;
            }
            if (!cpfInformar.Substring(9,1).Equals(dv1.ToString()))
            {
                lblResultado.Text = "Informe um CPF Válido.";
                lblResultado.ForeColor = Color.Red;
                return;
            }

            cpf = cpf + dv1.ToString();
            valorRef = 11;
            soma = 0;

            for (int i = 0; i <= 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
            }
            int dv2 = (int)soma % 11;

            if (dv2 < 2)
            {
                dv2 = 0;
            }
            else
            {
                dv2 = 11 - dv2;
            }

            if (!cpfInformar.Substring(10, 1).Equals(dv2.ToString()))
            {
                lblResultado.Text = "Informe um CPF Válido.";
                lblResultado.ForeColor = Color.Red;
                return;
            }
            else
            {
                lblResultado.Text = "CPF Válido";
                lblResultado.ForeColor = Color.Green;
                return;
            }

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            validaCpf();
        }

        private void tbxCPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
