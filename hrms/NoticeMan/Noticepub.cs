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

namespace hrms.NoticeMan
{
    public partial class Noticepub : Form
    {
        public Noticepub()
        {
            InitializeComponent();
        }

        private void Noticepub_Load(object sender, EventArgs e)
        {
            //从ygdd表读取当前用户的id name departid信息
            string dbrole = ((Form2)this.Owner).label1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select id,name,departid from ygdd where name = '" + dbrole + "'";

            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {

                textBox3.Text = sdl[0].ToString();
                textBox4.Text = sdl[1].ToString();
                textBox5.Text = sdl[2].ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("没有输入标题，内容", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }


            else
            {

                //添加相应列到fbxx表；
                SqlConnection con = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
                con.Open();
                string strSql = "insert into fbxx (title,note,id,name,departid,pubtime) values (@title,@note,@id,@name,@departid,@pubtime)";
                SqlCommand cmd = new SqlCommand(strSql, con);



                SqlParameter[] paras = new SqlParameter[6];
                paras[0] = new SqlParameter("@title", SqlDbType.NVarChar);
                paras[0].Value = textBox1.Text;
                paras[1] = new SqlParameter("@note", SqlDbType.VarChar);
                paras[1].Value = textBox2.Text;
                paras[2] = new SqlParameter("@id",SqlDbType.VarChar);
                paras[2].Value = textBox3.Text;
                paras[3] = new SqlParameter("@name",SqlDbType.VarChar);
                paras[3].Value = textBox4.Text;
                paras[4] = new SqlParameter("@departid",SqlDbType.VarChar);
                paras[4].Value = textBox5.Text;
                paras[5] = new SqlParameter("@pubtime", SqlDbType.VarChar);
                paras[5].Value = dateTimePicker1.Text;


                foreach (SqlParameter p in paras)
                {
                    cmd.Parameters.Add(p);

                }

                cmd.ExecuteNonQuery();






                con.Close();
                MessageBox.Show("添加成功！", "提示");
            }
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
