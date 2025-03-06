namespace WFInicial
{
    partial class FormEx7
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
            lblNome = new Label();
            txtNomeProduto = new TextBox();
            txtValorProduto = new TextBox();
            lblValor1 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(82, 81);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(89, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Produto:";
            lblNome.Click += lblNome1_Click;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(195, 78);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(113, 23);
            txtNomeProduto.TabIndex = 6;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(195, 107);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(113, 23);
            txtValorProduto.TabIndex = 12;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new Point(82, 107);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(36, 15);
            lblValor1.TabIndex = 18;
            lblValor1.Text = "Valor:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(195, 155);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(113, 23);
            btnCalcular.TabIndex = 24;
            btnCalcular.Text = "Cadastrar";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 275);
            Controls.Add(btnCalcular);
            Controls.Add(lblValor1);
            Controls.Add(txtValorProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNome);
            Name = "FormEx7";
            Text = "FormEx7";
            Load += FormEx7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNomeProduto;
        private TextBox txtValorProduto;
        private Label lblValor1;
        private Button btnCalcular;
    }
}