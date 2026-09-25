using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txtNumberOne.Text);
            double number2 = Convert.ToDouble(txtNumberTwo.Text);
            double result = 0;

            string command = cmbCommand.Text;

            if (command == "+")
            {
                result = number1 + number2;
            }
            else if (command == "-")
            {
                result = number1 - number2;
            }
            else if (command == "*")
            {
                result = number1 * number2;
            }
            else if (command == "/")
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    MessageBox.Show("Sıfıra bölmək olmaz!");
                    return;
                }
            }

            lblResult.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberOne.Text = "";
            txtNumberTwo.Text = "";
            cmbCommand.Text = "";
            lblResult.Text = "0";
        }
    }
}