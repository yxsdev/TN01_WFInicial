namespace WFInicial
{
    partial class FormEx1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNota1 = new Label();
            txtNota1 = new TextBox();
            btnCalcular = new Button();
            txtNota2 = new TextBox();
            lblNota2 = new Label();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(58, 37);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(42, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1";
            lblNota1.Click += label1_Click;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(128, 34);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 1;
            txtNota1.TextChanged += txtNota1_TextChanged_1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(128, 107);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(128, 63);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 3;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(58, 66);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(42, 15);
            lblNota2.TabIndex = 4;
            lblNota2.Text = "Nota 2";
            lblNota2.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 165);
            Controls.Add(lblNota2);
            Controls.Add(txtNota2);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota1);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Calcular Média da Nota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private TextBox txtNota1;
        private Button btnCalcular;
        private TextBox txtNota2;
        private Label lblNota2;
    }
}
