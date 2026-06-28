namespace Hotel_Management_System_Database
{
    partial class admin_rooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.room_updatebtn = new System.Windows.Forms.Button();
            this.room_deletebtn = new System.Windows.Forms.Button();
            this.room_clearbtn = new System.Windows.Forms.Button();
            this.room_Addbtn = new System.Windows.Forms.Button();
            this.room_importbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.room_picture = new System.Windows.Forms.PictureBox();
            this.room_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.room_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.room_roomName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.room_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.room_roomID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.dataGridView1);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(22, 17);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(961, 384);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Room\'s Data";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 288);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.room_updatebtn);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_deletebtn);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_clearbtn);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_Addbtn);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_importbtn);
            this.guna2CustomGradientPanel2.Controls.Add(this.panel1);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_status);
            this.guna2CustomGradientPanel2.Controls.Add(this.label6);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_price);
            this.guna2CustomGradientPanel2.Controls.Add(this.label4);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_roomName);
            this.guna2CustomGradientPanel2.Controls.Add(this.label3);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_type);
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.Controls.Add(this.room_roomID);
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(22, 422);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(961, 277);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // room_updatebtn
            // 
            this.room_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.room_updatebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_updatebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.room_updatebtn.Location = new System.Drawing.Point(289, 189);
            this.room_updatebtn.Name = "room_updatebtn";
            this.room_updatebtn.Size = new System.Drawing.Size(105, 53);
            this.room_updatebtn.TabIndex = 33;
            this.room_updatebtn.Text = "Update";
            this.room_updatebtn.UseVisualStyleBackColor = false;
            this.room_updatebtn.Click += new System.EventHandler(this.room_updatebtn_Click);
            // 
            // room_deletebtn
            // 
            this.room_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.room_deletebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.room_deletebtn.Location = new System.Drawing.Point(428, 189);
            this.room_deletebtn.Name = "room_deletebtn";
            this.room_deletebtn.Size = new System.Drawing.Size(105, 53);
            this.room_deletebtn.TabIndex = 32;
            this.room_deletebtn.Text = "Delete";
            this.room_deletebtn.UseVisualStyleBackColor = false;
            this.room_deletebtn.Click += new System.EventHandler(this.room_deletebtn_Click);
            // 
            // room_clearbtn
            // 
            this.room_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.room_clearbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_clearbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.room_clearbtn.Location = new System.Drawing.Point(569, 189);
            this.room_clearbtn.Name = "room_clearbtn";
            this.room_clearbtn.Size = new System.Drawing.Size(105, 53);
            this.room_clearbtn.TabIndex = 31;
            this.room_clearbtn.Text = "Clear";
            this.room_clearbtn.UseVisualStyleBackColor = false;
            this.room_clearbtn.Click += new System.EventHandler(this.room_clearbtn_Click);
            // 
            // room_Addbtn
            // 
            this.room_Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.room_Addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_Addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.room_Addbtn.Location = new System.Drawing.Point(146, 189);
            this.room_Addbtn.Name = "room_Addbtn";
            this.room_Addbtn.Size = new System.Drawing.Size(105, 53);
            this.room_Addbtn.TabIndex = 30;
            this.room_Addbtn.Text = "Add";
            this.room_Addbtn.UseVisualStyleBackColor = false;
            this.room_Addbtn.Click += new System.EventHandler(this.room_Addbtn_Click);
            // 
            // room_importbtn
            // 
            this.room_importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.room_importbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_importbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.room_importbtn.Location = new System.Drawing.Point(839, 153);
            this.room_importbtn.Name = "room_importbtn";
            this.room_importbtn.Size = new System.Drawing.Size(105, 40);
            this.room_importbtn.TabIndex = 25;
            this.room_importbtn.Text = "Import";
            this.room_importbtn.UseVisualStyleBackColor = false;
            this.room_importbtn.Click += new System.EventHandler(this.room_importbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.room_picture);
            this.panel1.Location = new System.Drawing.Point(839, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 120);
            this.panel1.TabIndex = 24;
            // 
            // room_picture
            // 
            this.room_picture.Location = new System.Drawing.Point(0, 0);
            this.room_picture.Name = "room_picture";
            this.room_picture.Size = new System.Drawing.Size(105, 120);
            this.room_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.room_picture.TabIndex = 0;
            this.room_picture.TabStop = false;
            // 
            // room_status
            // 
            this.room_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_status.FormattingEnabled = true;
            this.room_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Occupied"});
            this.room_status.Location = new System.Drawing.Point(585, 66);
            this.room_status.Name = "room_status";
            this.room_status.Size = new System.Drawing.Size(206, 33);
            this.room_status.TabIndex = 23;
            this.room_status.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(478, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Status:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // room_price
            // 
            this.room_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_price.Location = new System.Drawing.Point(585, 20);
            this.room_price.Name = "room_price";
            this.room_price.Size = new System.Drawing.Size(158, 30);
            this.room_price.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price ($):";
            // 
            // room_roomName
            // 
            this.room_roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_roomName.Location = new System.Drawing.Point(146, 119);
            this.room_roomName.Name = "room_roomName";
            this.room_roomName.Size = new System.Drawing.Size(206, 30);
            this.room_roomName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Room Name:";
            // 
            // room_type
            // 
            this.room_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_type.FormattingEnabled = true;
            this.room_type.Items.AddRange(new object[] {
            "Single Room",
            "Double Room"});
            this.room_type.Location = new System.Drawing.Point(146, 60);
            this.room_type.Name = "room_type";
            this.room_type.Size = new System.Drawing.Size(206, 33);
            this.room_type.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Type:";
            // 
            // room_roomID
            // 
            this.room_roomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_roomID.Location = new System.Drawing.Point(146, 13);
            this.room_roomID.Name = "room_roomID";
            this.room_roomID.Size = new System.Drawing.Size(172, 30);
            this.room_roomID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Room ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admin_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "admin_rooms";
            this.Size = new System.Drawing.Size(1010, 714);
            this.Load += new System.EventHandler(this.admin_rooms_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.room_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox room_roomID;
        private System.Windows.Forms.TextBox room_roomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox room_type;
        private System.Windows.Forms.ComboBox room_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox room_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button room_importbtn;
        private System.Windows.Forms.PictureBox room_picture;
        private System.Windows.Forms.Button room_updatebtn;
        private System.Windows.Forms.Button room_deletebtn;
        private System.Windows.Forms.Button room_clearbtn;
        private System.Windows.Forms.Button room_Addbtn;
    }
}
