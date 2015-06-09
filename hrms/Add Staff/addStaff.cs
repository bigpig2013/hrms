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
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("没有输入编号，姓名或部门", "提示");

            }


            else
            {
                {
                    //添加相应列到ygxx表；
                    SqlConnection con = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
                    con.Open();
                    string strSql = "insert into ygxx (员工编号,姓名,性别,出生日期,学历,毕业院校,家庭地址,电话,电子邮箱,入职时间,工作经验,备注信息) values (@员工编号,@姓名,@性别,@出生日期,@学历,@毕业院校,@家庭地址,@电话,@电子邮箱,@入职时间,@工作经验,@备注信息)";
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    SqlParameter[] paras = new SqlParameter[12];
                    paras[0] = new SqlParameter("@员工编号", SqlDbType.NVarChar);
                    paras[0].Value = textBox1.Text;
                    paras[1] = new SqlParameter("@姓名", SqlDbType.VarChar);
                    paras[1].Value = textBox2.Text;
                    paras[2] = new SqlParameter("@性别", SqlDbType.VarChar);
                    paras[2].Value = comboBox2.Text;
                    paras[3] = new SqlParameter("@出生日期", SqlDbType.VarChar);
                    paras[3].Value = dateTimePicker1.Text;
                    paras[4] = new SqlParameter("@学历", SqlDbType.VarChar);
                    paras[4].Value = textBox9.Text;
                    paras[5] = new SqlParameter("@毕业院校", SqlDbType.VarChar);
                    paras[5].Value = textBox10.Text;
                    paras[6] = new SqlParameter("@家庭地址", SqlDbType.VarChar);
                    paras[6].Value = textBox11.Text;
                    paras[7] = new SqlParameter("@电话", SqlDbType.VarChar);
                    paras[7].Value = textBox12.Text;
                    paras[8] = new SqlParameter("@电子邮箱", SqlDbType.VarChar);
                    paras[8].Value = textBox13.Text;
                    paras[9] = new SqlParameter("@入职时间", SqlDbType.VarChar);
                    paras[9].Value = dateTimePicker2.Text;
                    paras[10] = new SqlParameter("@工作经验", SqlDbType.VarChar);
                    paras[10].Value = textBox15.Text;
                    paras[11] = new SqlParameter("@备注信息", SqlDbType.VarChar);
                    paras[11].Value = textBox8.Text;

                    foreach (SqlParameter p in paras)
                    {
                        cmd.Parameters.Add(p);
                    }
                    cmd.ExecuteNonQuery();
                    //添加员工id,姓名，部门到ygdd表；
                    SqlConnection conn = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
                    conn.Open();
                    string Sqldd = "insert into ygdd (员工编号,姓名,部门,入职时间) values (@员工编号,@姓名,@部门,@入职时间)";
                    SqlCommand cmdd = new SqlCommand(Sqldd, conn);
                    SqlParameter[] paras1 = new SqlParameter[4];
                    paras1[0] = new SqlParameter("@员工编号", SqlDbType.NVarChar);
                    paras1[0].Value = textBox1.Text;
                    paras1[1] = new SqlParameter("@姓名", SqlDbType.VarChar);
                    paras1[1].Value = textBox2.Text;
                    paras1[2] = new SqlParameter("@部门", SqlDbType.VarChar);
                    paras1[2].Value = comboBox1.Text;
                    paras1[3] = new SqlParameter("@入职时间", SqlDbType.VarChar);
                    paras1[3].Value = dateTimePicker2.Text;
                    
                    foreach (SqlParameter p in paras1)
                    {
                        cmdd.Parameters.Add(p);

                    }

                    cmdd.ExecuteNonQuery();
                    //添加信息到ygdl表，默认密码为123456，权限默认为staff，可到用户管理里面修改相关；
                    string sqldl = "insert into ygdl (员工编号,用户名,密码,权限) values (@员工编号,@用户名,'123456','staff')";
                    SqlCommand cmdl = new SqlCommand(sqldl, con);

                    SqlParameter[] paras2 = new SqlParameter[2];
                    paras2[0] = new SqlParameter("@员工编号", SqlDbType.NVarChar);
                    paras2[0].Value = textBox1.Text;
                    paras2[1] = new SqlParameter("@用户名", SqlDbType.VarChar);
                    paras2[1].Value = textBox2.Text;

                    foreach (SqlParameter p in paras2)
                    {
                        cmdl.Parameters.Add(p);

                    }

                    cmdl.ExecuteNonQuery();









                    con.Close();
                    MessageBox.Show("信息添加成功！", "提示");
                    this.Close();
                }
            }
        }









        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox10.Clear();
            this.textBox2.Clear();
            this.textBox9.Clear();
            this.textBox11.Clear();
            this.textBox12.Clear();
            this.textBox13.Clear();
            this.textBox15.Clear();
            this.textBox8.Clear();




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456;";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();

            string sqldd = "select 员工编号 from ygxx where 员工编号 = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqldd, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {
                MessageBox.Show("您输入的编号已存在！", "提示！");
            }
            else
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            } 
            
        }


    }
}

