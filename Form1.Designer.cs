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
            carP = new Panel();
            button4 = new Button();
            label21 = new Label();
            years = new ComboBox();
            label20 = new Label();
            rate = new TextBox();
            deposit = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            bank5 = new ComboBox();
            cars = new ComboBox();
            carPrice = new TextBox();
            label8 = new Label();
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
            carP.SuspendLayout();
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
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(408, 46);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Finance Calculator";
            // 
            // panel1
            // 
            panel1.Controls.Add(carP);
            panel1.Controls.Add(Monthly);
            panel1.Controls.Add(Term);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(Total);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 571);
            panel1.TabIndex = 1;
            // 
            // carP
            // 
            carP.Controls.Add(button4);
            carP.Controls.Add(label21);
            carP.Controls.Add(years);
            carP.Controls.Add(label20);
            carP.Controls.Add(rate);
            carP.Controls.Add(deposit);
            carP.Controls.Add(label19);
            carP.Controls.Add(label18);
            carP.Controls.Add(label17);
            carP.Controls.Add(bank5);
            carP.Controls.Add(cars);
            carP.Controls.Add(carPrice);
            carP.Controls.Add(label8);
            carP.Location = new Point(764, 188);
            carP.Name = "carP";
            carP.Size = new Size(244, 383);
            carP.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(87, 343);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Calculate";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(81, 275);
            label21.Name = "label21";
            label21.Size = new Size(43, 20);
            label21.TabIndex = 12;
            label21.Text = "Years";
            // 
            // years
            // 
            years.FormattingEnabled = true;
            years.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            years.Location = new Point(36, 298);
            years.Name = "years";
            years.Size = new Size(181, 28);
            years.TabIndex = 11;
            years.Text = "Number of Years";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(89, 220);
            label20.Name = "label20";
            label20.Size = new Size(92, 20);
            label20.TabIndex = 10;
            label20.Text = "Interest Rate";
            // 
            // rate
            // 
            rate.Location = new Point(36, 243);
            rate.Name = "rate";
            rate.ReadOnly = true;
            rate.Size = new Size(181, 27);
            rate.TabIndex = 9;
            // 
            // deposit
            // 
            deposit.Location = new Point(36, 190);
            deposit.Name = "deposit";
            deposit.Size = new Size(181, 27);
            deposit.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(95, 167);
            label19.Name = "label19";
            label19.Size = new Size(61, 20);
            label19.TabIndex = 7;
            label19.Text = "Deposit";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(89, 113);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 6;
            label18.Text = "Car Price";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(95, 59);
            label17.Name = "label17";
            label17.Size = new Size(41, 20);
            label17.TabIndex = 5;
            label17.Text = "Bank";
            // 
            // bank5
            // 
            bank5.FormattingEnabled = true;
            bank5.Location = new Point(36, 82);
            bank5.Name = "bank5";
            bank5.Size = new Size(181, 28);
            bank5.TabIndex = 4;
            bank5.Text = "Select Bank";
            bank5.DropDown += bank5_DropDown;
            bank5.SelectedIndexChanged += bank5_SelectedIndexChanged;
            // 
            // cars
            // 
            cars.FormattingEnabled = true;
            cars.Location = new Point(36, 28);
            cars.Name = "cars";
            cars.Size = new Size(181, 28);
            cars.TabIndex = 3;
            cars.Text = "Select Car";
            cars.DropDown += cars_DropDown;
            cars.SelectedIndexChanged += cars_SelectedIndexChanged;
            // 
            // carPrice
            // 
            carPrice.Location = new Point(36, 136);
            carPrice.Name = "carPrice";
            carPrice.ReadOnly = true;
            carPrice.Size = new Size(181, 27);
            carPrice.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 7);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 1;
            label8.Text = "Car";
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
            Monthly.Location = new Point(472, 188);
            Monthly.Name = "Monthly";
            Monthly.Size = new Size(283, 383);
            Monthly.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Location = new Point(106, 335);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(96, 44);
            button3.TabIndex = 11;
            button3.Text = "Calculate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(109, 72);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 10;
            label12.Text = "Bank";
            // 
            // bank3
            // 
            bank3.FormattingEnabled = true;
            bank3.Location = new Point(19, 95);
            bank3.Name = "bank3";
            bank3.Size = new Size(239, 28);
            bank3.TabIndex = 9;
            bank3.Text = "Select Bank";
            bank3.DropDown += bank3_DropDown;
            bank3.SelectedIndexChanged += bank3_SelectedIndexChanged_1;
            // 
            // n1
            // 
            n1.FormattingEnabled = true;
            n1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            n1.Location = new Point(50, 275);
            n1.Name = "n1";
            n1.Size = new Size(151, 28);
            n1.TabIndex = 8;
            n1.Text = "Number of Years";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(107, 251);
            label13.Name = "label13";
            label13.Size = new Size(43, 20);
            label13.TabIndex = 7;
            label13.Text = "Years";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 221);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 27);
            textBox4.TabIndex = 5;
            // 
            // r2
            // 
            r2.Location = new Point(19, 167);
            r2.Name = "r2";
            r2.ReadOnly = true;
            r2.Size = new Size(245, 27);
            r2.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(19, 32);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(245, 27);
            textBox6.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(90, 197);
            label14.Name = "label14";
            label14.Size = new Size(61, 20);
            label14.TabIndex = 2;
            label14.Text = "Deposit";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(90, 135);
            label15.Name = "label15";
            label15.Size = new Size(92, 20);
            label15.TabIndex = 1;
            label15.Text = "Interest Rate";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(78, 11);
            label16.Name = "label16";
            label16.Size = new Size(123, 20);
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
            Term.Location = new Point(3, 184);
            Term.Name = "Term";
            Term.Size = new Size(224, 383);
            Term.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Location = new Point(46, 334);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(94, 45);
            button2.TabIndex = 12;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 72);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 10;
            label6.Text = "Bank";
            // 
            // bank2
            // 
            bank2.FormattingEnabled = true;
            bank2.Location = new Point(8, 96);
            bank2.Name = "bank2";
            bank2.Size = new Size(203, 28);
            bank2.TabIndex = 9;
            bank2.Text = "Select Bank";
            bank2.DropDown += bank2_DropDown;
            bank2.SelectedIndexChanged += bank2_SelectedIndexChanged_1;
            // 
            // d1
            // 
            d1.Location = new Point(8, 232);
            d1.Name = "d1";
            d1.Size = new Size(205, 27);
            d1.TabIndex = 5;
            // 
            // r1
            // 
            r1.Location = new Point(8, 178);
            r1.Name = "r1";
            r1.ReadOnly = true;
            r1.Size = new Size(203, 27);
            r1.TabIndex = 4;
            // 
            // p1
            // 
            p1.Location = new Point(8, 36);
            p1.Name = "p1";
            p1.Size = new Size(203, 27);
            p1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 208);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 2;
            label9.Text = "Interest";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(82, 139);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 1;
            label10.Text = "Interest Rate";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 11);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 0;
            label11.Text = "Principal Amount";
            // 
            // panel5
            // 
            panel5.Controls.Add(comboBox1);
            panel5.Location = new Point(301, 117);
            panel5.Name = "panel5";
            panel5.Size = new Size(453, 61);
            panel5.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Term", "Total Payment", "Monthly Payment", "Choose Car" });
            comboBox1.Location = new Point(131, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Select Calculator";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(A);
            panel4.Location = new Point(301, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(453, 35);
            panel4.TabIndex = 3;
            // 
            // A
            // 
            A.Location = new Point(69, 3);
            A.Name = "A";
            A.ReadOnly = true;
            A.Size = new Size(325, 27);
            A.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(301, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 69);
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
            Total.Location = new Point(233, 185);
            Total.Name = "Total";
            Total.Size = new Size(233, 383);
            Total.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 71);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 10;
            label7.Text = "Bank";
            // 
            // bank
            // 
            bank.FormattingEnabled = true;
            bank.Location = new Point(9, 94);
            bank.Name = "bank";
            bank.Size = new Size(197, 28);
            bank.TabIndex = 9;
            bank.Text = "Select Bank";
            bank.DropDown += bank_DropDown;
            bank.SelectedIndexChanged += bank_SelectedIndexChanged;
            // 
            // n
            // 
            n.FormattingEnabled = true;
            n.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            n.Location = new Point(40, 283);
            n.Name = "n";
            n.Size = new Size(139, 28);
            n.TabIndex = 8;
            n.Text = "Number of Years";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 260);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 7;
            label5.Text = "Years";
            // 
            // D
            // 
            D.Location = new Point(4, 230);
            D.Name = "D";
            D.Size = new Size(203, 27);
            D.TabIndex = 5;
            // 
            // r
            // 
            r.Location = new Point(9, 177);
            r.Name = "r";
            r.ReadOnly = true;
            r.Size = new Size(203, 27);
            r.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(68, 334);
            button1.Name = "button1";
            button1.Size = new Size(102, 45);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // P
            // 
            P.Location = new Point(4, 32);
            P.Name = "P";
            P.Size = new Size(203, 27);
            P.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 207);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 2;
            label4.Text = "Deposit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 138);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 1;
            label3.Text = "Interest Rate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 10);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 0;
            label2.Text = "Principal Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 595);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            carP.ResumeLayout(false);
            carP.PerformLayout();
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
        private ComboBox bank5;
        private Panel carP;
        private Button button4;
        private Label label21;
        private ComboBox years;
        private Label label20;
        private TextBox rate;
        private TextBox deposit;
        private Label label19;
        private Label label18;
        private Label label17;
        private ComboBox cars;
        private TextBox carPrice;
        private Label label8;
    }
}