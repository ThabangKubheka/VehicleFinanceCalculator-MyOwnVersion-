namespace VehicleFinanceCalculator
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            email = new TextBox();
            button1 = new Button();
            password = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(linkLabel1);
            panel3.Location = new Point(223, 11);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 401);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(email);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(password);
            panel2.Location = new Point(80, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 175);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 11;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 12;
            label3.Text = "Password :";
            // 
            // email
            // 
            email.Location = new Point(75, 26);
            email.Name = "email";
            email.Size = new Size(112, 23);
            email.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(69, 130);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.BackColor = Color.White;
            password.Location = new Point(75, 83);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(112, 23);
            password.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 77);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(325, 37);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Finance Calculator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 273);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 17;
            label4.Text = "New Here ?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(127, 297);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click here to Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Name = "Login";
            Text = "Login";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox password;
        private TextBox email;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
    }
}