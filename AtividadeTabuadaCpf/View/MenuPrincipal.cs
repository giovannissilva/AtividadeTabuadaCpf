using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeTabuadaCpf.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            Tabuada.TelaTabuada tabuada = new Tabuada.TelaTabuada();
            tabuada.ShowDialog();
        }

        private void btnCPF_Click(object sender, EventArgs e)
        {
            CPF.TelaCPF cpf = new CPF.TelaCPF();
            cpf.ShowDialog();
        }
    }
}
