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

            //SqlConnection conn = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
            ////string sqlins = "INSERT into ygxx VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox2.Text+"'',"+textBox4.Text+"','"+dateTimePicker1.Text+"','"+comboBox1.Text+"','"+textBox9.Text+"','"+textBox10.Text+"','"+textBox11.Text+"','"+textBox12.Text+"','"+textBox13.Text+"','"+dateTimePicker2.Text+"','"+textBox15.Text+"','"+textBox8.Text+"')";
            //string sqlins = "insert into ygxx (id,name,sex) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox2.SelectedItem.ToString()+"')";
            //SqlCommand cmd = new SqlCommand(sqlins, conn);

            //MessageBox.Show(" ");
            //cmd.Connection = conn;
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //string sqlins = "insert into ygxx (id,name,sex,age,birth,departid,degree,school,homeaddress,mobile,email,entrytime,workexprience,note) values (@id,@namesex,@age,@birth,@departid,@degree,@school,@homeaddress,@mobile,@email,@entrytime,@workexprience,@note)";
            //SqlCommand cmd = new SqlCommand(sqlins, conn);
            //SqlConnection con = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
            //string sqlins = "insert into ygxx (id,name) values (@id,@namesex)";

            //SqlCommand cmd = new SqlCommand(sqlins, con);
            //SqlParameter[] paras = new SqlParameter[2];
            //paras[0] = new SqlParameter("@id", SqlDbType.VarChar);
            //paras[0].Value = textBox1.Text;
            //paras[1] = new SqlParameter("@name", SqlDbType.VarChar);
            //paras[1].Value = textBox2.Text;
            //paras[2] = new SqlParameter("@sex",SqlDbType.VarChar);
            //paras[2].Value = comboBox1.Text;
            //paras[3] = new SqlParameter("@age",SqlDbType.VarChar);
            //paras[3].Value = textBox4.Text;
            //paras[4] = new SqlParameter("@birth", SqlDbType.VarChar);
            //paras[4].Value = dateTimePicker1.Value.Date.ToLongDateString();
            //paras[5] = new SqlParameter("@departid", SqlDbType.VarChar);
            //paras[5].Value = comboBox1.Text;
            //paras[6] = new SqlParameter("@degree", SqlDbType.VarChar);
            //paras[6].Value = textBox9.Text;
            //paras[7] = new SqlParameter("@school", SqlDbType.VarChar);
            //paras[7].Value = textBox10.Text;
            //paras[8] = new SqlParameter("@homeaddress", SqlDbType.VarChar);
            //paras[8].Value = textBox11.Text;
            //paras[9] = new SqlParameter("@mobile", SqlDbType.VarChar);
            //paras[9].Value = textBox12.Text;
            //paras[10] = new SqlParameter("@email", SqlDbType.VarChar);
            //paras[10].Value = textBox13.Text;
            //paras[11] = new SqlParameter("@entrytime", SqlDbType.VarChar);
            //paras[11].Value = dateTimePicker2.Value.Date.ToLongDateString();
            //paras[12] = new SqlParameter("@workexprience", SqlDbType.VarChar);
            //paras[12].Value = textBox15.Text;
            //paras[13] = new SqlParameter("@note", SqlDbType.VarChar);
            //paras[13].Value = textBox8.Text;
            
            //SqlConnection con = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");  
            //con.Open();
            //SqlCommand cmd = new SqlCommand(sqlins, con);
            //foreach (SqlParameter parameter in paras)
            //{
            //    //cmd.Parameters.AddRange(parameter);
            //    cmd.Parameters.Add(parameter);
            //}
            //cmd.ExecuteNonQuery();
            //con.Close();  
            
            //MessageBox.Show(" ");
            //cmd.Connection = conn;
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();
            string strSql = "insert into ygxx (id,name,sex,age,birth,departid,degree,school,homeaddress,mobile,email,entrytime,workexprience,note) values (@id,@name,@sex,@age,@birth,@departid,@degree,@school,@homeaddress,@mobile,@email,@entrytime,@workexprience,@note)";
            SqlParameter[] paras = new SqlParameter[14];
            paras[0] = new SqlParameter("@id", SqlDbType.NVarChar);
            paras[0].Value = textBox1.Text;
            paras[1] = new SqlParameter("@name", SqlDbType.VarChar);
            paras[1].Value = textBox2.Text;
            paras[2] = new SqlParameter("@sex", SqlDbType.VarChar);
            paras[2].Value = comboBox2.Text;
            paras[3] = new SqlParameter("@age",SqlDbType.VarChar);
            paras[3].Value = textBox4.Text;
            paras[4] = new SqlParameter("@birth",SqlDbType.VarChar);
            paras[4].Value = dateTimePicker1.Text;
            paras[5] = new SqlParameter("@departid", SqlDbType.VarChar);
            paras[5].Value = comboBox1.Text;
            paras[6] = new SqlParameter("@degree", SqlDbType.VarChar);
            paras[6].Value = textBox9.Text;
            paras[7] = new SqlParameter("@school", SqlDbType.VarChar);
            paras[7].Value = textBox10.Text;
            paras[8] = new SqlParameter("@homeaddress", SqlDbType.VarChar);
            paras[8].Value = textBox11.Text;
            paras[9] = new SqlParameter("@mobile", SqlDbType.VarChar);
            paras[9].Value = textBox12.Text;
            paras[10] = new SqlParameter("@email", SqlDbType.VarChar);
            paras[10].Value = textBox13.Text;
            paras[11] = new SqlParameter("@entrytime", SqlDbType.VarChar);
            paras[11].Value = dateTimePicker2.Text;
            paras[12] = new SqlParameter("@workexprience", SqlDbType.VarChar);
            paras[12].Value = textBox15.Text;
            paras[13] = new SqlParameter("@note", SqlDbType.VarChar);
            paras[13].Value = textBox8.Text;

            //ExecuteSql(strSql, paras, CommandType.Text);
            SqlConnection con = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
            con.Open();
            SqlCommand cmd = new SqlCommand(strSql,con);
            //cmd.Connection = con;
            //cmd.CommandType = cmdType;
            //cmd.CommandText = strSql;
            foreach (SqlParameter p in paras)
            {
                cmd.Parameters.Add(p);
            }
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" ");
            

          

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
