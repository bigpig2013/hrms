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
using System.IO;
namespace hrms
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        
       

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            label1.Text = ((Form1)this.Owner).textBox1 .Text  ;
            //string dbrole = ((Form1)this.Owner).textBox1.Text;
            //string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            //SqlConnection conn = new SqlConnection(sqldb);
            //conn.Open();
            //string sqllg = "select role from ygdl where username = '" + dbrole + "'";
            //SqlCommand cmd = new SqlCommand(sqllg, conn);
            //cmd.CommandType = CommandType.Text;
            //SqlDataReader sdl = cmd.ExecuteReader();
            
            
        }

        

        

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        

        

        
        

        
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void 修改信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void 添加员工ToolStripMenuItem_Click_1(object sender, EventArgs e)
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

                ADD.addStaff add = new ADD.addStaff();

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }

        private void 删除信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void 员工奖惩ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void 员工调动ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void 权限修改ToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void 密码修改ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
              hrms.ManStaff.pwdchange add = new ManStaff.pwdchange();
              add.ShowDialog();
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 发布公告ToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void 公告管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.SetBounds(this.ClientRectangle.Left, this.ClientRectangle.Top + menuStrip1.Height + label3.Height, this.ClientRectangle.Right, this.ClientRectangle.Bottom);
        }

        
        private void 奖惩操作ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 调动操作ToolStripMenuItem_Click(object sender, EventArgs e)
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
                add.Owner = this;

                add.ShowDialog();


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
        }

        private void 查看员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "SELECT * FROM ygxx";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            
            
        }

        private void 奖惩查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "SELECT * FROM ygjc";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void 调动查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "SELECT * FROM ygdd";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void 权限查看ToolStripMenuItem_Click(object sender, EventArgs e)
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

                string sqlb = "server=.;database=hrms;uid=sa;pwd=123456";
                SqlConnection con = new SqlConnection(sqlb);
                string sql = "SELECT * FROM ygdl";
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0];
                }


            }
            else
            {
                MessageBox.Show("您没有权限操作！");
            }
            
        }

        private void 查看公告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "SELECT * FROM fbxx";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text file(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                if (fileName == "")
                {
                    MessageBox.Show("保存文件无文件名！");
                }
                else
                {
                    myStream = new StreamWriter(fileName);
                    this.Text = "记事本-" + fileName;
                    myStream.Write(rcBox1.Text);
                    myStream.Close();
                }
            }
        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
