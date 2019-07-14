using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Class
{
    class mdi
    {
        public static void main(Form Parent, Form chile)
        {
            int i = 0;
            if (Parent.MdiChildren.Length == 0)
            {
                chile.MdiParent = Parent;
                chile.Show();

            }
            else
            {
                foreach (Form frm in Parent.MdiChildren)
                {
                    if (frm.Name == chile.Name)
                    {
                        frm.Activate();
                        return;
                        i++;
                    }
                    //else
                    //{
                    //    chile.MdiParent = Parent;
                    //    chile.Show();
                    //}
                }
                if (i == 0)
                {
                    chile.MdiParent = Parent;
                        chile.Show();
                        chile.WindowState = FormWindowState.Normal;
                    
                }
                
            }
        }
    }
}
