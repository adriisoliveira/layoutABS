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
    public partial class FrmSelecaoDeBebidas : Form
    {
        string bebida = "";
        string gelo = "";
        string qntGelo = "";
        string consumo = "";
        string copo = "";
        string tampa = "";
        string tamanho = "";
       
        
        

        public FrmSelecaoDeBebidas()
        {
            InitializeComponent();

        }

        private void btnCoca_Click(object sender, EventArgs e)
        {
            bebida = "Coca-Cola";
            copo = "Papel";
            txtPedido.Text = "Coca-Cola";
        }

        private void btnGuarana_Click(object sender, EventArgs e)
        {
            bebida = "Guaraná";
            copo = "Papel";
            txtPedido.Text = "Guaraná";
        }

        private void btnUva_Click(object sender, EventArgs e)
        {
            bebida = "Suco de Uva";
            copo = "Plástico";
            txtPedido.Text = "Suco de Uva";
        }

        private void btnLaranja_Click(object sender, EventArgs e)
        {
            bebida = "Suco de Laranja";
            copo = "Plástico";
            txtPedido.Text = "Suco de laranja";
        }

        private void btnCGelo_Click(object sender, EventArgs e)
        {
            if (bebida == "Coca-Cola" || bebida == "Guraná")
            {
                gelo = "Com gelo";
                qntGelo = "6";
            }
            else if (bebida == "Suco de uva" || bebida == "Suco de Laranja")
            {
                gelo = "Com gelo";
                qntGelo = "12";
            }
            txtPedido.Text = bebida + " || " + gelo;
        }

        private void btnSGelo_Click(object sender, EventArgs e)
        {
            gelo = "Sem gelo";
            qntGelo = "0";
            txtPedido.Text = bebida + " || " + gelo;
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            consumo = "Consumo Delivery";
            tampa = "Tampa TakeOut - Viagem";
            txtPedido.Text = bebida + " || " + gelo + " || " + tamanho + " || " + consumo + " || ";
        }

        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            consumo = "Consumo no restaurante";
            tampa = " Tampa EatIn - restaurante";
            txtPedido.Text = bebida + " || " + gelo + " || " + tamanho + " || " + consumo + " || ";
        }

        private void btnPequeno_Click(object sender, EventArgs e)
        {
            tamanho = "Pequeno - 300ml";
            txtPedido.Text = bebida + " || " + gelo + " || " + consumo + " || " + tamanho;
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            tamanho = "Medio - 500ml";
            txtPedido.Text = bebida + " || " + gelo + " || " + consumo + " || " + tamanho;
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            tamanho = "Grande - 700ml";
            txtPedido.Text = bebida + " || " + gelo + " || " + consumo + " || " + tamanho;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPedido.Clear();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Confirmação de Pedido: " + bebida + " || "+ gelo 
            + "Pedras de gelo: " + qntGelo + " || " 
            + consumo + " || " + tampa 
            + " || " + tamanho);

            txtPedido.Text = copo + " || " + tamanho + " || " + bebida + " || " + gelo + " || " + qntGelo + " || " + tampa + " || " + consumo;
            
            telaConfirmação confirmacao = new telaConfirmação(txtPedido.Text);
            txtPedido.Clear();
            confirmacao.Show();
            this.Hide();
        }


        /*public String [] Retorno()
        {
            string[] bebidaPreparada;
            bebidaPreparada = new string[7];

            bebidaPreparada[0] = copo;
            bebidaPreparada[1] = tamanho;
            bebidaPreparada[2] = bebida;
            bebidaPreparada[3] = gelo;
            bebidaPreparada[4] = qntGelo;
            bebidaPreparada[5] = tampa;
            bebidaPreparada[6] = consumo;

            return bebidaPreparada[] ;
        }*/

    }
}
