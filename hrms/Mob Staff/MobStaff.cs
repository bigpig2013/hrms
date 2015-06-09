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

namespace hrms.Mob_Staff
{
    
    public partial class MobStaff : Form
    {
      
        public MobStaff()
        {
            InitializeComponent();
        }

        private void MobStaff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
            con.Open();
            string sql = "select 姓名,部门 from ygdd where 员工编号 = '"+textBox1.Text+"'";
            SqlCommand com = new SqlCommand(sql,con);
            com.CommandType = CommandType.Text;
            SqlDataReader sdl = com.ExecuteReader();
            if (sdl.Read())
            {
                textBox2.Text = sdl[0].ToString();
                textBox3.Text = sdl[1].ToString();

            }
            else
            {
                MessageBox.Show("您搜索队用户不存在！", "提示！");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入员工编号！","提示！");
            }
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456;";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();

            SqlCommand cmddel = new SqlCommand("update ygdd set 部门 = '"+comboBox2.Text+"',入职时间 = '"+dateTimePicker1.Text+"',备注信息 = '"+textBox4.Text+"' where 员工编号 = '"+textBox1.Text+"'",conn);
            cmddel.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("员工调动成功！", "提示！");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
