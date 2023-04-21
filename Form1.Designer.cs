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
            panel4 = new Panel();
            A = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            n = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            D = new TextBox();
            r = new TextBox();
            P = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(408, 46);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Finance Calculator";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(180, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 486);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(A);
            panel4.Location = new Point(3, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(453, 93);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // A
            // 
            A.Location = new Point(56, 48);
            A.Name = "A";
            A.ReadOnly = true;
            A.Size = new Size(325, 27);
            A.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 69);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(n);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(D);
            panel2.Controls.Add(r);
            panel2.Controls.Add(P);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(72, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 306);
            panel2.TabIndex = 1;
            // 
            // n
            // 
            n.FormattingEnabled = true;
            n.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            n.Location = new Point(76, 215);
            n.Name = "n";
            n.Size = new Size(151, 28);
            n.TabIndex = 8;
            n.Text = "Number of Years";
            n.SelectedValueChanged += n_SelectedValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 180);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 7;
            label5.Text = "Years";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Location = new Point(98, 261);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // D
            // 
            D.Location = new Point(36, 150);
            D.Name = "D";
            D.Size = new Size(245, 27);
            D.TabIndex = 5;
            // 
            // r
            // 
            r.Location = new Point(36, 97);
            r.Name = "r";
            r.Size = new Size(245, 27);
            r.TabIndex = 4;
            // 
            // P
            // 
            P.Location = new Point(36, 32);
            P.Name = "P";
            P.Size = new Size(245, 27);
            P.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 127);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 2;
            label4.Text = "Deposit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 74);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Interest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 9);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 0;
            label2.Text = "Principal Amount";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(155, 14);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 9;
            label6.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
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
        private Label label6;
    }
}