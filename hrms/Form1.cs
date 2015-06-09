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
            string sqllg = "select * from ygdl where 用户名 = '"+textBox1.Text+"'";
        
            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if(sdl.Read())
            {
                string dbpassword = sdl.GetString(sdl.GetOrdinal("密码"));
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
                    MessageBox.Show("您的密码有误！", "提示！");
                }
                
            }
            else
            {
                MessageBox.Show("用户不存在！", "提示！");
            }
            
            
         
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        
           
         
        
    }
}
