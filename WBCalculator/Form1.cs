using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e) => screen.Text += "1";

        private void number2_Click(object sender, EventArgs e) => screen.Text += "2";

        private void number3_Click(object sender, EventArgs e) => screen.Text += "3";

        private void number4_Click(object sender, EventArgs e) => screen.Text += "4";

        private void number5_Click(object sender, EventArgs e) => screen.Text += "5";

        private void number6_Click(object sender, EventArgs e) => screen.Text += "6";

        private void number7_Click(object sender, EventArgs e) => screen.Text += "7";

        private void number8_Click(object sender, EventArgs e) => screen.Text += "8";

        private void number9_Click(object sender, EventArgs e) => screen.Text += "9";

        private void number0_Click(object sender, EventArgs e) => screen.Text += "0";

        private void plus_Click(object sender, EventArgs e) => screen.Text += "+";

        private void minus_Click(object sender, EventArgs e) => screen.Text += "-";

        private void multiply_Click(object sender, EventArgs e) => screen.Text += "*";

        private void divide_Click(object sender, EventArgs e) => screen.Text += "/";

        private void clear_Click(object sender, EventArgs e) => screen.Text = "";

        private void back_Click(object sender, EventArgs e) => screen.Text = screen.Text.Remove(screen.TextLength - 1);

        private void calculate_Click(object sender, EventArgs e)
        {
            //Implement sqrt - or find is it in Compute method
            //Implement power as python '**'
            //Multiple equasion - step by step
            if (screen.Text.Contains("="))
            {
                string secondPart = screen.Text.Split('=')[1];
                string result = new DataTable().Compute(secondPart, null).ToString();
                screen.Text = secondPart + "=" + result;
            }
            else
            {
                string result = new DataTable().Compute(screen.Text, null).ToString();
                screen.Text = screen.Text + "=" + result;
            }
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (screen.Text.StartsWith("-"))
            {
                screen.Text = screen.Text.Substring(1);
            }
            else
            {
                screen.Text = "-" + screen.Text;
            }
        }

        private void comma_Click(object sender, EventArgs e) => screen.Text += ".";
    }
}
