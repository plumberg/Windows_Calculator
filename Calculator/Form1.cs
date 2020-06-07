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
        private Double val = 0;
        private String oper = "";
        bool operActive = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(resultTextBox.Text == "0" || operActive==true)
            {
                resultTextBox.Clear();
            }
            Button button = (Button)sender;
            resultTextBox.Text += button.Text;
            showResLabel.Text = val + " " + oper;
        }

        private void button17_Click(object sender, EventArgs e)
        {
           // resultTextBox.Clear();
            resultTextBox.Text = "0";
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            oper = button.Text;
            operActive = true;
            val = Double.Parse(resultTextBox.Text);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            showResLabel.Text = "";
            switch (oper){
                case "+":
                    resultTextBox.Text = val + Double.Parse(resultTextBox.Text).ToString();
                    break;
                case "-":
                    Double min = val - Double.Parse(resultTextBox.Text);
                    resultTextBox.Text = min.ToString();
                    break;
                case "*":
                    Double mult = val * Double.Parse(resultTextBox.Text);
                    resultTextBox.Text = mult.ToString();
                    break;
                case "/":
                    Double div = val / Double.Parse(resultTextBox.Text);
                    resultTextBox.Text = div.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
