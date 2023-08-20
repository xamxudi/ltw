namespace sql
{
    partial class Form3
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
            this.linkLabel_dk = new System.Windows.Forms.LinkLabel();
            this.button_dn = new System.Windows.Forms.Button();
            this.linkLabel_qmk = new System.Windows.Forms.LinkLabel();
            this.textBox_mk = new System.Windows.Forms.TextBox();
            this.textBox_tk = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_dk
            // 
            this.linkLabel_dk.AutoSize = true;
            this.linkLabel_dk.Location = new System.Drawing.Point(373, 346);
            this.linkLabel_dk.Name = "linkLabel_dk";
            this.linkLabel_dk.Size = new System.Drawing.Size(47, 13);
            this.linkLabel_dk.TabIndex = 23;
            this.linkLabel_dk.TabStop = true;
            this.linkLabel_dk.Text = "Đăng ký";
            this.linkLabel_dk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dk_LinkClicked);
            // 
            // button_dn
            // 
            this.button_dn.Location = new System.Drawing.Point(286, 392);
            this.button_dn.Name = "button_dn";
            this.button_dn.Size = new System.Drawing.Size(141, 31);
            this.button_dn.TabIndex = 22;
            this.button_dn.Text = "Đăng Nhập";
            this.button_dn.UseVisualStyleBackColor = true;
            this.button_dn.Click += new System.EventHandler(this.button_dn_Click);
            // 
            // linkLabel_qmk
            // 
            this.linkLabel_qmk.AutoSize = true;
            this.linkLabel_qmk.Location = new System.Drawing.Point(239, 346);
            this.linkLabel_qmk.Name = "linkLabel_qmk";
            this.linkLabel_qmk.Size = new System.Drawing.Size(80, 13);
            this.linkLabel_qmk.TabIndex = 21;
            this.linkLabel_qmk.TabStop = true;
            this.linkLabel_qmk.Text = "Quên mật khẩu";
            // 
            // textBox_mk
            // 
            this.textBox_mk.Location = new System.Drawing.Point(239, 285);
            this.textBox_mk.Multiline = true;
            this.textBox_mk.Name = "textBox_mk";
            this.textBox_mk.PasswordChar = '*';
            this.textBox_mk.Size = new System.Drawing.Size(243, 34);
            this.textBox_mk.TabIndex = 18;
            // 
            // textBox_tk
            // 
            this.textBox_tk.Location = new System.Drawing.Point(239, 231);
            this.textBox_tk.Multiline = true;
            this.textBox_tk.Name = "textBox_tk";
            this.textBox_tk.Size = new System.Drawing.Size(243, 34);
            this.textBox_tk.TabIndex = 17;
            this.textBox_tk.Tag = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sql.Properties.Resources.b;
            this.pictureBox3.Location = new System.Drawing.Point(226, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(245, 213);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sql.Properties.Resources.png_transparent_computer_icons_password_login_user_privacy_miscellaneous_christianity_rectangle_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(138, 285);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sql.Properties.Resources.user_icon_in_trendy_flat_style_isolated_on_grey_background_user_symbol_for_your_web_site_design_logo_app_ui_illustration_eps10_free_vector;
            this.pictureBox1.Location = new System.Drawing.Point(138, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(242, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "hiện thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 435);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel_dk);
            this.Controls.Add(this.button_dn);
            this.Controls.Add(this.linkLabel_qmk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox_mk);
            this.Controls.Add(this.textBox_tk);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_dk;
        private System.Windows.Forms.Button button_dn;
        private System.Windows.Forms.LinkLabel linkLabel_qmk;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_mk;
        private System.Windows.Forms.TextBox textBox_tk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}