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

namespace hrms.RewardPStaff
{
    public partial class RewardPStaff : Form
    {
        public RewardPStaff()
        {
            InitializeComponent();
        }

        private void RewardPStaff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
            con.Open();
            string sql = "select 姓名,部门 from ygdd where 员工编号 = '" + textBox1.Text + "'";
            SqlCommand com = new SqlCommand(sql, con);
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
            else
            {
                string sqldb = "server=.;database=hrms;uid=sa;pwd=123456;";
                SqlConnection conn = new SqlConnection(sqldb);
                conn.Open();
                string sqljc = "insert into ygjc (员工编号,姓名,部门,标题,金额,备注信息) values (@员工编号,@姓名,@部门,@标题,@金额,@备注信息)";
                SqlCommand cmdjc = new SqlCommand(sqljc, conn);



                SqlParameter[] paras = new SqlParameter[6];
                paras[0] = new SqlParameter("@员工编号", SqlDbType.NVarChar);
                paras[0].Value = textBox1.Text;
                paras[1] = new SqlParameter("@姓名", SqlDbType.VarChar);
                paras[1].Value = textBox2.Text;
                paras[2] = new SqlParameter("@部门", SqlDbType.VarChar);
                paras[2].Value = textBox3.Text;
                paras[3] = new SqlParameter("@标题", SqlDbType.VarChar);
                paras[3].Value = comboBox1.Text;
                paras[4] = new SqlParameter("@金额", SqlDbType.VarChar);
                paras[4].Value = textBox4.Text;
                paras[5] = new SqlParameter("@备注信息", SqlDbType.VarChar);
                paras[5].Value = textBox5.Text;
                foreach (SqlParameter p in paras)
                {
                    cmdjc.Parameters.Add(p);

                }
                cmdjc.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("操作成功！", "提示！");
                this.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            comboBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            this.textBox4.Clear();
        }
    }
}
