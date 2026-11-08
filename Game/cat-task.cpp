using System.Media;

namespace mina_tapma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Oyundan çıxış edilsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
        int ran;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random a = new Random();
            ran = a.Next(1, 7);
        }
        bool t = false;
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            ran = a.Next(1, 7);
            sum = 0;
            label2.Text = sum.ToString();
            if (t == false)
            {
                t = true;
                pictureBox1.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox2.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox3.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox4.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox5.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox6.ImageLocation = "H:\\C#\\img\\sual.png";
            }
            else
            {
                t = false;
                pictureBox1.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox2.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox3.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox4.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox5.ImageLocation = "H:\\C#\\img\\sual.png";
                pictureBox6.ImageLocation = "H:\\C#\\img\\sual.png";
            }
        }
        SoundPlayer s = new SoundPlayer("H:\\C#\\img\\explosion.wav");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ran == 1)
            {
                sum = 0;
                pictureBox1.ImageLocation = "H:\\C#\\img\\bomba.png";
                s.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün OK düyməsinə bas", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                sum++;
                pictureBox1.ImageLocation = "H:\\C#\\img\\cat.png";
            }
            if (sum == 5)
            {
                MessageBox.Show("OYUNU QAZANDINIZ");
            }
            label2.Text = sum.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ran == 2)
            {
                sum = 0;
                pictureBox2.ImageLocation = "H:\\C#\\img\\bomba.png";
                s.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün OK düyməsinə bas", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                sum++;
                pictureBox2.ImageLocation = "H:\\C#\\img\\cat.png";
            }
            if (sum == 5)
            {
                MessageBox.Show("OYUNU QAZANDINIZ");
            }
            label2.Text = sum.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ran == 3)
            {
                sum = 0;
                pictureBox3.ImageLocation = "H:\\C#\\img\\bomba.png";
                s.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün OK düyməsinə bas", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                sum++;
                pictureBox3.ImageLocation = "H:\\C#\\img\\cat.png";
            }
            if (sum == 5)
            {
                MessageBox.Show("OYUNU QAZANDINIZ");
            }
            label2.Text = sum.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (ran == 4)
            {
                sum = 0;
                pictureBox4.ImageLocation = "H:\\C#\\img\\bomba.png";
                s.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün OK düyməsinə bas", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                sum++;
                pictureBox4.ImageLocation = "H:\\C#\\img\\cat.png";
            }
            if (sum == 5)
            {
                MessageBox.Show("OYUNU QAZANDINIZ");
            }
            label2.Text = sum.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (ran == 5)
            {
                sum = 0;
                pictureBox5.ImageLocation = "H:\\C#\\img\\bomba.png";
                s.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün OK düyməsinə bas", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                sum++;
                pictureBox5.ImageLocation = "H:\\C#\\img\\cat.png";
            }
            if (sum == 5)
            {
                MessageBox.Show("OYUNU QAZANDINIZ");
            }
            label2.Text = sum.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (ran == 6)
            {
                sum = 0;
                pictureBox6.ImageLocation = "H:\\C#\\img\\bomba.png";
                s.Play();
                DialogResult d = MessageBox.Show("Oyun bitdi, Yeni oyun üçün OK düyməsinə bas", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (d == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                sum++;
                pictureBox6.ImageLocation = "H:\\C#\\img\\cat.png";
            }
            if (sum == 5)
            {
                MessageBox.Show("OYUNU QAZANDINIZ");
            }
            label2.Text = sum.ToString();
        }
    }
}
