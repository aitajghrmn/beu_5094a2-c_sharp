
using System;
using System.Globalization;
using System.Windows.Forms;

namespace FlowerSystemTask
{
    public partial class Form1 : Form
    {
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = total.ToString("F2") + " AZN";
            Text = "Gül Satış Sistemi - Cəmi: 0.00 AZN";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sayText = maskedTextBox1.Text.Replace("_", "");
            string qiymetText = maskedTextBox2.Text.Replace("_", "").Replace(',', '.');

            if (string.IsNullOrWhiteSpace(textBox1.Text)
                || string.IsNullOrWhiteSpace(sayText)
                || string.IsNullOrWhiteSpace(qiymetText)
                || qiymetText == ".")
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!", "Xəta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool countOk = int.TryParse(sayText, out int count);
            bool priceOk = decimal.TryParse(qiymetText, out decimal price);

            if (countOk && priceOk && count > 0 && price > 0)
            {
                
                if ((price * 100) % 1 != 0)
                {
                    MessageBox.Show("Qiymətdə vergüldən sonra ən çox 2 rəqəm daxil edilə bilər!", "Xəta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal result = count * price;

                dataGridView1.Rows.Add(textBox1.Text, count.ToString(), price.ToString("F2"), result.ToString("F2"));

                total += result;
                label5.Text = total.ToString("F2") + " AZN";
                Text = "Cəmi: " + total.ToString("F2") + " AZN";

                textBox1.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Say və qiymət düzgün daxil edilməyib! Say tam ədəd olmalı, hər iki dəyər isə müsbət (> 0) olmalıdır.",
                    "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proqramdan çıxmaq istədiyinizə əminsinizmi?", "Çıxış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Close();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Say";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.IsBalloon = true;
            toolTip1.Show("Yalnız rəqəm daxil edə bilərsiniz!", maskedTextBox1, 0, -20, 2000);
        }
    }
}
