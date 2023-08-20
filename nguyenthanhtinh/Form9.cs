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
using Excel = Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace sql
{
    public partial class Form9 : Form
    {
        private int index;

        public Form9()
        {
            InitializeComponent();
        }

        private void mssv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
         
        }

        private void btadd_Click(object sender, EventArgs e)
        {


           

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
                        SqlCommand cmd = new SqlCommand("insert into diem values(N'" + mssv.Text + "',N'" + ht.Text + "',N'" + mh.Text + "',N'" + dtx.Text + "',N'" + ck.Text + "',N'" + hp.Text + "',N'" + textBox2.Text + "')", conn);
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        int idx = dvgCustomer.CurrentCell.RowIndex;
                        dvgCustomer.Rows[idx].Cells[0].Value = mssv.Text;
                        dvgCustomer.Rows[idx].Cells[1].Value = ht.Text;
                        dvgCustomer.Rows[idx].Cells[2].Value = mh.Text;
                        dvgCustomer.Rows[idx].Cells[3].Value = dtx.Text;
                        dvgCustomer.Rows[idx].Cells[4].Value = ck.Text;
                        dvgCustomer.Rows[idx].Cells[5].Value = hp.Text;
                        dvgCustomer.Rows[idx].Cells[7].Value = textBox2.Text;
                        dvgCustomer.Rows[idx].Cells[6].Value = pictureBox1.Image;

                        MessageBox.Show("Thêm Thành Công");

                    }
                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE diem SET diemtx ='" + dtx.Text + "',cuoiki='" + ck.Text+"','"+hp.Text+"',where ma= " + mssv, conn);
            cmd.Connection = conn;
            
            conn.Close();
            int idx = dvgCustomer.CurrentCell.RowIndex;
            dvgCustomer.Rows[idx].Cells[3].Value = dtx.Text;
            dvgCustomer.Rows[idx].Cells[4].Value = ck.Text;
            dvgCustomer.Rows[idx].Cells[5].Value = hp.Text;
        }

        private void bttim_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from diem WHERE ten like '%" + tim.Text +"%' ", conn);
            //SqlCommand cmd = new SqlCommand("select * from cs Where name = '" + tim.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(3));
                }
            }
            cmd.Connection = conn;
            

            conn.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form6 f = new Form6();
            f.Show();
        }
        private void exportExecl(DataGridView g, string duongDan, string tentap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; i < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tentap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;

        }

        private void xuấtFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportExecl(dvgCustomer, @"D:\", "asad");
        }

        private void tim_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from diem WHERE hocphan > 5  ", conn);
            //SqlCommand cmd = new SqlCommand("select * from cs Where name = '" + tim.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(3));
                    MessageBox.Show("DÁCH SACH HỌC Phần  > 5 QUA MÔN");
                }
            }
            cmd.Connection = conn;


            conn.Close();
        }

        private void kt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
        //    DataTable dataTable = new DataTable();
        //    DataColumn col1 = new DataColumn("ma");
        //    DataColumn col2 = new DataColumn("ten");
        //    DataColumn col3 = new DataColumn("monhoc");
        //    DataColumn col4 = new DataColumn("diemtx");
        //    DataColumn col5 = new DataColumn("cuoiki");
        //    DataColumn col6 = new DataColumn("hocphan");

        //    dataTable.Columns.Add(col1);
        //    dataTable.Columns.Add(col2);
        //    dataTable.Columns.Add(col3);
        //    dataTable.Columns.Add(col4);
        //    dataTable.Columns.Add(col5);
        //    dataTable.Columns.Add(col6);
        //    foreach (DataGridViewRow dtgvRow in dvgCustomer.Rows)
        //    {
        //        DataRow dtrow = dataTable.NewRow();

        //        dtrow[0] = dtgvRow.Cells[0].Value;
        //        dtrow[1] = dtgvRow.Cells[0].Value;
        //        dtrow[2] = dtgvRow.Cells[0].Value;
        //        dtrow[3] = dtgvRow.Cells[0].Value;
        //        dtrow[4] = dtgvRow.Cells[0].Value;
        //        dtrow[5] = dtgvRow.Cells[0].Value;
        //        dataTable.Rows.Add(dtrow);

        //    }
        //    ExportFile(dataTable, "danh sach", "đáasdasd");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            
            //
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter=openFileDialog1.Filter = "JPEG files(*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                textBox2.Text = openFileDialog1.SafeFileName;
                

            }
        }

        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from diem", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(3));
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from diem where ma =" + mssv.Text, conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dvgCustomer.CurrentCell.RowIndex;

            dvgCustomer.Rows.RemoveAt(index);
            MessageBox.Show("Xóa Thành Công");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from diem WHERE hocphan < 5  ", conn);
            //SqlCommand cmd = new SqlCommand("select * from cs Where name = '" + tim.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(3));
                    MessageBox.Show("DÁCH SACH HỌC Phần  < 5 Rớt Môn");
                }
            }
            cmd.Connection = conn;


            conn.Close();
        }

        
       
       
    }
}

