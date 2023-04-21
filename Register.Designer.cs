namespace VehicleFinanceCalculator
{
    partial class Register
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
            label1 = new Label();
            button1 = new Button();
            password = new TextBox();
            email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            message = new Label();
            validatedPassword = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(38, 28);
            label1.Name = "label1";
            label1.Size = new Size(325, 37);
            label1.TabIndex = 1;
            label1.Text = "Vehicle Finance Calculator";
            // 
            // button1
            // 
            button1.Location = new Point(147, 239);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(170, 134);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 19;
            // 
            // email
            // 
            email.Location = new Point(170, 99);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 137);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 17;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 99);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 16;
            label2.Text = "Email :";
            // 
            // panel1
            // 
            panel1.Controls.Add(message);
            panel1.Controls.Add(validatedPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(email);
            panel1.Location = new Point(221, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 330);
            panel1.TabIndex = 21;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(123, 291);
            message.Name = "message";
            message.Size = new Size(0, 15);
            message.TabIndex = 23;
            // 
            // validatedPassword
            // 
            validatedPassword.Location = new Point(170, 181);
            validatedPassword.Name = "validatedPassword";
            validatedPassword.Size = new Size(100, 23);
            validatedPassword.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 189);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 21;
            label4.Text = "Re-enter Password :";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox password;
        private TextBox email;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private TextBox validatedPassword;
        private Label label4;
        private Label message;
    }
}