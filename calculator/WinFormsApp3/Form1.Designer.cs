namespace WinFormsApp3
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
            label1 = new Label();
            txtNumberOne = new TextBox();
            txtNumberTwo = new TextBox();
            label2 = new Label();
            cmbCommand = new ComboBox();
            label3 = new Label();
            btnResult = new Button();
            btnClear = new Button();
            lblAnswer = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(72, 35);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Number one";
            label1.Click += label1_Click;
            // 
            // txtNumberOne
            // 
            txtNumberOne.Location = new Point(72, 69);
            txtNumberOne.Name = "txtNumberOne";
            txtNumberOne.Size = new Size(125, 27);
            txtNumberOne.TabIndex = 1;
            // 
            // txtNumberTwo
            // 
            txtNumberTwo.Location = new Point(72, 165);
            txtNumberTwo.Name = "txtNumberTwo";
            txtNumberTwo.Size = new Size(125, 27);
            txtNumberTwo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(72, 131);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Number two";
            // 
            // cmbCommand
            // 
            cmbCommand.FormattingEnabled = true;
            cmbCommand.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbCommand.Location = new Point(72, 236);
            cmbCommand.Name = "cmbCommand";
            cmbCommand.Size = new Size(125, 28);
            cmbCommand.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(72, 213);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Command";
            label3.Click += label3_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(72, 319);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(125, 29);
            btnResult.TabIndex = 6;
            btnResult.Text = "Result";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(72, 366);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(72, 284);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(60, 20);
            lblAnswer.TabIndex = 8;
            lblAnswer.Text = "Answer:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(138, 284);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(17, 20);
            lblResult.TabIndex = 9;
            lblResult.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(lblAnswer);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(label3);
            Controls.Add(cmbCommand);
            Controls.Add(txtNumberTwo);
            Controls.Add(label2);
            Controls.Add(txtNumberOne);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = SystemColors.GradientActiveCaption;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumberOne;
        private TextBox txtNumberTwo;
        private Label label2;
        private ComboBox cmbCommand;
        private Label label3;
        private Button btnResult;
        private Button btnClear;
        private Label lblAnswer;
        private Label lblResult;
    }
}
