namespace _05._11._24
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 343);
            button1.Name = "button1";
            button1.Size = new Size(244, 95);
            button1.TabIndex = 0;
            button1.Text = "Select Color";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 15F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(540, 334);
            button2.Name = "button2";
            button2.Size = new Size(248, 104);
            button2.TabIndex = 1;
            button2.Text = "Select Font";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(780, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Test";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Font/Color";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.ForeColor = colorDialog.Color;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fontDialog.Font;
                }
            }
        }
    }
}