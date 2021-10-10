﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double price = System.Convert.ToDouble(priceTextBox.Text);
            double rate = System.Convert.ToDouble(rateTextBox.Text);
            double resultInUZS = price * rate;
            resultLabel.Text =price.ToString("C")+ " USD ="+ resultInUZS.ToString() +" UZS";
        }
    }
}
