﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            this.SplashScreenTimer.Enabled = true;
            Program.Forms[FormName.BMICalculatorForm.ToString()].Show();
            this.Hide();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            this.SplashScreenTimer.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
