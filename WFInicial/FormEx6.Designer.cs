namespace WFInicial
{
    partial class FormEx6
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
            lblValorHora = new Label();
            lblQuantHora = new Label();
            txtNome = new TextBox();
            txtValorHora = new TextBox();
            txtQuantHora = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(66, 58);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(106, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Digite o seu nome:";
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(66, 91);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(204, 15);
            lblValorHora.TabIndex = 1;
            lblValorHora.Text = "Digite o quanto você ganha por hora:";
            // 
            // lblQuantHora
            // 
            lblQuantHora.AutoSize = true;
            lblQuantHora.Location = new Point(66, 121);
            lblQuantHora.Name = "lblQuantHora";
            lblQuantHora.Size = new Size(250, 15);
            lblQuantHora.TabIndex = 2;
            lblQuantHora.Text = "Digite o número de horas trabalhadas no mês:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(178, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(316, 23);
            txtNome.TabIndex = 3;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(276, 88);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(218, 23);
            txtValorHora.TabIndex = 4;
            // 
            // txtQuantHora
            // 
            txtQuantHora.Location = new Point(322, 118);
            txtQuantHora.Name = "txtQuantHora";
            txtQuantHora.Size = new Size(172, 23);
            txtQuantHora.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(322, 176);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(172, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 242);
            Controls.Add(btnCalcular);
            Controls.Add(txtQuantHora);
            Controls.Add(txtValorHora);
            Controls.Add(txtNome);
            Controls.Add(lblQuantHora);
            Controls.Add(lblValorHora);
            Controls.Add(lblNome);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblValorHora;
        private Label lblQuantHora;
        private TextBox txtNome;
        private TextBox txtValorHora;
        private TextBox txtQuantHora;
        private Button btnCalcular;
    }
}