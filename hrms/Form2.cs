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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void 添加员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1 .Text  ;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '"+dbrole+"' and role = 'root'";
        
            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if(sdl.Read())
                {
                                 
                    ADD.addStaff  add = new ADD.addStaff();
            
                    add.ShowDialog();
                    
                    
                }
             else
                {
                    MessageBox.Show("您没有权限操作！");
                }
                
           
         
            
        
           
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ygdl";
            DataTable dt = new DataTable();
            DB.FillDataTable(sql, dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
            label1.Text =  ((Form1)this.Owner).textBox1 .Text  ;

        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '" + dbrole + "' and role = 'root'";

            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {

                Add_Staff.changestaff add = new Add_Staff.changestaff();

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }

        private void 权限修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '" + dbrole + "' and role = 'root'";

            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {

                hrms.ManStaff.adminchange add = new ManStaff.adminchange();

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }

        private void 删除信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '" + dbrole + "' and role = 'root'";

            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {

                hrms.Add_Staff.delstaff add = new Add_Staff.delstaff();

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 员工调动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '" + dbrole + "' and role = 'root'";

            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {

                hrms.Mob_Staff.MobStaff add = new Mob_Staff.MobStaff(); 

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 员工奖惩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '" + dbrole + "' and role = 'root'";

            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {

                hrms.RewardPStaff.RewardPStaff add = new RewardPStaff.RewardPStaff();

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '" + dbrole + "' and role = 'root'";

            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {

                hrms.ManStaff.pwdchange add = new ManStaff.pwdchange();

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }

        private void 发布公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where username = '" + dbrole + "' and role = 'root'";

            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {

                hrms.NoticeMan.Noticepub add = new NoticeMan.Noticepub();
                add.Owner = this;

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }
    }
}
