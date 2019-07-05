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
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
        }

        private void testing_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                RadioButton ch = new RadioButton();
                ch.Text = "Checkbox" + i + "";
                flowLayoutPanel1.Controls.Add(ch);
                ch.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rnd in flowLayoutPanel1.Controls)
            {
                if (rnd.Checked == true)
                {
                    MessageBox.Show(rnd.Text);
                    break;
                }
            }
        }
    }
}
