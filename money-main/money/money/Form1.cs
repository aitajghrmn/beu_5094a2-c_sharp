namespace money
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Xananın boş olmasını ErrorProvider ilə yoxlamaq
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Məbləğ daxil edin");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            // 2. Rəqəm olub-olmadığını yoxlamaq
            if (!int.TryParse(textBox1.Text, out int mebleg))
            {
                MessageBox.Show("Zəhmət olmasa düzgün rəqəm daxil edin!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Mənfi və ya sıfır məbləğ yoxlanışı
            if (mebleg <= 0)
            {
                MessageBox.Show("Mənfi və ya sıfır məbləğ xırdalanmaz", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bütün şəkil və label-ləri əvvəlcə gizlədək
            pictureBox1.Visible = false; label1.Visible = false;
            pictureBox2.Visible = false; label2.Visible = false;
            pictureBox3.Visible = false; label3.Visible = false;
            pictureBox4.Visible = false; label4.Visible = false;
            pictureBox8.Visible = false; label5.Visible = false;
            pictureBox7.Visible = false; label6.Visible = false;
            pictureBox6.Visible = false; label7.Visible = false;
            pictureBox5.Visible = false; label8.Visible = false;

            // 4. Əskinasların hesablanması
            int a500 = mebleg / 500; mebleg %= 500;
            int a200 = mebleg / 200; mebleg %= 200;
            int a100 = mebleg / 100; mebleg %= 100;
            int a50 = mebleg / 50; mebleg %= 50;
            int a20 = mebleg / 20; mebleg %= 20;
            int a10 = mebleg / 10; mebleg %= 10;
            int a5 = mebleg / 5; mebleg %= 5;
            int a1 = mebleg;

            // 5. Nəticələrin göstərilməsi
            if (a500 > 0) { pictureBox5.Visible = true; label8.Visible = true; label8.Text = $"{a500} ədəd 500"; }
            if (a200 > 0) { pictureBox6.Visible = true; label7.Visible = true; label7.Text = $"{a200} ədəd 200"; }
            if (a100 > 0) { pictureBox7.Visible = true; label6.Visible = true; label6.Text = $"{a100} ədəd 100"; }
            if (a50 > 0) { pictureBox8.Visible = true; label5.Visible = true; label5.Text = $"{a50} ədəd 50"; }
            if (a20 > 0) { pictureBox4.Visible = true; label4.Visible = true; label4.Text = $"{a20} ədəd 20"; }
            if (a10 > 0) { pictureBox3.Visible = true; label3.Visible = true; label3.Text = $"{a10} ədəd 10"; }
            if (a5 > 0) { pictureBox2.Visible = true; label2.Visible = true; label2.Text = $"{a5} ədəd 5"; }
            if (a1 > 0) { pictureBox1.Visible = true; label1.Visible = true; label1.Text = $"{a1} ədəd 1"; }
        }
    }
}