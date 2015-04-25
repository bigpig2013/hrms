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
            
            
            label1.Text = "当前用户："+ ((Form1)this.Owner).textBox1 .Text  ;

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
    }
}
