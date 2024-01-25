using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int sum = num1 + num2;
            //MessageBox.Show("Addition is "+sum.ToString());
            label4.Text = "Addition result is "+sum.ToString();
            label4.Visible = true;
        }

        private void substractionbtn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int substraction = num1 - num2;
            label4.Text = "Substraction result is " + substraction.ToString();
            label4.Visible = true;
        }

        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int multiplication = num1 * num2;

            label4.Text = "Multiplication is "+multiplicationbtn.ToString();
        }

        private void divisionbtn_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int division = num1 / num2;

            label4.Text = "Division is " + division.ToString();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label4.Text = string.Empty;
           
        }
    }
}
