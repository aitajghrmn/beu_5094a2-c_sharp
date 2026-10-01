namespace age_checker
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
            txtYas = new TextBox();
            label1 = new Label();
            btnYoxla = new Button();
            lblNetice = new Label();
            SuspendLayout();
            // 
            // txtYas
            // 
            txtYas.Location = new Point(76, 91);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(125, 27);
            txtYas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 54);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter youar age:";
            // 
            // btnYoxla
            // 
            btnYoxla.Location = new Point(88, 149);
            btnYoxla.Name = "btnYoxla";
            btnYoxla.Size = new Size(94, 29);
            btnYoxla.TabIndex = 2;
            btnYoxla.Text = "check";
            btnYoxla.UseVisualStyleBackColor = true;
            btnYoxla.Click += btnYoxla_Click;
            // 
            // lblNetice
            // 
            lblNetice.AutoSize = true;
            lblNetice.Location = new Point(362, 133);
            lblNetice.Name = "lblNetice";
            lblNetice.Size = new Size(0, 20);
            lblNetice.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 450);
            Controls.Add(lblNetice);
            Controls.Add(btnYoxla);
            Controls.Add(label1);
            Controls.Add(txtYas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYas;
        private Label label1;
        private Button btnYoxla;
        private Label lblNetice;
    }
}
