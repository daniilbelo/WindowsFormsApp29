using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp29
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private string action = " ";
        private bool hasZero = false;
        private bool hasComma = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_numbers_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0") && !hasZero && !hasComma)
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }

            textBox1.Text += ((Button)sender).Text;
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Double.Parse(textBox1.Text);
                action = ((Button)sender).Text;
                textBox1.Clear();
                hasZero = false;
                hasComma = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = double.Parse(textBox1.Text);
                switch (action)
                {
                    case "+":
                        textBox1.Text = (num1 + num2).ToString();
                        break;
                    case "-":
                        textBox1.Text = (num1 - num2).ToString();
                        break;
                    case "*":
                        textBox1.Text = (num1 * num2).ToString();
                        break;
                    case "/":
                        textBox1.Text = (num1 / num2).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = 0;
            num2 = 0;
            hasZero = false;
            hasComma = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Split(',').Length - 1 >= 1 || hasComma)
            {
                return;
            }

            textBox1.Text = textBox1.Text + ",";
            hasComma = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
