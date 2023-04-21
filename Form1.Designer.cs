namespace VehicleFinanceCalculator
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
            panel1 = new Panel();
            Monthly = new Panel();
            button3 = new Button();
            label12 = new Label();
            bank3 = new ComboBox();
            n1 = new ComboBox();
            label13 = new Label();
            textBox4 = new TextBox();
            r2 = new TextBox();
            textBox6 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            Term = new Panel();
            button2 = new Button();
            label6 = new Label();
            bank2 = new ComboBox();
            d1 = new TextBox();
            r1 = new TextBox();
            p1 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel5 = new Panel();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            A = new TextBox();
            panel3 = new Panel();
            Total = new Panel();
            label7 = new Label();
            bank = new ComboBox();
            n = new ComboBox();
            label5 = new Label();
            D = new TextBox();
            r = new TextBox();
            button1 = new Button();
            P = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            Monthly.SuspendLayout();
            Term.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            Total.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(325, 37);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Finance Calculator";
            // 
            // panel1
            // 
            panel1.Controls.Add(Monthly);
            panel1.Controls.Add(Term);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(Total);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 428);
            panel1.TabIndex = 1;
            // 
            // Monthly
            // 
            Monthly.AccessibleName = "Monthly";
            Monthly.Controls.Add(button3);
            Monthly.Controls.Add(label12);
            Monthly.Controls.Add(bank3);
            Monthly.Controls.Add(n1);
            Monthly.Controls.Add(label13);
            Monthly.Controls.Add(textBox4);
            Monthly.Controls.Add(r2);
            Monthly.Controls.Add(textBox6);
            Monthly.Controls.Add(label14);
            Monthly.Controls.Add(label15);
            Monthly.Controls.Add(label16);
            Monthly.Location = new Point(613, 139);
            Monthly.Margin = new Padding(3, 2, 3, 2);
            Monthly.Name = "Monthly";
            Monthly.Size = new Size(248, 287);
            Monthly.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Location = new Point(93, 251);
            button3.Name = "button3";
            button3.Size = new Size(84, 33);
            button3.TabIndex = 11;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(95, 54);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 10;
            label12.Text = "Bank";
            // 
            // bank3
            // 
            bank3.FormattingEnabled = true;
            bank3.Location = new Point(17, 71);
            bank3.Margin = new Padding(3, 2, 3, 2);
            bank3.Name = "bank3";
            bank3.Size = new Size(210, 23);
            bank3.TabIndex = 9;
            bank3.Text = "Select Bank";
            bank3.DropDown += bank3_DropDown;
            bank3.SelectedIndexChanged += bank3_SelectedIndexChanged_1;
            // 
            // n1
            // 
            n1.FormattingEnabled = true;
            n1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            n1.Location = new Point(44, 206);
            n1.Margin = new Padding(3, 2, 3, 2);
            n1.Name = "n1";
            n1.Size = new Size(133, 23);
            n1.TabIndex = 8;
            n1.Text = "Number of Years";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(94, 188);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 7;
            label13.Text = "Years";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 166);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 23);
            textBox4.TabIndex = 5;
            // 
            // r2
            // 
            r2.Location = new Point(12, 113);
            r2.Margin = new Padding(3, 2, 3, 2);
            r2.Name = "r2";
            r2.Size = new Size(215, 23);
            r2.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(17, 24);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(215, 23);
            textBox6.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(79, 148);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 2;
            label14.Text = "Deposit";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(81, 96);
            label15.Name = "label15";
            label15.Size = new Size(72, 15);
            label15.TabIndex = 1;
            label15.Text = "Interest Rate";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(68, 8);
            label16.Name = "label16";
            label16.Size = new Size(100, 15);
            label16.TabIndex = 0;
            label16.Text = "Principal Amount";
            // 
            // Term
            // 
            Term.AccessibleName = "Term";
            Term.Controls.Add(button2);
            Term.Controls.Add(label6);
            Term.Controls.Add(bank2);
            Term.Controls.Add(d1);
            Term.Controls.Add(r1);
            Term.Controls.Add(p1);
            Term.Controls.Add(label9);
            Term.Controls.Add(label10);
            Term.Controls.Add(label11);
            Term.Location = new Point(16, 139);
            Term.Margin = new Padding(3, 2, 3, 2);
            Term.Name = "Term";
            Term.Size = new Size(284, 287);
            Term.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Location = new Point(94, 250);
            button2.Name = "button2";
            button2.Size = new Size(82, 34);
            button2.TabIndex = 12;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 54);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Bank";
            // 
            // bank2
            // 
            bank2.FormattingEnabled = true;
            bank2.Location = new Point(42, 72);
            bank2.Margin = new Padding(3, 2, 3, 2);
            bank2.Name = "bank2";
            bank2.Size = new Size(210, 23);
            bank2.TabIndex = 9;
            bank2.Text = "Select Bank";
            bank2.DropDown += bank2_DropDown;
            bank2.SelectedIndexChanged += bank2_SelectedIndexChanged_1;
            // 
            // d1
            // 
            d1.Location = new Point(38, 174);
            d1.Margin = new Padding(3, 2, 3, 2);
            d1.Name = "d1";
            d1.Size = new Size(215, 23);
            d1.TabIndex = 5;
            // 
            // r1
            // 
            r1.Location = new Point(38, 121);
            r1.Margin = new Padding(3, 2, 3, 2);
            r1.Name = "r1";
            r1.Size = new Size(215, 23);
            r1.TabIndex = 4;
            // 
            // p1
            // 
            p1.Location = new Point(38, 25);
            p1.Margin = new Padding(3, 2, 3, 2);
            p1.Name = "p1";
            p1.Size = new Size(215, 23);
            p1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(104, 156);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 2;
            label9.Text = "Interest";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(107, 104);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 1;
            label10.Text = "Interest Rate";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(94, 8);
            label11.Name = "label11";
            label11.Size = new Size(100, 15);
            label11.TabIndex = 0;
            label11.Text = "Principal Amount";
            // 
            // panel5
            // 
            panel5.Controls.Add(comboBox1);
            panel5.Location = new Point(263, 88);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(396, 46);
            panel5.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Term", "Total Payment", "Monthly Payment" });
            comboBox1.Location = new Point(115, 14);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Select Calculator";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(A);
            panel4.Location = new Point(263, 58);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(396, 26);
            panel4.TabIndex = 3;
            // 
            // A
            // 
            A.Location = new Point(60, 2);
            A.Margin = new Padding(3, 2, 3, 2);
            A.Name = "A";
            A.ReadOnly = true;
            A.Size = new Size(285, 23);
            A.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(263, 2);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 52);
            panel3.TabIndex = 2;
            // 
            // Total
            // 
            Total.AccessibleName = "Total";
            Total.Controls.Add(label7);
            Total.Controls.Add(bank);
            Total.Controls.Add(n);
            Total.Controls.Add(label5);
            Total.Controls.Add(D);
            Total.Controls.Add(r);
            Total.Controls.Add(button1);
            Total.Controls.Add(P);
            Total.Controls.Add(label4);
            Total.Controls.Add(label3);
            Total.Controls.Add(label2);
            Total.Location = new Point(324, 139);
            Total.Margin = new Padding(3, 2, 3, 2);
            Total.Name = "Total";
            Total.Size = new Size(284, 287);
            Total.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(118, 54);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 10;
            label7.Text = "Bank";
            // 
            // bank
            // 
            bank.FormattingEnabled = true;
            bank.Location = new Point(40, 71);
            bank.Margin = new Padding(3, 2, 3, 2);
            bank.Name = "bank";
            bank.Size = new Size(210, 23);
            bank.TabIndex = 9;
            bank.Text = "Select Bank";
            bank.DropDown += bank_DropDown;
            bank.SelectedIndexChanged += bank_SelectedIndexChanged;
            // 
            // n
            // 
            n.FormattingEnabled = true;
            n.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            n.Location = new Point(67, 213);
            n.Margin = new Padding(3, 2, 3, 2);
            n.Name = "n";
            n.Size = new Size(133, 23);
            n.TabIndex = 8;
            n.Text = "Number of Years";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 196);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 7;
            label5.Text = "Years";
            // 
            // D
            // 
            D.Location = new Point(36, 173);
            D.Margin = new Padding(3, 2, 3, 2);
            D.Name = "D";
            D.Size = new Size(215, 23);
            D.TabIndex = 5;
            // 
            // r
            // 
            r.Location = new Point(36, 121);
            r.Margin = new Padding(3, 2, 3, 2);
            r.Name = "r";
            r.Size = new Size(215, 23);
            r.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(92, 251);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // P
            // 
            P.Location = new Point(36, 25);
            P.Margin = new Padding(3, 2, 3, 2);
            P.Name = "P";
            P.Size = new Size(215, 23);
            P.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 156);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 2;
            label4.Text = "Deposit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 104);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 1;
            label3.Text = "Interest Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 8);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 0;
            label2.Text = "Principal Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 446);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            Monthly.ResumeLayout(false);
            Monthly.PerformLayout();
            Term.ResumeLayout(false);
            Term.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            Total.ResumeLayout(false);
            Total.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel Total;
        private TextBox D;
        private TextBox r;
        private TextBox P;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private TextBox A;
        private Button button1;
        private ComboBox n;
        private Label label5;
        private Panel panel5;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox bank;
        private Panel Monthly;
        private Label label12;
        private ComboBox bank3;
        private ComboBox n1;
        private Label label13;
        private TextBox textBox4;
        private TextBox r2;
        private TextBox textBox6;
        private Label label14;
        private Label label15;
        private Label label16;
        private Panel Term;
        private Label label6;
        private ComboBox bank2;
        private TextBox d1;
        private TextBox r1;
        private TextBox p1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button3;
        private Button button2;
    }
}