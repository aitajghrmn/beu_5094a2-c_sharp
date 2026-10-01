namespace greeting_app
{
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
            txtAd = new TextBox();
            label1 = new Label();
            btnSalamla = new Button();
            lblSalam = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(297, 147);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(160, 27);
            txtAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 154);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter your name here:";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btnSalamla
            // 
            btnSalamla.Location = new Point(331, 200);
            btnSalamla.Name = "btnSalamla";
            btnSalamla.Size = new Size(94, 29);
            btnSalamla.TabIndex = 2;
            btnSalamla.Text = "Salamla";
            btnSalamla.UseVisualStyleBackColor = true;
            btnSalamla.Click += btnSalamla_Click;
            // 
            // lblSalam
            // 
            lblSalam.AutoSize = true;
            lblSalam.Location = new Point(358, 313);
            lblSalam.Name = "lblSalam";
            lblSalam.Size = new Size(0, 20);
            lblSalam.TabIndex = 3;
            lblSalam.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(lblSalam);
            Controls.Add(btnSalamla);
            Controls.Add(label1);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private Label label1;
        private Button btnSalamla;
        private Label lblSalam;
    }
}
