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
    public partial class Borrow : Form
    {
        
        public Borrow()
        {
            InitializeComponent();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            addborrow abr = new addborrow();
            mdi.main(encapulation.Parent1, abr);
            
        }
    }
}
