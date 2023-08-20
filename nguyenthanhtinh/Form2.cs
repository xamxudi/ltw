using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    public partial class Form2 : Form
    {
        private int index;
        public Form2()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "")
            {
                MessageBox.Show("mã nhân viên không được để trống");
            }
            else
            {
                if (tbid.Text != "")
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6SI5LJP\TK;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Customer values(N'" + tbid.Text + "',N'" + tbname.Text + "',N'" + tbdc.Text + "',N'" + tbcv.Text + "',N'" + tbml.Text + "')", conn);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                   
                }
            }
        }
        private void Form2_load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6SI5LJP\TK;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4));
                }
            }

            conn.Close();
        }

        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbid.Text = dvgCustomer.Rows[idx].Cells[0].Value.ToString();
            tbname.Text = dvgCustomer.Rows[idx].Cells[1].Value.ToString();
            tbdc.Text = dvgCustomer.Rows[idx].Cells[2].Value.ToString();
            tbcv.Text = dvgCustomer.Rows[idx].Cells[3].Value.ToString();
            tbml.Text = dvgCustomer.Rows[idx].Cells[4].Value.ToString();
            
           

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6SI5LJP\TK;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tbid.Text = dvgCustomer.Rows[idx].Cells[0].Value.ToString();
                    tbname.Text = dvgCustomer.Rows[idx].Cells[1].Value.ToString();
                    tbdc.Text = dvgCustomer.Rows[idx].Cells[0].Value.ToString();
                    tbcv.Text = dvgCustomer.Rows[idx].Cells[1].Value.ToString();
                    tbml.Text = dvgCustomer.Rows[idx].Cells[0].Value.ToString();
                    

                   
                   
                }
            }

            conn.Close();
            

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6SI5LJP\TK;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Customer where id="+tbid.Text, conn);
            
            cmd.ExecuteNonQuery();
            conn.Close();
            int idx = dvgCustomer.CurrentCell.RowIndex;

            dvgCustomer.Rows.RemoveAt(index);
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6SI5LJP\TK;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Customer set Name='"+tbname.Text+"'where id= " +tbid,conn);

            
            conn.Close();
            int idx = dvgCustomer.CurrentCell.RowIndex;
            dvgCustomer.Rows[idx].Cells[1].Value = tbname.Text;
        }

        private void btread_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6SI5LJP\TK;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4));
                }
            }

            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btf_Click(object sender, EventArgs e)
        {
              img.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files(*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                img.ImageLocation = dlg.FileName;
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbdc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcv_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbml_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void img_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
