﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2SavarankiskasDarbas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ttbVardas.Text == "")
            {
                MessageBox.Show("Ivesti varda");
                return;
            }
            tbOutput.Text = $"{ttbVardas.Text}";
            tbOutput.AppendText($"\r\n{DateTime.Now}");
        }
    }
        
}
