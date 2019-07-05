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
            this.ខចសវភBorrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.សងសវភReturnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.សវងរកFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.សមជកStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ចឈមRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ធវបណណPrintCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.បគគលកStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.បញចលបគគលកAddStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.អនកភផគតផគងSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.នចលសវភImportBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ខចសវភBorrowBookToolStripMenuItem,
            this.សងសវភReturnBookToolStripMenuItem,
            this.សវងរកFindToolStripMenuItem});
            this.សវភBookToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.សវភBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("សវភBookToolStripMenuItem.Image")));
            this.សវភBookToolStripMenuItem.Name = "សវភBookToolStripMenuItem";
            this.សវភBookToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.សវភBookToolStripMenuItem.Text = "សៀវភៅ / Book";
            this.សវភBookToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.សវភBookToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ខចសវភBorrowBookToolStripMenuItem
            // 
            this.ខចសវភBorrowBookToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ខចសវភBorrowBookToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ខចសវភBorrowBookToolStripMenuItem.Name = "ខចសវភBorrowBookToolStripMenuItem";
            this.ខចសវភBorrowBookToolStripMenuItem.Size = new System.Drawing.Size(270, 32);
            this.ខចសវភBorrowBookToolStripMenuItem.Text = "ខ្ចីសៀវភៅ / Borrow Book";
            // 
            // សងសវភReturnBookToolStripMenuItem
            // 
            this.សងសវភReturnBookToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.សងសវភReturnBookToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.សងសវភReturnBookToolStripMenuItem.Name = "សងសវភReturnBookToolStripMenuItem";
            this.សងសវភReturnBookToolStripMenuItem.Size = new System.Drawing.Size(270, 32);
            this.សងសវភReturnBookToolStripMenuItem.Text = "សងសៀវភៅ​ /Return Book";
            // 
            // សវងរកFindToolStripMenuItem
            // 
            this.សវងរកFindToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.សវងរកFindToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.សវងរកFindToolStripMenuItem.Name = "សវងរកFindToolStripMenuItem";
            this.សវងរកFindToolStripMenuItem.Size = new System.Drawing.Size(270, 32);
            this.សវងរកFindToolStripMenuItem.Text = "ស្វែងរក/ Find";
            // 
            // សមជកStudentToolStripMenuItem
            // 
            this.សមជកStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ចឈមRegisterToolStripMenuItem,
            this.ធវបណណPrintCardToolStripMenuItem});
            this.សមជកStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.សមជកStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("សមជកStudentToolStripMenuItem.Image")));
            this.សមជកStudentToolStripMenuItem.Name = "សមជកStudentToolStripMenuItem";
            this.សមជកStudentToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.សមជកStudentToolStripMenuItem.Text = "សមាជិក​ / Student";
            this.សមជកStudentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.សមជកStudentToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.សមជកStudentToolStripMenuItem.Click += new System.EventHandler(this.សមជកStudentToolStripMenuItem_Click);
            // 
            // ចឈមRegisterToolStripMenuItem
            // 
            this.ចឈមRegisterToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ចឈមRegisterToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ចឈមRegisterToolStripMenuItem.Name = "ចឈមRegisterToolStripMenuItem";
            this.ចឈមRegisterToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.ចឈមRegisterToolStripMenuItem.Text = "ចុះឈ្មោះ / Register";
            // 
            // ធវបណណPrintCardToolStripMenuItem
            // 
            this.ធវបណណPrintCardToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ធវបណណPrintCardToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ធវបណណPrintCardToolStripMenuItem.Name = "ធវបណណPrintCardToolStripMenuItem";
            this.ធវបណណPrintCardToolStripMenuItem.Size = new System.Drawing.Size(218, 32);
            this.ធវបណណPrintCardToolStripMenuItem.Text = "ធ្វើបណ្ណ័ / Print Card";
            // 
            // បគគលកStaffToolStripMenuItem
            // 
            this.បគគលកStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.បញចលបគគលកAddStaffToolStripMenuItem});
            this.បគគលកStaffToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.បគគលកStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("បគគលកStaffToolStripMenuItem.Image")));
            this.បគគលកStaffToolStripMenuItem.Name = "បគគលកStaffToolStripMenuItem";
            this.បគគលកStaffToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.បគគលកStaffToolStripMenuItem.Text = "បុគ្គលិក /​ Employee";
            this.បគគលកStaffToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.បគគលកStaffToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // បញចលបគគលកAddStaffToolStripMenuItem
            // 
            this.បញចលបគគលកAddStaffToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.បញចលបគគលកAddStaffToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.បញចលបគគលកAddStaffToolStripMenuItem.Name = "បញចលបគគលកAddStaffToolStripMenuItem";
            this.បញចលបគគលកAddStaffToolStripMenuItem.Size = new System.Drawing.Size(296, 32);
            this.បញចលបគគលកAddStaffToolStripMenuItem.Text = "បញ្ចូលបុគ្គលិក / Add Employee";
            // 
            // អនកភផគតផគងSupplierToolStripMenuItem
            // 
            this.អនកភផគតផគងSupplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem,
            this.នចលសវភImportBookToolStripMenuItem});
            this.អនកភផគតផគងSupplierToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.អនកភផគតផគងSupplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("អនកភផគតផគងSupplierToolStripMenuItem.Image")));
            this.អនកភផគតផគងSupplierToolStripMenuItem.Name = "អនកភផគតផគងSupplierToolStripMenuItem";
            this.អនកភផគតផគងSupplierToolStripMenuItem.Size = new System.Drawing.Size(181, 31);
            this.អនកភផគតផគងSupplierToolStripMenuItem.Text = "អ្នកផ្គត់ផ្គង់/ Supplier";
            this.អនកភផគតផគងSupplierToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.អនកភផគតផគងSupplierToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem
            // 
            this.ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem.Name = "ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem";
            this.ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem.Size = new System.Drawing.Size(373, 32);
            this.ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem.Text = "ព័ត៌មានអ្នកផ្គត់ផ្កង់ / Supplier Informatiomn";
            // 
            // នចលសវភImportBookToolStripMenuItem
            // 
            this.នចលសវភImportBookToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.នចលសវភImportBookToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.នចលសវភImportBookToolStripMenuItem.Name = "នចលសវភImportBookToolStripMenuItem";
            this.នចលសវភImportBookToolStripMenuItem.Size = new System.Drawing.Size(373, 32);
            this.នចលសវភImportBookToolStripMenuItem.Text = "នាំចូលសៀវភៅ / Import Book";
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(198, 0);
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
        private System.Windows.Forms.ToolStripMenuItem ខចសវភBorrowBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem សងសវភReturnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem សមជកStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem បគគលកStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem សវងរកFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចឈមRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ធវបណណPrintCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem បញចលបគគលកAddStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem អនកភផគតផគងSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ពតមនអនកផគតផកងSupplierInformatiomnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem នចលសវភImportBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem របយករណReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ចកចញLogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;

    }
}

