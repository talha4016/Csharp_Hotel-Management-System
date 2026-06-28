namespace Hotel_Management_System_Database
{
    partial class Registration_Form
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
            this.Close = new System.Windows.Forms.Label();
            this.register_signupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.register_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.register_signinBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_cpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textconfirmpassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Close.Location = new System.Drawing.Point(580, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(18, 18);
            this.Close.TabIndex = 18;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // register_signupBtn
            // 
            this.register_signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.register_signupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.register_signupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.register_signupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register_signupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.register_signupBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.register_signupBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_signupBtn.ForeColor = System.Drawing.Color.White;
            this.register_signupBtn.Location = new System.Drawing.Point(370, 323);
            this.register_signupBtn.Name = "register_signupBtn";
            this.register_signupBtn.Size = new System.Drawing.Size(153, 35);
            this.register_signupBtn.TabIndex = 16;
            this.register_signupBtn.Text = "Sign Up";
            this.register_signupBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Location = new System.Drawing.Point(308, 288);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(125, 20);
            this.register_showPass.TabIndex = 15;
            this.register_showPass.Text = "Show Password";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // register_password
            // 
            this.register_password.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.register_password.DefaultText = "";
            this.register_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.register_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_password.Location = new System.Drawing.Point(308, 184);
            this.register_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.PlaceholderText = "";
            this.register_password.SelectedText = "";
            this.register_password.Size = new System.Drawing.Size(265, 31);
            this.register_password.TabIndex = 14;
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.txtpassword.Location = new System.Drawing.Point(309, 158);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(89, 22);
            this.txtpassword.TabIndex = 12;
            this.txtpassword.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.txtusername.Location = new System.Drawing.Point(309, 94);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(92, 22);
            this.txtusername.TabIndex = 11;
            this.txtusername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(303, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registration";
            // 
            // register_signinBtn
            // 
            this.register_signinBtn.Animated = true;
            this.register_signinBtn.BackColor = System.Drawing.Color.White;
            this.register_signinBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.register_signinBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.register_signinBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.register_signinBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register_signinBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.register_signinBtn.FillColor = System.Drawing.Color.White;
            this.register_signinBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_signinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.register_signinBtn.Location = new System.Drawing.Point(28, 336);
            this.register_signinBtn.Name = "register_signinBtn";
            this.register_signinBtn.Size = new System.Drawing.Size(231, 34);
            this.register_signinBtn.TabIndex = 9;
            this.register_signinBtn.Text = "Sign In";
            this.register_signinBtn.Click += new System.EventHandler(this.register_signinbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sign in your account";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.register_signinBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 391);
            this.panel1.TabIndex = 17;
            // 
            // register_cpassword
            // 
            this.register_cpassword.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.register_cpassword.DefaultText = "";
            this.register_cpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_cpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_cpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_cpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_cpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_cpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.register_cpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_cpassword.Location = new System.Drawing.Point(308, 250);
            this.register_cpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.register_cpassword.Name = "register_cpassword";
            this.register_cpassword.PasswordChar = '*';
            this.register_cpassword.PlaceholderText = "";
            this.register_cpassword.SelectedText = "";
            this.register_cpassword.Size = new System.Drawing.Size(265, 31);
            this.register_cpassword.TabIndex = 20;
            // 
            // textconfirmpassword
            // 
            this.textconfirmpassword.AutoSize = true;
            this.textconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textconfirmpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.textconfirmpassword.Location = new System.Drawing.Point(307, 224);
            this.textconfirmpassword.Name = "textconfirmpassword";
            this.textconfirmpassword.Size = new System.Drawing.Size(156, 22);
            this.textconfirmpassword.TabIndex = 19;
            this.textconfirmpassword.Text = "Confirm Password";
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
            // 
            // signup_username
            // 
            this.signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(308, 119);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(265, 27);
            this.signup_username.TabIndex = 21;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 391);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.register_cpassword);
            this.Controls.Add(this.textconfirmpassword);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.register_signupBtn);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration_Form";
            this.Text = "Registration_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Close;
        private Guna.UI2.WinForms.Guna2Button register_signupBtn;
        private System.Windows.Forms.CheckBox register_showPass;
        private Guna.UI2.WinForms.Guna2TextBox register_password;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.Label txtusername;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button register_signinBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox register_cpassword;
        private System.Windows.Forms.Label textconfirmpassword;
        private System.Windows.Forms.TextBox signup_username;
    }
}