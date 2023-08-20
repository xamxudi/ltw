using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sql
{
    public partial class Form8 : Form
    {
        private string ma;

        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {

            //if (mssv.Text == "")
            //{
            //    MessageBox.Show("mã nhân viên không được để trống");
            //}
            //else
            //{
            //    if (mssv.Text != "")
            //    {
            //        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6SI5LJP\TK;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            //        conn.Open();
            //        SqlCommand cmd = new SqlCommand("insert into cs values(N'" + mssv.Text + "',N'" + hoten.Text + "',N'" + gt.Text + "',N'" + ns.Text + "',N'" + k.Text + "',N'" + bdt.Text + ",N'" + ldt.Text + ",N'" + n.Text + ")", conn);
            //        cmd.Connection = conn;
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //    }
            //}



            if (mssv.Text == "")
            {
                MessageBox.Show("mã nhân viên không được để trống");
            }
            else
            {
                if (mssv.Text != "")
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Cs values(N'" + mssv.Text + "',N'" + hoten.Text + "',N'" + gt.Text + "',N'" + ns.Text + "',N'" + k.Text + "',N'"+bdt.Text+"',N'"+ ldt.Text +"',N'"+ n.Text +"')", conn);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Thêm thành công");

                }
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from cs", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    

                }
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update cs set name ='" + hoten.Text + "'where ma= " + mssv.Text, conn);
           

            conn.Close();
           


        }
    }
}
