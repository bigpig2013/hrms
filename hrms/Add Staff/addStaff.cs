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
            //string id, name, age, nation, birth, departid, degree, school, homeaddress, mobile, email, datesemployed, workexprience, note, role;
            //id = this.textBox1.Text;
            //name = this.textBox2.Text;
            //age = this.textBox4.Text;
            //nation = this.textBox5.Text;
            //degree = this.textBox9.Text;
            //school = this.textBox10.Text;
            //homeaddress = this.textBox11.Text;
            //mobile = this.textBox12.Text;
            //email = this.textBox13.Text;
            //workexprience = this.textBox15.Text;
            //note = this.textBox8.Text;
            //string sex = " ";
            //if (radioButton1.Checked)
            //    sex = "男";

            //if (radioButton2.Checked) ;
            //sex = "女";
            //birth = this.dateTimePicker1.Text;
            //datesemployed = this.dateTimePicker2.Text;
            //departid = this.comboBox1.Text;
            //role = this.Text("staff");
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True"))
            {
                conn.Open();//打开数据库 
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into ygxx values ("+textBox1.Text+""+textBox2.Text+")";
                    //          //查询命令为:查询role等于用户的权限
                    //            cmd.CommandText = "select role from ygdl where role = root";
                    //            //将查询到的数据保存在reader这个变量里   
                    //            using (SqlDataReader reader = cmd.ExecuteReader())
                    //            {
                    //                //如果reader.Read()的结果不为空, 则说明输入的用户名存在   
                    //                if (reader.Read())
                    //               {
                    //                    /*从数据库里查询出和用户相对应的role的值 
                    //                     *reader.GetOrdinal("PassWord")的作用是得到PassWord的为这行数据中的第几列,返回回值是int 
                    //                     *reader.GetString()的作用是得到第几列的值,返回类型为String. 
                    //                     */
                    //                    string dbrole = reader.GetString(reader.GetOrdinal("role"));

                    //                    //比较用户输入的密码与从数据库中查询到的密码是否一至   
                    //                    if (role == dbrole)
                    //                    {
                    //                        //如果相等,就登录成功   
                    //                        this.Hide();
                    //                        Form2 form = new Form2();
                    //                        form.ShowDialog();
                    //                    }
                    //                    else
                    //                    {
                    //                        //如果不相等,说明密码不对   
                    //                        //Console.WriteLine("输入的密码有误!");
                    //                        MessageBox.Show("输入密码有误！");


                    //                    }

                    //               }
                    //                else
                    //                {
                    //                    //说明输入的用户名不存在   
                    //                    //Console.WriteLine("输入的用户名不存在!");
                    //                    MessageBox.Show("输入的用户名不存在！");
                    //                }
                    //            }
                    //}
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
