namespace Login___Registration_System
{
    partial class frmregister
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
            label2 = new Label();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            checkbxshowpass = new CheckBox();
            txtComPassword = new TextBox();
            label7 = new Label();
            txtPassword = new TextBox();
            label8 = new Label();
            txtUsername = new TextBox();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(116, 86, 174);
            label2.Location = new Point(69, 434);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 38;
            label2.Text = "Back To Login";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 405);
            label6.Name = "label6";
            label6.Size = new Size(204, 21);
            label6.TabIndex = 39;
            label6.Text = "Already Have An Account";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(116, 86, 174);
            button3.Location = new Point(30, 364);
            button3.Name = "button3";
            button3.Size = new Size(215, 35);
            button3.TabIndex = 36;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(116, 85, 174);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(30, 317);
            button4.Name = "button4";
            button4.Size = new Size(215, 35);
            button4.TabIndex = 37;
            button4.Text = "REGISTER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // checkbxshowpass
            // 
            checkbxshowpass.AutoSize = true;
            checkbxshowpass.Cursor = Cursors.Hand;
            checkbxshowpass.FlatStyle = FlatStyle.Flat;
            checkbxshowpass.Location = new Point(59, 272);
            checkbxshowpass.Name = "checkbxshowpass";
            checkbxshowpass.Size = new Size(144, 25);
            checkbxshowpass.TabIndex = 35;
            checkbxshowpass.Text = "Show Password";
            checkbxshowpass.UseVisualStyleBackColor = true;
            checkbxshowpass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(30, 241);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new Size(215, 25);
            txtComPassword.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 216);
            label7.Name = "label7";
            label7.Size = new Size(148, 21);
            label7.TabIndex = 29;
            label7.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(30, 180);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(215, 25);
            txtPassword.TabIndex = 33;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 155);
            label8.Name = "label8";
            label8.Size = new Size(82, 21);
            label8.TabIndex = 30;
            label8.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(30, 117);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(215, 25);
            txtUsername.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 92);
            label9.Name = "label9";
            label9.Size = new Size(87, 21);
            label9.TabIndex = 31;
            label9.Text = "Username";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(116, 86, 174);
            label10.Location = new Point(30, 30);
            label10.Name = "label10";
            label10.Size = new Size(159, 37);
            label10.TabIndex = 28;
            label10.Text = "Get Started";
            // 
            // frmregister
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(289, 489);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(checkbxshowpass);
            Controls.Add(txtComPassword);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            Controls.Add(txtUsername);
            Controls.Add(label9);
            Controls.Add(label10);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmregister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmlogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label6;
        private Button button3;
        private Button button4;
        private CheckBox checkbxshowpass;
        private TextBox txtComPassword;
        private Label label7;
        private TextBox txtPassword;
        private Label label8;
        private TextBox txtUsername;
        private Label label9;
        private Label label10;
    }
}