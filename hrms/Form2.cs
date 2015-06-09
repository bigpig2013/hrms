﻿using System;
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
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456;";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select 性别,电话,学历,家庭地址 from ygxx where 姓名 = '" + label1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqllg, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdl = cmd.ExecuteReader();
            if (sdl.Read())
            {
                label4.Text = sdl[0].ToString();
                label5.Text = sdl[1].ToString();
                label6.Text = sdl[2].ToString();
                label7.Text = sdl[3].ToString();

            }
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
        }

        

        

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";

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
                MessageBox.Show("您没有权限操作！", "提示！");
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
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";

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
                MessageBox.Show("您没有权限操作！", "提示！");
            }
        }

        private void 添加员工ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";
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
                MessageBox.Show("您没有权限操作！", "提示！");
            }
        }

        private void 删除信息ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";
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
                MessageBox.Show("您没有权限操作！", "提示！");
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
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";
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
                MessageBox.Show("您没有权限操作！", "提示！");
            }
        }

        private void 密码修改ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";
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
                MessageBox.Show("您没有权限操作！", "提示！");
            }
              
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
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";
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
                MessageBox.Show("您没有权限操作！", "提示！");
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
            dataGridView1.SetBounds(this.ClientRectangle.Left + groupBox1.Width, this.ClientRectangle.Top + menuStrip1.Height + label3.Height, this.ClientRectangle.Right, this.ClientRectangle.Bottom);
        }

        
        private void 奖惩操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";
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
                MessageBox.Show("您没有权限操作！", "提示！");
            }
        }

        private void 调动操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";
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
                MessageBox.Show("您没有权限操作！", "提示！");
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

            groupBox1.Hide();
            groupBox2.Visible = true;
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
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
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Visible = true;
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Hide();
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
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Visible = true;
            groupBox5.Hide();
            groupBox6.Hide();
        }

        private void 权限查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbrole = ((Form1)this.Owner).textBox1.Text;
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            conn.Open();
            string sqllg = "select * from ygdl where 用户名 = '" + dbrole + "' and 权限 = 'root'";
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
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                groupBox5.Visible = true;
                groupBox6.Hide();

            }
            else
            {
                MessageBox.Show("您没有权限操作！", "提示！");
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
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox6.Visible = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor); 
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "select * from ygxx where 员工编号 like '%" + textBox1.Text + "%' or 姓名 like '%" + textBox1.Text + "%' or 性别 like '%" + textBox1.Text + "%' or 出生日期 like '%" + textBox1.Text + "%' or 学历 like '%" + textBox1.Text + "%' or 毕业院校 like '%" + textBox1.Text + "%' or 家庭地址 like '%" + textBox1.Text + "%' or 入职时间  like '%" + textBox1.Text + "%'";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "select * from ygjc where 员工编号 like '%" + textBox2.Text + "%' or 姓名 like '%" + textBox2.Text + "%' or 部门 like '%" + textBox2.Text + "%' or 标题 like '%" + textBox2.Text + "%' or 金额 like '%" + textBox2.Text + "%' or 备注信息 like '%" + textBox2.Text + "%'";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor); 
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void groupBox6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void groupBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "select * from ygdd where 员工编号 like '%" + textBox3.Text + "%' or 姓名 like '%" + textBox3.Text + "%' or 部门 like '%" + textBox3.Text + "%' or 入职时间 like '%" + textBox3.Text + "%' or 备注信息 like '%" + textBox3.Text + "%'";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "select * from ygdl where 员工编号 like '%" + textBox4.Text + "%' or 用户名 like '%" + textBox4.Text + "%' or 密码 like '%" + textBox4.Text + "%' or 权限 like '%" + textBox4.Text + "%'";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string sqldb = "server=.;database=hrms;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(sqldb);
            string sql = "select * from fbxx where 标题 like '%" + textBox5.Text + "%' or 内容 like '%" + textBox5.Text + "%' or 员工编号 like '%" + textBox5.Text + "%' or 姓名 like '%" + textBox5.Text + "%'or 部门 like '%" + textBox5.Text + "%'or 生效时间 like '%" + textBox5.Text + "%'";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hrms.Mob_Staff.staff add = new hrms.Mob_Staff.staff();

            add.ShowDialog();
        }
    }
}
