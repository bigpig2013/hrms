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
            string str = (string)SqlHelper.ExecuteScalar("select * from abo.ygdl where username=@username and password=@password ",new SqlParameter("@name", this.textBox1.Text), new SqlParameter("@password", this.textBox2.Text));
            
            if (str != null)
            {             
                    MessageBox.Show("登陆成功");
                    this.Hide();
                     Form2 form = new Form2();
                     form.ShowDialog();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
           
         
        
    }
}
