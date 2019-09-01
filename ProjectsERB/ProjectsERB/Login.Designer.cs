namespace ProjectsERB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.pb_show_hied_pass = new System.Windows.Forms.Button();
            this.span_required_filed = new System.Windows.Forms.Label();
            this.span_pa = new System.Windows.Forms.Label();
            this.span_us = new System.Windows.Forms.Label();
            this.btn_lgn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_usrname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(514, 87);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(147, 18);
            this.date.TabIndex = 73;
            this.date.Text = "Friday, March 6 2015";
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(228)))));
            this.time.Location = new System.Drawing.Point(247, 72);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(245, 46);
            this.time.TabIndex = 72;
            this.time.Text = "00:00:00 AM";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_show_hied_pass
            // 
            this.pb_show_hied_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_show_hied_pass.BackColor = System.Drawing.Color.Transparent;
            this.pb_show_hied_pass.BackgroundImage = global::ProjectsERB.Properties.Resources.eye_inv;
            this.pb_show_hied_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_show_hied_pass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pb_show_hied_pass.FlatAppearance.BorderSize = 0;
            this.pb_show_hied_pass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.pb_show_hied_pass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.pb_show_hied_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pb_show_hied_pass.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_show_hied_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pb_show_hied_pass.Location = new System.Drawing.Point(222, 267);
            this.pb_show_hied_pass.Name = "pb_show_hied_pass";
            this.pb_show_hied_pass.Size = new System.Drawing.Size(45, 39);
            this.pb_show_hied_pass.TabIndex = 71;
            this.pb_show_hied_pass.UseVisualStyleBackColor = false;
            this.pb_show_hied_pass.Click += new System.EventHandler(this.pb_show_hied_pass_Click);
            // 
            // span_required_filed
            // 
            this.span_required_filed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.span_required_filed.AutoSize = true;
            this.span_required_filed.BackColor = System.Drawing.Color.Transparent;
            this.span_required_filed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.span_required_filed.ForeColor = System.Drawing.Color.HotPink;
            this.span_required_filed.Location = new System.Drawing.Point(196, 164);
            this.span_required_filed.Name = "span_required_filed";
            this.span_required_filed.Size = new System.Drawing.Size(129, 14);
            this.span_required_filed.TabIndex = 70;
            this.span_required_filed.Text = "span_required_filed";
            this.span_required_filed.Visible = false;
            // 
            // span_pa
            // 
            this.span_pa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.span_pa.AutoSize = true;
            this.span_pa.BackColor = System.Drawing.Color.Transparent;
            this.span_pa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.span_pa.ForeColor = System.Drawing.Color.HotPink;
            this.span_pa.Location = new System.Drawing.Point(196, 316);
            this.span_pa.Name = "span_pa";
            this.span_pa.Size = new System.Drawing.Size(59, 14);
            this.span_pa.TabIndex = 69;
            this.span_pa.Text = "span_pa";
            this.span_pa.Visible = false;
            // 
            // span_us
            // 
            this.span_us.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.span_us.AutoSize = true;
            this.span_us.BackColor = System.Drawing.Color.Transparent;
            this.span_us.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.span_us.ForeColor = System.Drawing.Color.HotPink;
            this.span_us.Location = new System.Drawing.Point(196, 246);
            this.span_us.Name = "span_us";
            this.span_us.Size = new System.Drawing.Size(58, 14);
            this.span_us.TabIndex = 68;
            this.span_us.Text = "span_us";
            this.span_us.Visible = false;
            // 
            // btn_lgn
            // 
            this.btn_lgn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lgn.BackColor = System.Drawing.Color.Transparent;
            this.btn_lgn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_lgn.FlatAppearance.BorderSize = 4;
            this.btn_lgn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btn_lgn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.btn_lgn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lgn.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lgn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_lgn.Location = new System.Drawing.Point(303, 364);
            this.btn_lgn.Name = "btn_lgn";
            this.btn_lgn.Size = new System.Drawing.Size(202, 105);
            this.btn_lgn.TabIndex = 66;
            this.btn_lgn.Text = "تسجيل دخول";
            this.btn_lgn.UseVisualStyleBackColor = false;
            this.btn_lgn.Click += new System.EventHandler(this.btn_lgn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(521, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(497, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "اسم المستخدم";
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(273, 268);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(185, 39);
            this.txt_password.TabIndex = 63;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_usrname
            // 
            this.txt_usrname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_usrname.Font = new System.Drawing.Font("Tahoma", 20.25F);
            this.txt_usrname.Location = new System.Drawing.Point(273, 194);
            this.txt_usrname.Multiline = true;
            this.txt_usrname.Name = "txt_usrname";
            this.txt_usrname.Size = new System.Drawing.Size(185, 40);
            this.txt_usrname.TabIndex = 62;
            this.txt_usrname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ProjectsERB.Properties.Resources.Person_Male_Light_icon;
            this.pictureBox1.Location = new System.Drawing.Point(662, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 193);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProjectsERB.Properties.Resources.back_log;
            this.ClientSize = new System.Drawing.Size(954, 574);
            this.Controls.Add(this.date);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pb_show_hied_pass);
            this.Controls.Add(this.span_required_filed);
            this.Controls.Add(this.span_pa);
            this.Controls.Add(this.span_us);
            this.Controls.Add(this.btn_lgn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usrname);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل دخول";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button pb_show_hied_pass;
        private System.Windows.Forms.Label span_required_filed;
        private System.Windows.Forms.Label span_pa;
        private System.Windows.Forms.Label span_us;
        private System.Windows.Forms.Button btn_lgn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        public System.Windows.Forms.TextBox txt_usrname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;

    }
}

