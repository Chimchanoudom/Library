﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Class;

namespace Library
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        addstudent addstudent;
        private void btnadd_Click(object sender, EventArgs e)
        {
            addstudent = new addstudent();
            mdi.main(encapulation.Parent1, addstudent);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            addstudent = new addstudent(new List<object>() { });
            mdi.main(encapulation.Parent1, addstudent);
        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            
        }
    }
}
