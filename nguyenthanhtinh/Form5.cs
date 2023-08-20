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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btkq_Click(object sender, EventArgs e)
        {
         
         
        

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=D21316;Persist Security Info=True;User ID=sa;Password=***********;Initial Catalog=sale;User Id=sa;Password=12");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from cs", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dvgCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
                }
            }

            conn.Close();

            //

        }

        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}
//reader.GetInt32(0)
//reader.GetString(1)