using System;
using System.Windows.Forms;

namespace restaurant_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total;

        // ---------- MENYU (səbətə əlavə) ----------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Burger - 6.3");
            total += 6.3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tort - 4.5");
            total += 4.5;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çay - 1.5");
            total += 1.5;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hot-dog - 3.5");
            total += 3.5;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Limonad - 2.5");
            total += 2.5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Toyuq - 7.2");
            total += 7.2;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza - 8.9");
            total += 8.9;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cola - 2");
            total += 2;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Qızardılmış toyuq - 12.5");
            total += 12.5;
        }

        // ---------- SƏBƏTDƏN SİL ----------
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Silmək üçün əvvəlcə səbətdən yemək seç!");
                return;
            }

            string secilen = listBox1.SelectedItem.ToString();
            string ad = "";
            double qiymet = 0;

            if (secilen == "Burger - 6.3") { ad = "Burger"; qiymet = 6.3; }
            if (secilen == "Tort - 4.5") { ad = "Tort"; qiymet = 4.5; }
            if (secilen == "Çay - 1.5") { ad = "Çay"; qiymet = 1.5; }
            if (secilen == "Hot-dog - 3.5") { ad = "Hot-dog"; qiymet = 3.5; }
            if (secilen == "Limonad - 2.5") { ad = "Limonad"; qiymet = 2.5; }
            if (secilen == "Toyuq - 7.2") { ad = "Toyuq"; qiymet = 7.2; }
            if (secilen == "Pizza - 8.9") { ad = "Pizza"; qiymet = 8.9; }
            if (secilen == "Cola - 2") { ad = "Cola"; qiymet = 2; }
            if (secilen == "Qızardılmış toyuq - 12.5") { ad = "Qızardılmış toyuq"; qiymet = 12.5; }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            total -= qiymet;
            MessageBox.Show(ad + " səbətdən silindi");
        }

        // ---------- YENİLƏ ----------
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Xanalar sıfırlansınmı?", "Yenilə", MessageBoxButtons.YesNo);

            if (cavab == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                total = 0;
                textBox1.Clear();
                textBox2.Clear();
                lblQaliq.Text = "0";
            }
        }

        // ---------- YEKUN HESAB ----------
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
            }
            else
            {
                textBox2.Text = total.ToString();
            }
        }

        // ---------- HESABLA ----------
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Əvvəlcə Yekun hesab düyməsini bas!");
                return;
            }

            if (textBox1.Text == "")
            {
                MessageBox.Show("Məbləği daxil et!");
                return;
            }

            double mebleg = double.Parse(textBox1.Text);

            if (mebleg < total)
            {
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
            }
            else
            {
                lblQaliq.Text = Math.Round(mebleg - total, 2).ToString();
            }
        }

        // ---------- TƏMİZLƏ ----------
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            lblQaliq.Text = "0";
        }
    }
}