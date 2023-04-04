namespace Login___Registration_System
{
    partial class frmRegister
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
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            checkkbxShowPassword = new CheckBox();
            txtpassword = new TextBox();
            label3 = new Label();
            txtusername = new TextBox();
            Username = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(116, 86, 174);
            label5.Location = new Point(58, 455);
            label5.Name = "label5";
            label5.Size = new Size(168, 25);
            label5.TabIndex = 26;
            label5.Text = "Creat An Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 410);
            label4.Name = "label4";
            label4.Size = new Size(152, 17);
            label4.TabIndex = 27;
            label4.Text = "Don't Have An Account";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(35, 360);
            button2.Name = "button2";
            button2.Size = new Size(215, 35);
            button2.TabIndex = 24;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 85, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 313);
            button1.Name = "button1";
            button1.Size = new Size(215, 35);
            button1.TabIndex = 25;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkkbxShowPassword
            // 
            checkkbxShowPassword.AutoSize = true;
            checkkbxShowPassword.Cursor = Cursors.Hand;
            checkkbxShowPassword.FlatStyle = FlatStyle.Flat;
            checkkbxShowPassword.Location = new Point(64, 271);
            checkkbxShowPassword.Name = "checkkbxShowPassword";
            checkkbxShowPassword.Size = new Size(119, 21);
            checkkbxShowPassword.TabIndex = 23;
            checkkbxShowPassword.Text = "Show Password";
            checkkbxShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(230, 231, 233);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(35, 240);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(215, 25);
            txtpassword.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 215);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(230, 231, 233);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(35, 177);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(215, 25);
            txtusername.TabIndex = 22;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(35, 152);
            Username.Name = "Username";
            Username.Size = new Size(69, 17);
            Username.TabIndex = 20;
            Username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(35, 90);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 18;
            label1.Text = "Get Started";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkkbxShowPassword);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtusername);
            Controls.Add(Username);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Button button2;
        private Button button1;
        private CheckBox checkkbxShowPassword;
        private TextBox txtpassword;
        private Label label3;
        private TextBox txtusername;
        private Label Username;
        private Label label1;
    }
}