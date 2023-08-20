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
using Excel = Microsoft.Office.Interop.Excel;

using app = Microsoft.Office.Interop.Excel.Application;
using System.Security.AccessControl;

namespace sql
{
    public partial class Form6 : Form
    {
        private int index;

        public Form6()
        {
            InitializeComponent();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            Form7 f = new Form7();
            f.Show();
            
        }

        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from cs", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));

                }
            }

            conn.Close();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from kq", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer1.Rows.Add(reader.GetString(0), reader.GetInt32(1),reader.GetInt32(2));

                }
            }

            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from hocphan", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer3.Rows.Add(reader.GetString(0), reader.GetInt32(1), reader.GetString(2));

                }
            }

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form8 f = new Form8();
            f.Show();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            // SqlCommand cmd = new SqlCommand("select * from cs WHERE gioitinh = '%" + tim.Text + "%' ", conn);
            SqlCommand cmd = new SqlCommand("select * from cs Where name = '" + tim.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));

                }
            }

            conn.Close();
        }
        public void LoadGridByKeyword()
        {

           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from cs where ma =" + mssv.Text, conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dvgCustomer.CurrentCell.RowIndex;

            dvgCustomer.Rows.RemoveAt(index);
            MessageBox.Show("Xóa Thành Công");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from cs", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));

                }
            }

            conn.Close();
        }
        //EXECL
        private void exportExecl(DataGridView g,string duongDan ,string tentap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 35;
            for (int i =1; i< g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i< g.Rows.Count; i++)
            {
                for (int j = 0; i < g.Columns.Count; j++)
                {
                    
                    
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tentap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }

        private void xuaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuấtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportExecl(dvgCustomer, @"D:\", "asd");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }

        private void btkt_Click(object sender, EventArgs e)
        {
            if (ma.Text == "" || hocki.Text == "")
            {
                MessageBox.Show("Vui long nhập  mã môn học và học kì");
            }
            if (ma.Text == "211" && hocki.Text == "hoc ki 1")
            {
                MessageBox.Show("Ngành công nghệ thông tin ,học kì 1 50 tc");
            }
            if (ma.Text == "211" && hocki.Text == "hoc ki 2")
            {
                MessageBox.Show("Ngành công nghệ thông tin ,học kì 2 60 tc");
            }
            if (ma.Text == "212" && hocki.Text == "hoc ki 1")
            {
                MessageBox.Show("Ngành Quản trị Kinh Doanh ,học kì 1 25 tc");
            }
            if (ma.Text == "212" && hocki.Text == "hoc ki 2")
            {
                MessageBox.Show("Ngành Quản trị Kinh Doanh ,học kì 2 32 tc");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form11 f = new Form11();
            f.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 f = new Form12();
            f.Show();

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form13 f = new Form13();
            f.Show();
        }
    }
}
