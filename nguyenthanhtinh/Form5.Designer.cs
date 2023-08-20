namespace sql
{
    partial class Form5
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
            this.btkq = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCustomer
            // 
            this.dvgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4});
            this.dvgCustomer.Location = new System.Drawing.Point(12, 3);
            this.dvgCustomer.Name = "dvgCustomer";
            this.dvgCustomer.Size = new System.Drawing.Size(544, 150);
            this.dvgCustomer.TabIndex = 0;
            this.dvgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomer_CellContentClick);
            // 
            // btkq
            // 
            this.btkq.Location = new System.Drawing.Point(58, 281);
            this.btkq.Name = "btkq";
            this.btkq.Size = new System.Drawing.Size(224, 23);
            this.btkq.TabIndex = 1;
            this.btkq.Text = "Đọc Kết Quả";
            this.btkq.UseVisualStyleBackColor = true;
            this.btkq.Click += new System.EventHandler(this.btkq_Click);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã";
            this.Column3.Name = "Column3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quản Lý Trưởng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Khu vực";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chi trả";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Doanh thu";
            this.Column4.Name = "Column4";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(45, 181);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(325, 20);
            this.tb.TabIndex = 2;
            this.tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 372);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btkq);
            this.Controls.Add(this.dvgCustomer);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCustomer;
        private System.Windows.Forms.Button btkq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox tb;
    }
}