using System;
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
            try
            {
                double price = System.Convert.ToDouble(this.priceTextBox.Text);
                double rate = System.Convert.ToDouble(this.rateTextBox.Text);
                double resultInUZS = price * rate;
                resultLabel.Text = price.ToString("C") + " USD =" + resultInUZS.ToString() + " UZS";
            }
            catch
            {
                if(this.priceTextBox.Text=="" || this.rateTextBox.Text == "")
                {
                    MessageBox.Show("You have to fill both fields", "Converter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") &&(priceTextBox.Text.IndexOf(",")==-1)))
                    e.Handled = true;
            }
        }

        private void rateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (rateTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }
    }
}
