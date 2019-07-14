using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btndetail_Click(object sender, EventArgs e)
        {
            return_detail rwd = new return_detail();
            rwd.ShowDialog();
        }
    }
}
