using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeTabuadaCpf.View.Tabuada
{
    public partial class TelaTabuada : Form
    {
        public TelaTabuada()
        {
            InitializeComponent();
        }
        private void CalcularTabuada()
        {
            int fabiano = 0;

            fabiano = Convert.ToInt32(tbxNumero.Text);

            for (int i = 0; i <= 10; i++)
            {
               lbxResultado.Items.Add(fabiano + "x" + i + "=" + fabiano* i); 
            }
            tbxNumero.Focus();
            tbxNumero.SelectAll();
        }
        private void LimparTela()
        {
            lbxResultado.Items.Clear();
            tbxNumero.Clear();
            tbxNumero.Focus();
        }

        private void TelaTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNumero.Text))
            {
                MessageBox.Show("Digite um número válido");
                tbxNumero.Focus();
                tbxNumero.SelectAll();
                return;
            }
            else
            {
                if (e.KeyChar == 13)
                {
                    CalcularTabuada();
                }
                if (e.KeyChar == 27)
                {
                    LimparTela();
                }
            }
        }
    }
}
