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
    public partial class frmPreparacao : Form
    {
        FrmSelecaoDeBebidas selecao = new FrmSelecaoDeBebidas();


        public frmPreparacao()
        {
            InitializeComponent();
        }
        public frmPreparacao(string valor)
        {
            InitializeComponent();
            txtResumoPedido.Text = valor;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja confirmar?");
            MessageBox.Show("Pedido pronto!");
            Application.Exit();
        }

        
    }
}
