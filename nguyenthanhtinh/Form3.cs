using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button_dn_Click(object sender, EventArgs e)
        {
            if ((textBox_tk.Text == "") && (textBox_mk.Text == ""))
            {
                MessageBox.Show("VUI VONG NHAP MAT KHAU");
            }
            if (((textBox_tk.Text == "a") && (textBox_mk.Text == "123")))
            {
                MessageBox.Show("đăng nhâp với với tài khoản admin");
                Form6 f = new Form6();
                f.Show();
            }
          
            else
            {
                if (((textBox_tk.Text != "a") || (textBox_mk.Text != "123")) || (textBox_tk.Text != "t"))
                {
                    MessageBox.Show("sai mat khau  MAT KHAU");
                }

            }
           
            //
        
            if (((textBox_tk.Text == "t") && (textBox_mk.Text == "123")))
            {
                MessageBox.Show("đăng nhâp với với tài khoản nhân viên");
                Form4 f = new Form4();
                f.Show();
            }

         

           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_mk.PasswordChar = (char)0;
            }
            else
            {
                textBox_mk.PasswordChar = '*';
            }
        }

        private void linkLabel_dk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
