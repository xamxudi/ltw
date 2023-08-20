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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            if (item == "Học kì 1(2022-2023)")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from m1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6));
                    }
                }


                conn.Close();
                //dk2



            }
            if (item == "Học kì 2(2022-2023)")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from m2", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6));
                    }
                }


                conn.Close();
                //dk2



            }
            if (item == "Học kì 1(2023-2024)")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from m3", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6));
                    }
                }


                conn.Close();
                //dk2



            }
            if (item == "Học kì 2(2023-2024)")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from m4", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6));
                    }
                }


                conn.Close();
                //dk2



            }


        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
