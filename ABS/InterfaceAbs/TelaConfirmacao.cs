using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceAbs
{
    public partial class telaConfirmação : Form
    {
        FrmSelecaoDeBebidas selecao = new FrmSelecaoDeBebidas();
        public telaConfirmação()
        {
            InitializeComponent();
        }

        public telaConfirmação(string valor)
        {
            InitializeComponent();
            txtConfirmacao.Text = valor;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
