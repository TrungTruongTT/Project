using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManagement._1._From;
using SaleManagement._2._Entity;
namespace SaleManagement._1.Presentation_Layer
{
    public partial class frmMain : Form
    {
        tblMember loginMember = null;
        public frmMain(tblMember member)
        {
            InitializeComponent();
            loginMember = member;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelHoten.Text = "Tài khoản :"+loginMember.Email;
        }

        private void QLSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(loginMember.Email != "admin@fstore.com")
                {
                    throw new Exception("Bạn không có quyền admin");
                }
                Form frmproduct = new frmProduct(loginMember);
                frmproduct.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            
        }

        private void QLTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Form frmmember = new frmMember(loginMember);
                frmmember.ShowDialog();
            
        }
    }
}
