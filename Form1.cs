using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_OOP_
{
    public partial class Calculator : Form
    {
        Double val = 0;
        String text = "";
        bool operation_plus = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Output.Text == "0")||(operation_plus))
            {
                Output.Clear();
            }
            Button button = (Button)sender;
            Output.Text = Output.Text + button.Text;
        }       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
        }

        private void Operation_plus(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(Output.Text);
            operation_plus = true;
        }

        private void operation_sum(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+":
                    Output.Text = (val + Double.Parse(Output.Text)).ToString();
                    break;
                case "-":
                    Output.Text = (val - Double.Parse(Output.Text)).ToString();
                    break;
                case "*":
                    Output.Text = (val * Double.Parse(Output.Text)).ToString();
                    break;
                case "/":
                    Output.Text = (val / Double.Parse(Output.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_plus = false;
        }

        private void app_click(object sender, EventArgs e)
        {

        }
    }   
    }

