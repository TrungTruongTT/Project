using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaleManagement._3._Data;
using SaleManagement._2._Entity;

namespace SaleManagement._1.Presentation_Layer
{
    public partial class frmLogin : Form
    {
        private MemberDAO memberDao = new MemberDAO();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbEmai_Click(object sender, EventArgs e)
        {

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail.Text.Length < 6)
                {
                    throw new Exception("Sai tên đăng nhập");
                }
                if (txtPassword.Text.Length < 4)
                {
                    throw new Exception("Sai tên mật khẩu");
                }

                string tenDangNhap = txtEmail.Text.Trim();
                string matkhau = txtPassword.Text.Trim();
                tblMember member = memberDao.getRow(tenDangNhap);

                if (member == null)
                {
                    throw new Exception("Tên đăng nhập không tồn tại");
                }
                if(member.Password != matkhau)
                {
                    throw new Exception("Mật khẩu không chính xác");
                }
                Form frmmain = new frmMain(member);
                frmmain.ShowDialog();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
