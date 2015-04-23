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

namespace hrms.ADD
{
    public partial class addStaff : Form
    {
        public addStaff()
        {
            InitializeComponent();
        }

        private void addStaff_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
            
            //cmd.CommandType = System.Data.CommandType.Text;
             string sqlins = "INSERT into ygdl (id,username,password,role) VALUES (@[id],@[username],@[password],@[role])";
            SqlCommand cmd = new SqlCommand(sqlins,conn);
            SqlParameter[] sql =
                                     {
                                         new SqlParameter("@[id]",this .textBox1.Text ),
                                         new SqlParameter("@[username]",this .textBox2.Text ),
                                         new SqlParameter("@[password]",this .textBox4.Text ),
                                         new SqlParameter("@[role]",this .textBox5.Text ),
                                         
                                     };
            MessageBox.Show(" ");
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            //SqlConnection conn = new SqlConnection("server=.;database=test;uid=sa;pwd=123456;");
            //string ConnectionString = "Data Source=.;Initial Catalog=hrms;Integrated_Security=True";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //string sql = "insert into ygdl(id,username,password,role) values(@id,@username,@password,@role)";
            //SqlParameter[] paras =
            //                     {
            //                         new SqlParameter("@id",this .textBox1.Text ),
            //                         new SqlParameter("@username",this .textBox2.Text ),
            //                         new SqlParameter("@password",this .textBox4.Text ),
            //                         new SqlParameter("@role",this .textBox5.Text ),
            //                     };
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //try//异常处理
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("{0} Exception caught.", ex);
            //}
            
            
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
