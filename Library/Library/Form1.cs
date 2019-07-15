using Library.Class;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            encapulation.Parent1 = this;
            //MessageBox.Show(encapt.Parent.ToString());

        }

        private void សមជកStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            lbldate.Text = "កាលបរិច្ឆេទ / Date : " + dt.ToString("dddd dd - MMMM- yyyy  hh:mm  ");
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {

            Borrow br = new Borrow();
            mdi.main(this, br);
            br.WindowState = FormWindowState.Normal;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            returnbook rb = new returnbook();
            mdi.main(this, rb);
            rb.WindowState = FormWindowState.Normal;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            student st = new student();
            mdi.main(this, st);
            st.WindowState = FormWindowState.Normal;
        }

        private void btnPrintCard_Click(object sender, EventArgs e)
        {
            printcard pc = new printcard();
            mdi.main(this, pc);
            pc.WindowState = FormWindowState.Normal;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            staff sf = new staff();
            mdi.main(this, sf);
            sf.WindowState = FormWindowState.Normal;
        }

        private void btnSupplierInformatiomn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnprevilageanduser_Click(object sender, EventArgs e)
        {
            User_and_Privilage up = new User_and_Privilage();
            mdi.main(this, up);
            up.WindowState = FormWindowState.Normal;
        }

        private void btnImportBook_Click(object sender, EventArgs e)
        {
            import im = new import();
            mdi.main(this, im);
            im.WindowState = FormWindowState.Normal;
        }

        private void btnexpense_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            mdi.main(this, expense);
        }

        private void btnexpensetype_Click(object sender, EventArgs e)
        {
            addexpense_type expensetype = new addexpense_type();
            mdi.main(this, expensetype);
        }
    }
}
