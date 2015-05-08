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


namespace hrms
{
    
      
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
            
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '"+textBox1.Text+"'";
        
            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if(sdl.Read())
            {
                string dbpassword = sdl.GetString(sdl.GetOrdinal("PassWord"));
                //SqlDataReader sdp = cmd.ExecuteReader();
                if (dbpassword == textBox2.Text)
                {
                    
                    
                    Form2 form = new Form2();
                  
                    form.Owner = this;

                    form.Show();
                   
                    this.Hide();

                    
                    
                }
                else
                {
                    MessageBox.Show("您的密码有误！");
                }
                
            }
            else
            {
                MessageBox.Show("用户不存在！");
            }
            
            
         
            
        }
        
      

               
               
               
                   
                   

 
            //string username, password;
            //username = this.textBox1.Text;
            //password = this.textBox2.Text;

            //using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True"))
            //{
            //    conn.Open();//打开数据库 
            //    using (SqlCommand cmd = conn.CreateCommand())
            //    {
            //        //查询命令为:查询UserName等于输入的用户名   
            //        cmd.CommandText = "select * from ygdl where username='" + username + "'";

            //        //将查询到的数据保存在reader这个变量里   
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            //如果reader.Read()的结果不为空, 则说明输入的用户名存在   
            //            if (reader.Read())
            //            {
            //                /*从数据库里查询出和用户相对应的PassWorld的值 
            //                 *reader.GetOrdinal("PassWord")的作用是得到PassWord的为这行数据中的第几列,返回回值是int 
            //                 *reader.GetString()的作用是得到第几列的值,返回类型为String. 
            //                 */
            //                string dbpassword = reader.GetString(reader.GetOrdinal("PassWord"));

            //                //比较用户输入的密码与从数据库中查询到的密码是否一至   
            //                if (password == dbpassword)
            //                {
            //                    //如果相等,就登录成功   
            //                    this.Hide();
            //                    Form2 form = new Form2();
            //                    form.ShowDialog();
            //                }
            //                else
            //                {
            //                    //如果不相等,说明密码不对   
            //                    //Console.WriteLine("输入的密码有误!");
            //                    MessageBox.Show("输入密码有误！");


            //                }

            //            }
            //            else
            //            {
            //                //说明输入的用户名不存在   
            //                //Console.WriteLine("输入的用户名不存在!");
            //                MessageBox.Show("输入的用户名不存在！");
            //            }
            //        }


          
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        
           
         
        
    }
}
