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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedItem.ToString();
            if (item == "Học kì 1( 2022-2023)")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from dk1", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7));
                    }
                }
              

                conn.Close();
                //dk2
                
              

            }
            //dk2
            if (item == "Học kì 2( 2022-2023)")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("select * from dk2", conn1);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        dvgCustomer.Rows.Add(reader1.GetInt32(0), reader1.GetInt32(1), reader1.GetString(2), reader1.GetString(3), reader1.GetInt32(4), reader1.GetInt32(5), reader1.GetString(6), reader1.GetString(7));
                    }
                }

                conn1.Close();
            }
            if (item == "Học kì 1( 2023-2024)")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("select * from dk3", conn1);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        dvgCustomer.Rows.Add(reader1.GetInt32(0), reader1.GetInt32(1), reader1.GetString(2), reader1.GetString(3), reader1.GetInt32(4), reader1.GetInt32(5), reader1.GetString(6), reader1.GetString(7));
                    }
                }

                conn1.Close();
            }
            if (item == "Học kì 2( 2023-2024)")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("select * from dk4", conn1);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        dvgCustomer.Rows.Add(reader1.GetInt32(0), reader1.GetInt32(1), reader1.GetString(2), reader1.GetString(3), reader1.GetInt32(4), reader1.GetInt32(5), reader1.GetString(6), reader1.GetString(7));
                    }
                }

                conn1.Close();
            }

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
            
        }





        public int index { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }
    }
}
//reader.GetString(1)
