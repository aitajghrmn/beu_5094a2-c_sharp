using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace WinformPlaneTask;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

   
    SoundPlayer spEnis = new SoundPlayer("C:\\Users\\Lenovo\\Downloads\\inishazirliklari.wav");
    SoundPlayer spKemer = new SoundPlayer("C:\\Users\\Lenovo\\Downloads\\kemerler.wav");
    SoundPlayer spTesekkur = new SoundPlayer("C:\\Users\\Lenovo\\Downloads\\tesekkurler.wav");
    SoundPlayer spBeep = new SoundPlayer("C:\\Users\\Lenovo\\Downloads\\beep.wav");
    SoundPlayer spIsiq = new SoundPlayer("C:\\Users\\Lenovo\\Downloads\\isikacmakapamasesi.wav");

    
    private void button1_Click(object sender, EventArgs e)
    {
        spEnis.Play();
        pictureBox1.Location = new Point(48, 246);
        pictureBox2.Location = new Point(75, 219);
        MessageBox.Show("Eniş hazırlığı");
    }

    
    private void button2_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < 4; i++)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);
            Thread.Sleep(40);
            Application.DoEvents();

            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y);
            Thread.Sleep(40);
            Application.DoEvents();
        }
        MessageBox.Show("Turbulans");
    }

  
    private void button3_Click(object sender, EventArgs e)
    {
        spKemer.Play();
        MessageBox.Show("Kəmərlər");
    }

    
    private void button4_Click(object sender, EventArgs e)
    {
        spTesekkur.Play();
        MessageBox.Show("Təşəkkürlər");
    }

   
    private void button5_Click(object sender, EventArgs e)
    {
        spBeep.Play();
    }

    
    private void button6_Click(object sender, EventArgs e)
    {
        if (pictureBox1.Location.Y > 20)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 20);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 20);
        }
        else
        {
            MessageBox.Show("Way end");
        }
    }

  
    private void button7_Click(object sender, EventArgs e)
    {
        if (pictureBox1.Location.Y < 246)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 20);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 20);
        }
        else
        {
            MessageBox.Show("Way end");
        }
    }

   
    bool k = false;
    private void button8_Click(object sender, EventArgs e)
    {
        spIsiq.Play(); 

        if (k == false)
        {
            k = true;
            button8.Text = "ON";
            pictureBox2.Visible = true;
        }
        else
        {
            k = false;
            button8.Text = "OFF";
            pictureBox2.Visible = false;
        }
    }
}
