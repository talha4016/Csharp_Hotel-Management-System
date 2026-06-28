namespace Hotel_Management_System_Database
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.signin_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.signin_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_showpassword = new System.Windows.Forms.CheckBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_registrationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(298, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back, User";
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.txtusername.Location = new System.Drawing.Point(305, 124);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(92, 22);
            this.txtusername.TabIndex = 2;
            this.txtusername.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.txtpassword.Location = new System.Drawing.Point(305, 193);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(89, 22);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.Text = "Password";
            // 
            // signin_username
            // 
            this.signin_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signin_username.DefaultText = "";
            this.signin_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signin_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signin_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signin_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signin_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signin_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signin_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signin_username.Location = new System.Drawing.Point(304, 150);
            this.signin_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signin_username.Name = "signin_username";
            this.signin_username.PlaceholderText = "";
            this.signin_username.SelectedText = "";
            this.signin_username.Size = new System.Drawing.Size(265, 31);
            this.signin_username.TabIndex = 4;
            this.signin_username.TextChanged += new System.EventHandler(this.TextBox_username_TextChanged);
            // 
            // signin_password
            // 
            this.signin_password.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.signin_password.DefaultText = "";
            this.signin_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signin_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signin_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signin_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signin_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signin_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signin_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signin_password.Location = new System.Drawing.Point(304, 219);
            this.signin_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signin_password.Name = "signin_password";
            this.signin_password.PasswordChar = '*';
            this.signin_password.PlaceholderText = "";
            this.signin_password.SelectedText = "";
            this.signin_password.Size = new System.Drawing.Size(265, 31);
            this.signin_password.TabIndex = 5;
            // 
            // register_showpassword
            // 
            this.register_showpassword.AutoSize = true;
            this.register_showpassword.Location = new System.Drawing.Point(308, 261);
            this.register_showpassword.Name = "register_showpassword";
            this.register_showpassword.Size = new System.Drawing.Size(125, 20);
            this.register_showpassword.TabIndex = 6;
            this.register_showpassword.Text = "Show Password";
            this.register_showpassword.UseVisualStyleBackColor = true;
            this.register_showpassword.CheckedChanged += new System.EventHandler(this.register_showpassword_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(377, 302);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(153, 35);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Sign In";
            this.guna2Button1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.LowerCase;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.login_registrationBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 391);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // login_registrationBtn
            // 
            this.login_registrationBtn.Animated = true;
            this.login_registrationBtn.BackColor = System.Drawing.Color.White;
            this.login_registrationBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.login_registrationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_registrationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_registrationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_registrationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_registrationBtn.FillColor = System.Drawing.Color.White;
            this.login_registrationBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_registrationBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.login_registrationBtn.Location = new System.Drawing.Point(28, 331);
            this.login_registrationBtn.Name = "login_registrationBtn";
            this.login_registrationBtn.Size = new System.Drawing.Size(231, 34);
            this.login_registrationBtn.TabIndex = 9;
            this.login_registrationBtn.Text = "Register";
            this.login_registrationBtn.Click += new System.EventHandler(this.login_registrationBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Create new account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hotel Management System";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Close.Location = new System.Drawing.Point(579, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(18, 18);
            this.Close.TabIndex = 9;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Management_System_Database.Properties.Resources.pic_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(69, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 391);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.register_showpassword);
            this.Controls.Add(this.signin_password);
            this.Controls.Add(this.signin_username);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Majestic Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtusername;
        private System.Windows.Forms.Label txtpassword;
        private Guna.UI2.WinForms.Guna2TextBox signin_username;
        private Guna.UI2.WinForms.Guna2TextBox signin_password;
        private System.Windows.Forms.CheckBox register_showpassword;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button login_registrationBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Close;
    }
}

