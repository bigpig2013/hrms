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
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("没有输入编号或姓名！", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning); 
            
            }
            

            else
            {
                SqlConnection con = new SqlConnection("server=.;database=hrms;uid=sa;pwd=123456");
                con.Open();
                string strSql = "insert into ygxx (id,name,sex,birth,departid,degree,school,homeaddress,mobile,email,entrytime,workexprience,note) values (@id,@name,@sex,@birth,@departid,@degree,@school,@homeaddress,@mobile,@email,@entrytime,@workexprience,@note)";
                SqlCommand cmd = new SqlCommand(strSql, con);
                SqlParameter[] paras = new SqlParameter[13];
                paras[0] = new SqlParameter("@id", SqlDbType.NVarChar);
                paras[0].Value = textBox1.Text;
                paras[1] = new SqlParameter("@name", SqlDbType.VarChar);
                paras[1].Value = textBox2.Text;
                paras[2] = new SqlParameter("@sex", SqlDbType.VarChar);
                paras[2].Value = comboBox2.Text;
                paras[3] = new SqlParameter("@birth", SqlDbType.VarChar);
                paras[3].Value = dateTimePicker1.Text;
                paras[4] = new SqlParameter("@departid", SqlDbType.VarChar);
                paras[4].Value = comboBox1.Text;
                paras[5] = new SqlParameter("@degree", SqlDbType.VarChar);
                paras[5].Value = textBox9.Text;
                paras[6] = new SqlParameter("@school", SqlDbType.VarChar);
                paras[6].Value = textBox10.Text;
                paras[7] = new SqlParameter("@homeaddress", SqlDbType.VarChar);
                paras[7].Value = textBox11.Text;
                paras[8] = new SqlParameter("@mobile", SqlDbType.VarChar);
                paras[8].Value = textBox12.Text;
                paras[9] = new SqlParameter("@email", SqlDbType.VarChar);
                paras[9].Value = textBox13.Text;
                paras[10] = new SqlParameter("@entrytime", SqlDbType.VarChar);
                paras[10].Value = dateTimePicker2.Text;
                paras[11] = new SqlParameter("@workexprience", SqlDbType.VarChar);
                paras[11].Value = textBox15.Text;
                paras[12] = new SqlParameter("@note", SqlDbType.VarChar);
                paras[12].Value = textBox8.Text;

                foreach (SqlParameter p in paras)
                {
                    cmd.Parameters.Add(p);
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("添加成功！", "提示");
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

        
    }
}
