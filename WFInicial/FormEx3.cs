﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx3 : Form
    {
        public FormEx3()
        {
            InitializeComponent();
        }

        private void lblNum2_Click(object sender, EventArgs e)
        {

        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            int maior = Math.Max(num1, num2);

            string msg = $"o número {maior} é o maior";

            MessageBox.Show(msg, "Info", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
