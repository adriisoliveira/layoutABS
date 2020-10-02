namespace InterfaceAbs
{
    partial class frmPreparacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtResumoPedido = new System.Windows.Forms.TextBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnPronto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESUMO DO PEDIDO PARA PREPARAÇÃO";
            // 
            // txtResumoPedido
            // 
            this.txtResumoPedido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResumoPedido.Location = new System.Drawing.Point(11, 65);
            this.txtResumoPedido.Multiline = true;
            this.txtResumoPedido.Name = "txtResumoPedido";
            this.txtResumoPedido.Size = new System.Drawing.Size(412, 78);
            this.txtResumoPedido.TabIndex = 1;
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(11, 167);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(164, 36);
            this.btnCancela.TabIndex = 2;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnPronto
            // 
            this.btnPronto.Location = new System.Drawing.Point(259, 167);
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Size = new System.Drawing.Size(164, 36);
            this.btnPronto.TabIndex = 3;
            this.btnPronto.Text = "Pedido Pronto";
            this.btnPronto.UseVisualStyleBackColor = true;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click);
            // 
            // frmPreparacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 223);
            this.Controls.Add(this.btnPronto);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.txtResumoPedido);
            this.Controls.Add(this.label1);
            this.Name = "frmPreparacao";
            this.Text = "Preparação do Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResumoPedido;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnPronto;
    }
}