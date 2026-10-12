
//using System;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace FlowerSystemTask
//{
//    public partial class Form1 : Form
//    {
//        private decimal total = 0m;

//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            Text = "Cəmi: 0.00 AZN";
//            textBox1.Focus();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string sayText = maskedTextBox1.Text.Replace("_", "").Trim();
//            string qiymetText = maskedTextBox2.Text.Replace("_", "").Trim();

//            if (string.IsNullOrWhiteSpace(textBox1.Text)
//                || string.IsNullOrWhiteSpace(sayText)
//                || string.IsNullOrWhiteSpace(qiymetText))
//            {
//                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!", "Xəta",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            else
//            {
//                bool countOk = int.TryParse(sayText, out int count);
//                bool priceOk = decimal.TryParse(qiymetText, out decimal price);

//                if (countOk && priceOk && count > 0 && price > 0)
//                {
//                    decimal result = count * price;

//                    dataGridView1.Rows.Add(
//                        textBox1.Text.Trim(),
//                        count,
//                        price.ToString("0.00"),
//                        result.ToString("0.00"));

//                    total += result;
//                    Text = "Cəmi: " + total.ToString("0.00") + " AZN";

//                    textBox1.Clear();
//                    maskedTextBox1.Text = "";
//                    maskedTextBox2.Text = "";
//                    textBox1.Focus();
//                }
//                else
//                {
//                    MessageBox.Show("Say və qiymət düzgün daxil edilməyib! Say tam ədəd olmalı, hər iki dəyər isə müsbət (> 0) olmalıdır.",
//                        "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                }
//            }
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show("Proqramdan çıxmaq istədiyinizə əminsinizmi?", "Çıxış",
//                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                Close();
//            }
//        }

//        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
//        {
//            toolTip1.ToolTipTitle = "Say";
//            toolTip1.ToolTipIcon = ToolTipIcon.Info;
//            toolTip1.IsBalloon = true;
//        }
//    }
//}
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
            label5.Text = total.ToString("0.00") + " AZN";
            Text = "Gül Satış Sistemi - Cəmi: 0.00 AZN";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sayText = maskedTextBox1.Text.Replace("_", "").Trim();
            string qiymetText = maskedTextBox2.Text.Replace("_", "").Trim().Replace(',', '.');

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
            bool priceOk = decimal.TryParse(qiymetText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price);

            if (countOk && priceOk && count > 0 && price > 0)
            {
                decimal result = count * price;

                dataGridView1.Rows.Add(
                    textBox1.Text.Trim(),
                    count,
                    price.ToString("0.00"),
                    result.ToString("0.00"));

                total += result;
                label5.Text = total.ToString("0.00") + " AZN";
                Text = "Cəmi: " + total.ToString("0.00") + " AZN";

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
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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