namespace WinformPlaneTask;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        panel1 = new Panel();
        pictureBox2 = new PictureBox();
        pictureBox1 = new PictureBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.DimGray;
        panel1.Controls.Add(pictureBox2);
        panel1.Controls.Add(pictureBox1);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(216, 391);
        panel1.TabIndex = 0;
        // 
        // pictureBox2
        // 
        pictureBox2.BackColor = Color.Transparent;
        pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
        pictureBox2.Location = new Point(75, 219);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(45, 32);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Transparent;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(48, 246);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(98, 137);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(255, 128, 0);
        button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.Black;
        button1.Location = new Point(226, 7);
        button1.Name = "button1";
        button1.Size = new Size(302, 42);
        button1.TabIndex = 1;
        button1.Text = "Eniş hazırlığı";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(255, 128, 0);
        button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        button2.ForeColor = Color.Black;
        button2.Location = new Point(226, 56);
        button2.Name = "button2";
        button2.Size = new Size(302, 42);
        button2.TabIndex = 2;
        button2.Text = "Turbulans";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.BackColor = Color.FromArgb(255, 128, 0);
        button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        button3.ForeColor = Color.Black;
        button3.Location = new Point(226, 105);
        button3.Name = "button3";
        button3.Size = new Size(302, 42);
        button3.TabIndex = 3;
        button3.Text = "Kəmərlər";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.BackColor = Color.FromArgb(255, 128, 0);
        button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        button4.ForeColor = Color.Black;
        button4.Location = new Point(226, 154);
        button4.Name = "button4";
        button4.Size = new Size(302, 42);
        button4.TabIndex = 4;
        button4.Text = "Təşəkkürlər";
        button4.UseVisualStyleBackColor = false;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.BackColor = Color.FromArgb(255, 128, 0);
        button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        button5.ForeColor = Color.Black;
        button5.Location = new Point(226, 203);
        button5.Name = "button5";
        button5.Size = new Size(302, 42);
        button5.TabIndex = 5;
        button5.Text = "Beep";
        button5.UseVisualStyleBackColor = false;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.BackColor = Color.Green;
        button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        button6.ForeColor = Color.White;
        button6.Location = new Point(232, 277);
        button6.Name = "button6";
        button6.Size = new Size(118, 65);
        button6.TabIndex = 6;
        button6.Text = "GAS";
        button6.UseVisualStyleBackColor = false;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.BackColor = Color.FromArgb(192, 0, 0);
        button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        button7.ForeColor = Color.White;
        button7.Location = new Point(393, 277);
        button7.Name = "button7";
        button7.Size = new Size(118, 65);
        button7.TabIndex = 7;
        button7.Text = "Break";
        button7.UseVisualStyleBackColor = false;
        button7.Click += button7_Click;
        // 
        // button8
        // 
        button8.BackColor = Color.FromArgb(0, 0, 192);
        button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        button8.ForeColor = Color.White;
        button8.Location = new Point(216, 349);
        button8.Name = "button8";
        button8.Size = new Size(321, 42);
        button8.TabIndex = 8;
        button8.Text = "ON/OFF";
        button8.UseVisualStyleBackColor = false;
        button8.Click += button8_Click;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(537, 391);
        Controls.Add(button8);
        Controls.Add(button7);
        Controls.Add(button6);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = true;
        MinimizeBox = true;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Plane";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
}
