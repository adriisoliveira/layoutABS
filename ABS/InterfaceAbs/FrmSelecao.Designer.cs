namespace InterfaceAbs
{
    partial class FrmSelecaoDeBebidas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInicial = new System.Windows.Forms.Label();
            this.pnlBebidas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLaranja = new System.Windows.Forms.Button();
            this.btnUva = new System.Windows.Forms.Button();
            this.btnGuarana = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.pnlGelo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSGelo = new System.Windows.Forms.Button();
            this.btnCGelo = new System.Windows.Forms.Button();
            this.pnlConsumo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.btnViagem = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblResumo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrande = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnPequeno = new System.Windows.Forms.Button();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.pnlBebidas.SuspendLayout();
            this.pnlGelo.SuspendLayout();
            this.pnlConsumo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Font = new System.Drawing.Font("Moon Cheese", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.Location = new System.Drawing.Point(46, 9);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(580, 48);
            this.lblInicial.TabIndex = 0;
            this.lblInicial.Text = "Selecione o Pedido:";
            // 
            // pnlBebidas
            // 
            this.pnlBebidas.Controls.Add(this.label1);
            this.pnlBebidas.Controls.Add(this.btnLaranja);
            this.pnlBebidas.Controls.Add(this.btnUva);
            this.pnlBebidas.Controls.Add(this.btnGuarana);
            this.pnlBebidas.Controls.Add(this.btnCoca);
            this.pnlBebidas.Location = new System.Drawing.Point(13, 72);
            this.pnlBebidas.Name = "pnlBebidas";
            this.pnlBebidas.Size = new System.Drawing.Size(671, 74);
            this.pnlBebidas.TabIndex = 1;
            this.pnlBebidas.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bebida:";
            // 
            // btnLaranja
            // 
            this.btnLaranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaranja.Location = new System.Drawing.Point(514, 22);
            this.btnLaranja.Name = "btnLaranja";
            this.btnLaranja.Size = new System.Drawing.Size(140, 34);
            this.btnLaranja.TabIndex = 3;
            this.btnLaranja.Text = "Suco de Laranja";
            this.btnLaranja.UseVisualStyleBackColor = true;
            this.btnLaranja.Click += new System.EventHandler(this.btnLaranja_Click);
            // 
            // btnUva
            // 
            this.btnUva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUva.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUva.Location = new System.Drawing.Point(346, 22);
            this.btnUva.Name = "btnUva";
            this.btnUva.Size = new System.Drawing.Size(140, 34);
            this.btnUva.TabIndex = 2;
            this.btnUva.Text = "Suco de Uva";
            this.btnUva.UseVisualStyleBackColor = true;
            this.btnUva.Click += new System.EventHandler(this.btnUva_Click);
            // 
            // btnGuarana
            // 
            this.btnGuarana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuarana.Location = new System.Drawing.Point(175, 22);
            this.btnGuarana.Name = "btnGuarana";
            this.btnGuarana.Size = new System.Drawing.Size(140, 34);
            this.btnGuarana.TabIndex = 1;
            this.btnGuarana.Text = "Guaraná";
            this.btnGuarana.UseVisualStyleBackColor = true;
            this.btnGuarana.Click += new System.EventHandler(this.btnGuarana_Click);
            // 
            // btnCoca
            // 
            this.btnCoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoca.Location = new System.Drawing.Point(14, 22);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(140, 34);
            this.btnCoca.TabIndex = 0;
            this.btnCoca.Text = "Coca-Cola";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.btnCoca_Click);
            // 
            // pnlGelo
            // 
            this.pnlGelo.Controls.Add(this.label2);
            this.pnlGelo.Controls.Add(this.btnSGelo);
            this.pnlGelo.Controls.Add(this.btnCGelo);
            this.pnlGelo.Location = new System.Drawing.Point(13, 164);
            this.pnlGelo.Name = "pnlGelo";
            this.pnlGelo.Size = new System.Drawing.Size(671, 77);
            this.pnlGelo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gelo:";
            // 
            // btnSGelo
            // 
            this.btnSGelo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSGelo.Location = new System.Drawing.Point(370, 21);
            this.btnSGelo.Name = "btnSGelo";
            this.btnSGelo.Size = new System.Drawing.Size(284, 41);
            this.btnSGelo.TabIndex = 1;
            this.btnSGelo.Text = "Sem Gelo";
            this.btnSGelo.UseVisualStyleBackColor = true;
            this.btnSGelo.Click += new System.EventHandler(this.btnSGelo_Click);
            // 
            // btnCGelo
            // 
            this.btnCGelo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCGelo.Location = new System.Drawing.Point(14, 21);
            this.btnCGelo.Name = "btnCGelo";
            this.btnCGelo.Size = new System.Drawing.Size(284, 41);
            this.btnCGelo.TabIndex = 0;
            this.btnCGelo.Text = "Com Gelo";
            this.btnCGelo.UseVisualStyleBackColor = true;
            this.btnCGelo.Click += new System.EventHandler(this.btnCGelo_Click);
            // 
            // pnlConsumo
            // 
            this.pnlConsumo.Controls.Add(this.label3);
            this.pnlConsumo.Controls.Add(this.btnRestaurante);
            this.pnlConsumo.Controls.Add(this.btnViagem);
            this.pnlConsumo.Location = new System.Drawing.Point(13, 347);
            this.pnlConsumo.Name = "pnlConsumo";
            this.pnlConsumo.Size = new System.Drawing.Size(671, 73);
            this.pnlConsumo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consumo:";
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurante.Location = new System.Drawing.Point(370, 22);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(284, 34);
            this.btnRestaurante.TabIndex = 1;
            this.btnRestaurante.Text = "Consumo no Restaurante";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
            // 
            // btnViagem
            // 
            this.btnViagem.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViagem.Location = new System.Drawing.Point(14, 22);
            this.btnViagem.Name = "btnViagem";
            this.btnViagem.Size = new System.Drawing.Size(284, 34);
            this.btnViagem.TabIndex = 0;
            this.btnViagem.Text = "Para Viagem";
            this.btnViagem.UseVisualStyleBackColor = true;
            this.btnViagem.Click += new System.EventHandler(this.btnViagem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(13, 532);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 44);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(267, 532);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(168, 44);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(516, 532);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(168, 44);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPedido);
            this.panel1.Controls.Add(this.lblResumo);
            this.panel1.Location = new System.Drawing.Point(13, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 70);
            this.panel1.TabIndex = 7;
            // 
            // txtPedido
            // 
            this.txtPedido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPedido.Location = new System.Drawing.Point(14, 21);
            this.txtPedido.Multiline = true;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(640, 35);
            this.txtPedido.TabIndex = 7;
            // 
            // lblResumo
            // 
            this.lblResumo.AutoSize = true;
            this.lblResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumo.Location = new System.Drawing.Point(-1, 0);
            this.lblResumo.Name = "lblResumo";
            this.lblResumo.Size = new System.Drawing.Size(155, 18);
            this.lblResumo.TabIndex = 6;
            this.lblResumo.Text = "Resumo do pedido:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGrande);
            this.panel2.Controls.Add(this.btnMedio);
            this.panel2.Controls.Add(this.btnPequeno);
            this.panel2.Controls.Add(this.lblTamanho);
            this.panel2.Location = new System.Drawing.Point(12, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 64);
            this.panel2.TabIndex = 8;
            // 
            // btnGrande
            // 
            this.btnGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrande.Location = new System.Drawing.Point(475, 18);
            this.btnGrande.Name = "btnGrande";
            this.btnGrande.Size = new System.Drawing.Size(179, 29);
            this.btnGrande.TabIndex = 9;
            this.btnGrande.Text = "Grande  - 700ml";
            this.btnGrande.UseVisualStyleBackColor = true;
            this.btnGrande.Click += new System.EventHandler(this.btnGrande_Click);
            // 
            // btnMedio
            // 
            this.btnMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.Location = new System.Drawing.Point(243, 21);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(179, 29);
            this.btnMedio.TabIndex = 8;
            this.btnMedio.Text = "Médio - 500ml";
            this.btnMedio.UseVisualStyleBackColor = true;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            // 
            // btnPequeno
            // 
            this.btnPequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPequeno.Location = new System.Drawing.Point(14, 21);
            this.btnPequeno.Name = "btnPequeno";
            this.btnPequeno.Size = new System.Drawing.Size(179, 29);
            this.btnPequeno.TabIndex = 7;
            this.btnPequeno.Text = "Pequeno - 300ml";
            this.btnPequeno.UseVisualStyleBackColor = true;
            this.btnPequeno.Click += new System.EventHandler(this.btnPequeno_Click);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(-3, 0);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(83, 18);
            this.lblTamanho.TabIndex = 6;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // FrmSelecaoDeBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlConsumo);
            this.Controls.Add(this.pnlGelo);
            this.Controls.Add(this.pnlBebidas);
            this.Controls.Add(this.lblInicial);
            this.Name = "FrmSelecaoDeBebidas";
            this.Text = "Seleção de Bebidas";
            this.pnlBebidas.ResumeLayout(false);
            this.pnlBebidas.PerformLayout();
            this.pnlGelo.ResumeLayout(false);
            this.pnlGelo.PerformLayout();
            this.pnlConsumo.ResumeLayout(false);
            this.pnlConsumo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Panel pnlBebidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLaranja;
        private System.Windows.Forms.Button btnUva;
        private System.Windows.Forms.Button btnGuarana;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Panel pnlGelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSGelo;
        private System.Windows.Forms.Button btnCGelo;
        private System.Windows.Forms.Panel pnlConsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Button btnViagem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblResumo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGrande;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnPequeno;
        private System.Windows.Forms.Label lblTamanho;
    }
}

