﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ADD.addStaff  add = new ADD.addStaff();
            add.ShowDialog();
        }
    }
}
