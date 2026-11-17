using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a1, a2, a3, a4, a5, a6, a7, a8;

        bool o1, o2, o3, o4, o5, o6, o7, o8;

        int r1, r2, r3, r4;

        int firstIndex = 0;   
        int firstColor = 0;   
        int wrong1 = 0;     
        int wrong2 = 0;     
        int sum = 0;       

        Random rnd = new Random();
        Color closedColor = Color.Gainsboro;

        private Color GetColor(int n)
        {
            if (n == 1) return Color.Red;
            if (n == 2) return Color.Blue;
            if (n == 3) return Color.Green;
            return Color.Gold;
        }

        private int RandomColor()
        {
            while (true)
            {
                int n = rnd.Next(1, 5);
                if (n == 1 && r1 < 2) { r1++; return 1; }
                if (n == 2 && r2 < 2) { r2++; return 2; }
                if (n == 3 && r3 < 2) { r3++; return 3; }
                if (n == 4 && r4 < 2) { r4++; return 4; }
            }
        }

        private void CloseCard(int n)
        {
            if (n == 1) { o1 = false; pictureBox1.BackColor = closedColor; }
            if (n == 2) { o2 = false; pictureBox2.BackColor = closedColor; }
            if (n == 3) { o3 = false; pictureBox3.BackColor = closedColor; }
            if (n == 4) { o4 = false; pictureBox4.BackColor = closedColor; }
            if (n == 5) { o5 = false; pictureBox5.BackColor = closedColor; }
            if (n == 6) { o6 = false; pictureBox6.BackColor = closedColor; }
            if (n == 7) { o7 = false; pictureBox7.BackColor = closedColor; }
            if (n == 8) { o8 = false; pictureBox8.BackColor = closedColor; }
        }

        private void CloseWrong()
        {
            if (wrong1 != 0)
            {
                CloseCard(wrong1);
                CloseCard(wrong2);
                wrong1 = 0;
                wrong2 = 0;
                pictureBox10.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            r1 = 0; r2 = 0; r3 = 0; r4 = 0;

            a1 = RandomColor();
            a2 = RandomColor();
            a3 = RandomColor();
            a4 = RandomColor();
            a5 = RandomColor();
            a6 = RandomColor();
            a7 = RandomColor();
            a8 = RandomColor();

            o1 = false; o2 = false; o3 = false; o4 = false;
            o5 = false; o6 = false; o7 = false; o8 = false;

            pictureBox1.BackColor = closedColor;
            pictureBox2.BackColor = closedColor;
            pictureBox3.BackColor = closedColor;
            pictureBox4.BackColor = closedColor;
            pictureBox5.BackColor = closedColor;
            pictureBox6.BackColor = closedColor;
            pictureBox7.BackColor = closedColor;
            pictureBox8.BackColor = closedColor;

            firstIndex = 0;
            firstColor = 0;
            wrong1 = 0;
            wrong2 = 0;
            sum = 0;
            label2.Text = sum.ToString();

            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (o1 == true) return;
            o1 = true;
            pictureBox1.BackColor = GetColor(a1);

            if (firstIndex == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                firstIndex = 1;
                firstColor = a1;
            }
            else
            {
                if (firstColor == a1)
                {
                    sum++;
                    label2.Text = sum.ToString();
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    wrong1 = firstIndex;
                    wrong2 = 1;
                }
                firstIndex = 0;
            }

            if (sum == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (o2 == true) return;
            o2 = true;
            pictureBox2.BackColor = GetColor(a2);

            if (firstIndex == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                firstIndex = 2;
                firstColor = a2;
            }
            else
            {
                if (firstColor == a2)
                {
                    sum++;
                    label2.Text = sum.ToString();
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    wrong1 = firstIndex;
                    wrong2 = 2;
                }
                firstIndex = 0;
            }

            if (sum == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (o3 == true) return;
            o3 = true;
            pictureBox3.BackColor = GetColor(a3);

            if (firstIndex == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                firstIndex = 3;
                firstColor = a3;
            }
            else
            {
                if (firstColor == a3)
                {
                    sum++;
                    label2.Text = sum.ToString();
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    wrong1 = firstIndex;
                    wrong2 = 3;
                }
                firstIndex = 0;
            }

            if (sum == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (o4 == true) return;
            o4 = true;
            pictureBox4.BackColor = GetColor(a4);

            if (firstIndex == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                firstIndex = 4;
                firstColor = a4;
            }
            else
            {
                if (firstColor == a4)
                {
                    sum++;
                    label2.Text = sum.ToString();
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    wrong1 = firstIndex;
                    wrong2 = 4;
                }
                firstIndex = 0;
            }

            if (sum == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (o5 == true) return;
            o5 = true;
            pictureBox5.BackColor = GetColor(a5);

            if (firstIndex == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                firstIndex = 5;
                firstColor = a5;
            }
            else
            {
                if (firstColor == a5)
                {
                    sum++;
                    label2.Text = sum.ToString();
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    wrong1 = firstIndex;
                    wrong2 = 5;
                }
                firstIndex = 0;
            }

            if (sum == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (o6 == true) return;
            o6 = true;
            pictureBox6.BackColor = GetColor(a6);

            if (firstIndex == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                firstIndex = 6;
                firstColor = a6;
            }
            else
            {
                if (firstColor == a6)
                {
                    sum++;
                    label2.Text = sum.ToString();
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    wrong1 = firstIndex;
                    wrong2 = 6;
                }
                firstIndex = 0;
            }

            if (sum == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (o7 == true) return;
            o7 = true;
            pictureBox7.BackColor = GetColor(a7);

            if (firstIndex == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                firstIndex = 7;
                firstColor = a7;
            }
            else
            {
                if (firstColor == a7)
                {
                    sum++;
                    label2.Text = sum.ToString();
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    wrong1 = firstIndex;
                    wrong2 = 7;
                }
                firstIndex = 0;
            }

            if (sum == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            CloseWrong();
            if (o8 == true) return;
            o8 = true;
            pictureBox8.BackColor = GetColor(a8);

            if (firstIndex == 0)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                firstIndex = 8;
                firstColor = a8;
            }
            else
            {
                if (firstColor == a8)
                {
                    sum++;
                    label2.Text = sum.ToString();
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = false;
                }
                else
                {
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = true;
                    wrong1 = firstIndex;
                    wrong2 = 8;
                }
                firstIndex = 0;
            }

            if (sum == 4)
            {
                MessageBox.Show("OYUNU QAZANDINIZ! Yeni oyun başlayır.", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewGame();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e) { }
        private void pictureBox10_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Oyundan çıxış edilsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}