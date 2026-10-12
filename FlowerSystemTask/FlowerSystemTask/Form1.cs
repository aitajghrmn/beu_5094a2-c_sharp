using System;
using System.Globalization;
using System.Windows.Forms;

namespace FlowerSystemTask
{
    public partial class Form1 : Form
    {
        // Toplam gəlir (bütün satışların cəmi)
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = total.ToString("0.00", CultureInfo.InvariantCulture) + " AZN";
            textBox1.Focus();
        }

        // Satış et düyməsi
        private void button1_Click(object sender, EventArgs e)
        {
            // maskedTextBox1 = Say, maskedTextBox2 = Qiymət
            // Mask və boşluq simvollarını təmizləyirik
            string ad = textBox1.Text.Trim();
            string sayText = maskedTextBox1.Text.Replace("_", "").Trim();
            string qiymetText = maskedTextBox2.Text.Replace("_", "").Trim().Replace(',', '.');

            // 1) Boşluq yoxlanışı
            if (string.IsNullOrWhiteSpace(ad)
                || string.IsNullOrWhiteSpace(sayText)
                || string.IsNullOrWhiteSpace(qiymetText)
                || qiymetText == ".")
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Say və qiymətin ədəd və müsbət olması yoxlanışı
            bool countOk = int.TryParse(sayText, out int count);
            bool priceOk = decimal.TryParse(qiymetText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price);

            if (countOk && priceOk && count > 0 && price > 0)
            {
                // 3) Yekun məbləğin hesablanması
                decimal result = count * price;

                // 4) Cədvələ (DataGridView) əlavə edilməsi
                dataGridView1.Rows.Add(
                    ad,
                    count.ToString(),
                    price.ToString("0.00", CultureInfo.InvariantCulture),
                    result.ToString("0.00", CultureInfo.InvariantCulture)
                );

                // 5) Toplam gəlirin yenilənməsi
                total += result;
                label5.Text = total.ToString("0.00", CultureInfo.InvariantCulture) + " AZN";

                // 6) Xanaların təmizlənməsi və fokusun bərpası
                textBox1.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Say və qiymət düzgün daxil edilməyib! Say tam ədəd olmalı, hər iki dəyər isə müsbət (> 0) olmalıdır.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Çıxış düyməsi
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Proqramdan çıxmaq istədiyinizə əminsinizmi?", "Çıxış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Dizayner üçün boş hadisə işləyicisi
        }
    }
}