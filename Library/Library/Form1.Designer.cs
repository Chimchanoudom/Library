namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.សវភBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBorrowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFindbook = new System.Windows.Forms.ToolStripMenuItem();
            this.សមជកStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintCard = new System.Windows.Forms.ToolStripMenuItem();
            this.បគគលកStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.btnprevilageanduser = new System.Windows.Forms.ToolStripMenuItem();
            this.អនកភផគតផគងSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupplierInformatiomn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportBook = new System.Windows.Forms.ToolStripMenuItem();
            this.របយករណReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ចកចញLogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Khmer OS Muol Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.សវភBookToolStripMenuItem,
            this.សមជកStudentToolStripMenuItem,
            this.បគគលកStaffToolStripMenuItem,
            this.អនកភផគតផគងSupplierToolStripMenuItem,
            this.របយករណReportToolStripMenuItem,
            this.ចកចញLogOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(198, 571);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // សវភBookToolStripMenuItem
            // 
            this.សវភBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBorrowBook,
            this.btnReturnBook,
            this.btnFindbook});
            this.សវភBookToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.សវភBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("សវភBookToolStripMenuItem.Image")));
            this.សវភBookToolStripMenuItem.Name = "សវភBookToolStripMenuItem";
            this.សវភBookToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.សវភBookToolStripMenuItem.Text = "សៀវភៅ / Book";
            this.សវភBookToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.សវភBookToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.Black;
            this.btnBorrowBook.ForeColor = System.Drawing.Color.Yellow;
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(270, 32);
            this.btnBorrowBook.Text = "ខ្ចីសៀវភៅ / Borrow Book";
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.Black;
            this.btnReturnBook.ForeColor = System.Drawing.Color.Yellow;
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(270, 32);
            this.btnReturnBook.Text = "សងសៀវភៅ​ /Return Book";
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnFindbook
            // 
            this.btnFindbook.BackColor = System.Drawing.Color.Black;
            this.btnFindbook.ForeColor = System.Drawing.Color.Yellow;
            this.btnFindbook.Name = "btnFindbook";
            this.btnFindbook.Size = new System.Drawing.Size(270, 32);
            this.btnFindbook.Text = "ស្វែងរក/ Find";
            // 
            // សមជកStudentToolStripMenuItem
            // 
            this.សមជកStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegister,
            this.btnPrintCard});
            this.សមជកStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.សមជកStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("សមជកStudentToolStripMenuItem.Image")));
            this.សមជកStudentToolStripMenuItem.Name = "សមជកStudentToolStripMenuItem";
            this.សមជកStudentToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.សមជកStudentToolStripMenuItem.Text = "សមាជិក​ / Student";
            this.សមជកStudentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.សមជកStudentToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.សមជកStudentToolStripMenuItem.Click += new System.EventHandler(this.សមជកStudentToolStripMenuItem_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.ForeColor = System.Drawing.Color.Yellow;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(218, 32);
            this.btnRegister.Text = "ចុះឈ្មោះ / Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnPrintCard
            // 
            this.btnPrintCard.BackColor = System.Drawing.Color.Black;
            this.btnPrintCard.ForeColor = System.Drawing.Color.Yellow;
            this.btnPrintCard.Name = "btnPrintCard";
            this.btnPrintCard.Size = new System.Drawing.Size(218, 32);
            this.btnPrintCard.Text = "ធ្វើបណ្ណ័ / Print Card";
            this.btnPrintCard.Click += new System.EventHandler(this.btnPrintCard_Click);
            // 
            // បគគលកStaffToolStripMenuItem
            // 
            this.បគគលកStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddStaff,
            this.btnprevilageanduser});
            this.បគគលកStaffToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.បគគលកStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("បគគលកStaffToolStripMenuItem.Image")));
            this.បគគលកStaffToolStripMenuItem.Name = "បគគលកStaffToolStripMenuItem";
            this.បគគលកStaffToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.បគគលកStaffToolStripMenuItem.Text = "បុគ្គលិក /​ Employee";
            this.បគគលកStaffToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.បគគលកStaffToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.Black;
            this.btnAddStaff.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(334, 32);
            this.btnAddStaff.Text = "បញ្ចូលបុគ្គលិក / Add Employee";
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnprevilageanduser
            // 
            this.btnprevilageanduser.BackColor = System.Drawing.Color.Black;
            this.btnprevilageanduser.ForeColor = System.Drawing.Color.Yellow;
            this.btnprevilageanduser.Name = "btnprevilageanduser";
            this.btnprevilageanduser.Size = new System.Drawing.Size(334, 32);
            this.btnprevilageanduser.Text = "សិទ្ធិ នឹង គណនី​ / Previlage and User";
            this.btnprevilageanduser.Click += new System.EventHandler(this.btnprevilageanduser_Click);
            // 
            // អនកភផគតផគងSupplierToolStripMenuItem
            // 
            this.អនកភផគតផគងSupplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSupplierInformatiomn,
            this.btnImportBook});
            this.អនកភផគតផគងSupplierToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.អនកភផគតផគងSupplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("អនកភផគតផគងSupplierToolStripMenuItem.Image")));
            this.អនកភផគតផគងSupplierToolStripMenuItem.Name = "អនកភផគតផគងSupplierToolStripMenuItem";
            this.អនកភផគតផគងSupplierToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.អនកភផគតផគងSupplierToolStripMenuItem.Text = "អ្នកផ្គត់ផ្គង់/ Supplier";
            this.អនកភផគតផគងSupplierToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.អនកភផគតផគងSupplierToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // btnSupplierInformatiomn
            // 
            this.btnSupplierInformatiomn.BackColor = System.Drawing.Color.Black;
            this.btnSupplierInformatiomn.ForeColor = System.Drawing.Color.Yellow;
            this.btnSupplierInformatiomn.Name = "btnSupplierInformatiomn";
            this.btnSupplierInformatiomn.Size = new System.Drawing.Size(361, 32);
            this.btnSupplierInformatiomn.Text = "ព័ត៌មានអ្នកផ្គត់ផ្កង់ / Supplier Information";
            this.btnSupplierInformatiomn.Click += new System.EventHandler(this.btnSupplierInformatiomn_Click);
            // 
            // btnImportBook
            // 
            this.btnImportBook.BackColor = System.Drawing.Color.Black;
            this.btnImportBook.ForeColor = System.Drawing.Color.Yellow;
            this.btnImportBook.Name = "btnImportBook";
            this.btnImportBook.Size = new System.Drawing.Size(361, 32);
            this.btnImportBook.Text = "នាំចូលសៀវភៅ / Import Book";
            this.btnImportBook.Click += new System.EventHandler(this.btnImportBook_Click);
            // 
            // របយករណReportToolStripMenuItem
            // 
            this.របយករណReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.របយករណReportToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.របយករណReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("របយករណReportToolStripMenuItem.Image")));
            this.របយករណReportToolStripMenuItem.Name = "របយករណReportToolStripMenuItem";
            this.របយករណReportToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.របយករណReportToolStripMenuItem.Text = "របាយការណ៍/ Report​ ";
            this.របយករណReportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.របយករណReportToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 32);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // ចកចញLogOutToolStripMenuItem
            // 
            this.ចកចញLogOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ចកចញLogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.ចកចញLogOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ចកចញLogOutToolStripMenuItem.Image")));
            this.ចកចញLogOutToolStripMenuItem.Name = "ចកចញLogOutToolStripMenuItem";
            this.ចកចញLogOutToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.ចកចញLogOutToolStripMenuItem.Text = "ចាកចេញ / Log out";
            this.ចកចញLogOutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(198, 527);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 44);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "អ្នកប្រើប្រាស់ / User  :";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Black;
            this.lbldate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbldate.Location = new System.Drawing.Point(894, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(134, 24);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "កាលបរិច្ឆេទ / Date :";
            this.lbldate.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1230, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Khmer OS Muol Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "ប្រព័ន្ធគ្រប់គ្រង់បណ្ណាល័យ ជំនាន់ទី១​​ ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem សវភBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBorrowBook;
        private System.Windows.Forms.ToolStripMenuItem btnReturnBook;
        private System.Windows.Forms.ToolStripMenuItem សមជកStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem បគគលកStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnFindbook;
        private System.Windows.Forms.ToolStripMenuItem btnRegister;
        private System.Windows.Forms.ToolStripMenuItem btnPrintCard;
        private System.Windows.Forms.ToolStripMenuItem btnAddStaff;
        private System.Windows.Forms.ToolStripMenuItem អនកភផគតផគងSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSupplierInformatiomn;
        private System.Windows.Forms.ToolStripMenuItem btnImportBook;
        private System.Windows.Forms.ToolStripMenuItem របយករណReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចកចញLogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem btnprevilageanduser;

    }
}

