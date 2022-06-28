using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManagement._2._Entity;

namespace SaleManagement._1._From
{
    public partial class frmOrder : Form
    {
        tblMember loginMember = null;
        public frmOrder(tblMember member)
        {
            InitializeComponent();
            loginMember = member;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tài khoản : " + loginMember.Email;
        }
    }
}
