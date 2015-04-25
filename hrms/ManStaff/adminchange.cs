using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hrms.ManStaff
{
    public partial class adminchange : Form
    {
        public adminchange()
        {
            InitializeComponent();
        }

        private void adminchange_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "server=.;database=hrms;uid=sa;pwd=123456;";
            SqlConnection con = new SqlConnection(sql);
            con.Open();
            string sqlad = "select name form ygdl where name = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlad, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdlad = cmd.ExecuteReader();
            if (sdlad.Read())
                textBox2.Text += sqlad[0];
            else
            {
                MessageBox.Show(" ");
            }
        }
    }
}
