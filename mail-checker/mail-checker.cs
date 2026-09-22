using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace mailchecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string email = textBox1.Text;

                if (email == "")
                {
                    MessageBox.Show("Uğursuz: Xahiş olunur e-poçt ünvanını daxil edin!");
                    checkBox1.Checked = false;
                }
                else if (email.Contains("@") == false)
                {
                    MessageBox.Show("Uğursuz: E-poçt ünvanında '@' simvolu olmalıdır!");
                    checkBox1.Checked = false;
                }
                else if (email.EndsWith("@gmail.com") == false &&
                         email.EndsWith("@mail.ru") == false &&
                         email.EndsWith("@outlook.com") == false &&
                         email.EndsWith("@yahoo.com") == false)
                {
                    MessageBox.Show("Uğursuz: E-poçt @gmail.com, @mail.ru, @outlook.com və ya @yahoo.com ilə bitməlidir!");
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("Uğurlu: E-poçt ünvanı qaydalara uyğundur!");
                }
            }
        }
    }
}
