namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string registeredUsername = "admin";
        private string registeredPassword = "admin123";

        public Form1()
        {
            InitializeComponent();

            textBox1.UseSystemPasswordChar = false;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = false;
            textBox4.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Zəhmət olmasa istifadəçi adı və şifrəni daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            registeredUsername = textBox3.Text;
            registeredPassword = textBox4.Text;

            MessageBox.Show("Qeydiyyat uğurla tamamlandı! İndi daxil ola bilərsiniz.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == registeredUsername && textBox2.Text == registeredPassword)
            {
                MessageBox.Show("Ad və parol düzgündür", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ad və ya parol səhvdir", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = !checkBox2.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
