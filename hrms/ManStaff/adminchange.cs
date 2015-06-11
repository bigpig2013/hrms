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
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456;";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select 用户名,权限 from ygdl where 员工编号 = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {
                textBox2.Text = sdl[0].ToString();
                textBox3.Text = sdl[1].ToString();
                

            }
            else
            {
                MessageBox.Show("您搜索队用户不存在！", "提示！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入员工编号！", "提示！");
            }
            else
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("请输入有效权限！", "提示！");
                }
                else
                {
                    string sqldb = "server=.;database=hrms;uid=sa;pwd=123456;";
                    SqlConnection conn = new SqlConnection(sqldb);
                    conn.Open();
                    string strSql = "update ygdl set 权限 = @权限 where 员工编号 = '" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(strSql, conn);
                    SqlParameter[] paras = new SqlParameter[1];
                    paras[0] = new SqlParameter("@权限", SqlDbType.NVarChar);
                    paras[0].Value = comboBox1.Text;

                    foreach (SqlParameter p in paras)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("修改成功！", "提示");
                    this.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminchange_FormClosed(object sender, FormClosedEventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "SELECT * FROM ygdl";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                ((Form2)this.Owner).dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
