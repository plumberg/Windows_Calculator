using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(resultTextBox.Text == "0")
            {
                resultTextBox.Clear();
            }
            Button button = (Button)sender;
            resultTextBox.Text += button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
           // resultTextBox.Clear();
            resultTextBox.Text = "0";
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
          
        }
    }
}
