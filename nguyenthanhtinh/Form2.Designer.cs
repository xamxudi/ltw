namespace sql
{
    partial class Form2
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
            this.dvgCustomer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btexit = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btread = new System.Windows.Forms.Button();
            this.tbdc = new System.Windows.Forms.TextBox();
            this.tbcv = new System.Windows.Forms.TextBox();
            this.tbml = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.btf = new System.Windows.Forms.Button();
            this.bttk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCustomer
            // 
            this.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvgCustomer.Location = new System.Drawing.Point(44, 0);
            this.dvgCustomer.Name = "dvgCustomer";
            this.dvgCustomer.Size = new System.Drawing.Size(649, 150);
            this.dvgCustomer.TabIndex = 6;
            this.dvgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomer_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ma";
            this.id.Name = "id";
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên Nhân Viên";
            this.ten.Name = "ten";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Địa Chỉ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Chức vụ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "mức lương";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hình ảnh";
            this.Column4.Name = "Column4";
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(635, 381);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 10;
            this.btexit.Text = "thoat";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(535, 381);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(75, 23);
            this.btedit.TabIndex = 9;
            this.btedit.Text = "sua";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(444, 381);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 8;
            this.btdelete.Text = "xoa";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(349, 381);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 7;
            this.btadd.Text = "them";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(77, 211);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(159, 20);
            this.tbid.TabIndex = 11;
            this.tbid.TextChanged += new System.EventHandler(this.tbid_TextChanged);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(77, 247);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(159, 20);
            this.tbname.TabIndex = 12;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "mã";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-5, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên nhân viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btread
            // 
            this.btread.Location = new System.Drawing.Point(-7, 381);
            this.btread.Name = "btread";
            this.btread.Size = new System.Drawing.Size(75, 23);
            this.btread.TabIndex = 15;
            this.btread.Text = "doc du lieu";
            this.btread.UseVisualStyleBackColor = true;
            this.btread.Click += new System.EventHandler(this.btread_Click);
            // 
            // tbdc
            // 
            this.tbdc.Location = new System.Drawing.Point(77, 278);
            this.tbdc.Name = "tbdc";
            this.tbdc.Size = new System.Drawing.Size(159, 20);
            this.tbdc.TabIndex = 16;
            this.tbdc.TextChanged += new System.EventHandler(this.tbdc_TextChanged);
            // 
            // tbcv
            // 
            this.tbcv.Location = new System.Drawing.Point(77, 304);
            this.tbcv.Name = "tbcv";
            this.tbcv.Size = new System.Drawing.Size(159, 20);
            this.tbcv.TabIndex = 17;
            this.tbcv.TextChanged += new System.EventHandler(this.tbcv_TextChanged);
            // 
            // tbml
            // 
            this.tbml.Location = new System.Drawing.Point(77, 330);
            this.tbml.Name = "tbml";
            this.tbml.Size = new System.Drawing.Size(159, 20);
            this.tbml.TabIndex = 18;
            this.tbml.TextChanged += new System.EventHandler(this.tbml_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Địa chỉ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "chức vụ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "mức lương";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(340, 169);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(100, 98);
            this.img.TabIndex = 22;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // btf
            // 
            this.btf.Location = new System.Drawing.Point(461, 232);
            this.btf.Name = "btf";
            this.btf.Size = new System.Drawing.Size(75, 23);
            this.btf.TabIndex = 23;
            this.btf.Text = "chon";
            this.btf.UseVisualStyleBackColor = true;
            this.btf.Click += new System.EventHandler(this.btf_Click);
            // 
            // bttk
            // 
            this.bttk.Location = new System.Drawing.Point(44, 156);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(234, 35);
            this.bttk.TabIndex = 32;
            this.bttk.Text = "Thông kê khuc vực";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 488);
            this.Controls.Add(this.bttk);
            this.Controls.Add(this.btf);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbml);
            this.Controls.Add(this.tbcv);
            this.Controls.Add(this.tbdc);
            this.Controls.Add(this.btread);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.dvgCustomer);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btadd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCustomer;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btread;
        private System.Windows.Forms.TextBox tbdc;
        private System.Windows.Forms.TextBox tbcv;
        private System.Windows.Forms.TextBox tbml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btf;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}