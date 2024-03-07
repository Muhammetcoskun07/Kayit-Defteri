namespace Kayıt_Defteri
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(84, 72);
            label1.Name = "label1";
            label1.Size = new Size(138, 35);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(285, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 41);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(285, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 41);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(84, 150);
            label2.Name = "label2";
            label2.Size = new Size(100, 35);
            label2.TabIndex = 2;
            label2.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(801, 75);
            label3.Name = "label3";
            label3.Size = new Size(41, 35);
            label3.TabIndex = 4;
            label3.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(632, 75);
            label4.Name = "label4";
            label4.Size = new Size(138, 35);
            label4.TabIndex = 5;
            label4.Text = "Adı Soyadı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(801, 150);
            label5.Name = "label5";
            label5.Size = new Size(41, 35);
            label5.TabIndex = 7;
            label5.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(632, 150);
            label6.Name = "label6";
            label6.Size = new Size(100, 35);
            label6.TabIndex = 6;
            label6.Text = "Telefon:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(84, 472);
            button1.Name = "button1";
            button1.Size = new Size(138, 59);
            button1.TabIndex = 8;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Melikgazi", "Bünyan", "Talas", "Erkilet ", "Kocasinan", "Tomarza", "İncesu", "Yahyalı", "Yeşilhisar", "Sarız", "Hisarcık", "Hacılar" });
            comboBox1.Location = new Point(285, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 43);
            comboBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(84, 228);
            label7.Name = "label7";
            label7.Size = new Size(76, 35);
            label7.TabIndex = 11;
            label7.Text = "Semt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(801, 228);
            label8.Name = "label8";
            label8.Size = new Size(41, 35);
            label8.TabIndex = 13;
            label8.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(632, 228);
            label9.Name = "label9";
            label9.Size = new Size(76, 35);
            label9.TabIndex = 12;
            label9.Text = "Semt:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(285, 301);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 135);
            textBox3.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(84, 301);
            label10.Name = "label10";
            label10.Size = new Size(84, 35);
            label10.TabIndex = 14;
            label10.Text = "Adres:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(801, 304);
            label11.Name = "label11";
            label11.Size = new Size(41, 35);
            label11.TabIndex = 17;
            label11.Text = "00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(632, 304);
            label12.Name = "label12";
            label12.Size = new Size(84, 35);
            label12.TabIndex = 16;
            label12.Text = "Adres:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(1118, 621);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(textBox3);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kayıt Defteri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox3;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
