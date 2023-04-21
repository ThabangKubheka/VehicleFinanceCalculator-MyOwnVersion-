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
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            password = new TextBox();
            email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(password);
            panel3.Controls.Add(email);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(222, 11);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 401);
            panel3.TabIndex = 3;
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
            // button1
            // 
            button1.Location = new Point(149, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(195, 142);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 14;
            // 
            // email
            // 
            email.Location = new Point(197, 90);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 147);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 12;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 90);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 11;
            label2.Text = "Username :";
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
    }
}