namespace IDCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Ancaq jpg faylları *.jpg | *.jpg";
            op.ShowDialog();
            pictureBox1.ImageLocation = op.FileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label22.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label21.Text = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label5.Text = textBox4.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label6.Text = textBox3.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label8.Text = textBox6.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label11.Text = textBox5.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label7.Text = textBox8.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label12.Text = textBox7.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            label18.Text = textBox10.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            label15.Text = textBox12.Text;
        }

        private void label17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label17.Text = textBox11.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            dateTimePicker1.Text = "";
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox8.Text) ||
                string.IsNullOrEmpty(textBox10.Text) ||
                string.IsNullOrEmpty(textBox11.Text) ||
                string.IsNullOrEmpty(textBox12.Text))
            {
                progressBar1.Visible = true;
                MessageBox.Show("Məlumatlar tam deyil", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                progressBar1.Visible = true;
                SaveFileDialog sv = new SaveFileDialog();
                sv.Filter = "All file . | .";
                sv.FileName = "Document";
                File.CreateText(sv.FileName).Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value+= 10;
            if (progressBar1.Value >= 100)
            {
                progressBar1.Visible = false;
                timer1.Stop();
            }
           
        }
    }
}
