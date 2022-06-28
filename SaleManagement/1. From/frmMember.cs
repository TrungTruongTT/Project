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
using SaleManagement._3._Data;
using SaleManagement._2._Entity;

namespace SaleManagement._1._From
{
    public partial class frmMember : Form
    {
        tblMember loginMember = null;
        private MemberDAO memberDAO = new MemberDAO();

        private ProductDAO product = new ProductDAO(); 
        string function = null;
        public frmMember(tblMember member)
        {
            InitializeComponent();
            loginMember = member;
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tài khoản : " + loginMember.Email;

            if(loginMember.Email == "admin@fstore.com")
            {
                
                loadMember();
                tool(false);
                btnEdit.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;

            }
            else
            {

                

                tool(false);
                
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        

        private void loadMember()
        {
            dgvMember.DataSource = memberDAO.getList();
            
            
        }

        private void tool(Boolean check)
        {
            txtMemberId.Enabled= check;
            txtPassword.Enabled = check;
            txtEmail.Enabled = check;
            txtCompanyName.Enabled = check;
            txtCity.Enabled = check;
            txtCountry.Enabled = check;
        }
        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex < 0 || rowindex >= dgvMember.Rows.Count)
                {
                    throw new Exception("Chưa chọn đúng thông tin");
                }
                txtMemberId.Text = dgvMember.Rows[rowindex].Cells["MemberId"].Value.ToString();
                txtPassword.Text = dgvMember.Rows[rowindex].Cells["Password"].Value.ToString();
                txtEmail.Text = dgvMember.Rows[rowindex].Cells["Email"].Value.ToString();
                txtCompanyName.Text = dgvMember.Rows[rowindex].Cells["CompanyName"].Value.ToString();
                txtCity.Text = dgvMember.Rows[rowindex].Cells["City"].Value.ToString();
                txtCountry.Text = dgvMember.Rows[rowindex].Cells["Country"].Value.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tool(true);
            btnSave.Enabled = true;
            function = "Add";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(loginMember.Email == "admin@fstore.com")
            {
                tool(true);
                btnSave.Enabled = true;
                txtMemberId.Enabled = false;
                txtEmail.Enabled = false;
                function = "Edit";
            }
            else
            {
                tblMember member = memberDAO.GetRowByID(loginMember.MemberId);
                txtEmail.Text = member.Email;
                txtMemberId.Text = member.MemberId.ToString();
                txtPassword.Text = member.Password;
                txtCompanyName.Text = member.CompanyName;
                txtCity.Text = member.City;
                txtCountry.Text = member.Country;

                tool(true);
                btnSave.Enabled = true;
                txtMemberId.Enabled = false;
                txtEmail.Enabled = false;
                function = "Edit";
            }
            
                
            
            
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(loginMember.Email != "admin@fstore.com")
            {
                tblMember member = new tblMember();

                member.MemberId = int.Parse(txtMemberId.Text.Trim());
                member.Password = txtPassword.Text.Trim();
                member.Email = txtEmail.Text.Trim();
                member.CompanyName = txtCompanyName.Text.Trim();
                member.City = txtCity.Text.Trim();
                member.Country = txtCountry.Text.Trim();

                switch (function)
                {
                    case "Add":
                        {
                            memberDAO.Insert(member);
                            clear();
                            MessageBox.Show("Thêm thành công", "Thông báo");
                            break;
                        }
                    case "Edit":
                        {
                            memberDAO.Update(member);
                            clear();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            break;
                        }
                }
            }
            else
            {
                try
                {
                    if (loginMember.Email == txtEmail.Text.Trim())
                    {
                        throw new Exception("Không thể Edit Admin.");
                    }
                    tblMember member = new tblMember();

                    member.MemberId = int.Parse(txtMemberId.Text.Trim());
                    member.Password = txtPassword.Text.Trim();
                    member.Email = txtEmail.Text.Trim();
                    member.CompanyName = txtCompanyName.Text.Trim();
                    member.City = txtCity.Text.Trim();
                    member.Country = txtCountry.Text.Trim();

                    switch (function)
                    {
                        case "Add":
                            {
                                memberDAO.Insert(member);
                                loadMember();
                                MessageBox.Show("Thêm thành công", "Thông báo");
                                clear();
                                break;
                            }
                        case "Edit":
                            {
                                memberDAO.Update(member);
                                loadMember();
                                MessageBox.Show("Sửa thành công", "Thông báo");
                                clear();
                                break;
                            }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }
            
        }

        private void clear()
        {
            txtMemberId.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = String.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int memberId = int.Parse(txtMemberId.Text.Trim());

                tblMember member = memberDAO.GetRowByID(memberId);
                if (member.Email == loginMember.Email)
                {
                    throw new Exception("Không thể xóa Admin");
                }

                memberDAO.Delete(member);
                MessageBox.Show("Xóa thành công", "Thông báo");
                dgvMember.DataSource = memberDAO.getList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            
        }
    }
}
