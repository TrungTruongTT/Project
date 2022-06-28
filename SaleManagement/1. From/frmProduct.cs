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
using SaleManagement._3._Data;
namespace SaleManagement._1._From
{
    public partial class frmProduct : Form
    {
        tblMember loginMember = null;
        string function = null;
        private ProductDAO productDao = new ProductDAO();
        public frmProduct(tblMember member)
        {
            InitializeComponent();
            loginMember = member;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tài khoản : " + loginMember.Email;
            loadProduct();
            tool(false);
            btnEdit.Enabled= false;
            
            btnSave.Enabled= false;
            btnDelete.Enabled = false;
        }

        private void loadProduct()
        {
            dgvProduct.DataSource = productDao.getList();
        }

        private void tool(Boolean check)
        {
            txtCategoryID.Enabled = check;
            txtProductID.Enabled = check;
            txtProductName.Enabled = check;
            txtWeight.Enabled = check;
            txtWeight.Enabled = check;
            txtPrice.Enabled = check;
            txtStock.Enabled = check;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tool(true);
            function = "Add";
            btnSave.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tool(true);
            function = "Edit";
            btnSave.Enabled = true;
            txtProductID.Enabled = false;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex < 0 || rowindex>=dgvProduct.Rows.Count)
                {
                    throw new Exception("Chưa chọn đúng thông tin");
                }

                txtProductID.Text = dgvProduct.Rows[rowindex].Cells["ProductId"].Value.ToString();
                txtCategoryID.Text = dgvProduct.Rows[rowindex].Cells["CategoryId"].Value.ToString();
                txtProductName.Text = dgvProduct.Rows[rowindex].Cells["ProductName"].Value.ToString();
                txtWeight.Text = dgvProduct.Rows[rowindex].Cells["Weight"].Value.ToString();
                txtPrice.Text = dgvProduct.Rows[rowindex].Cells["UnitPrice"].Value.ToString();
                txtStock.Text = dgvProduct.Rows[rowindex].Cells["UnitslnStock"].Value.ToString();

                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tblProduct product = new tblProduct();

                product.ProductId = int.Parse(txtProductID.Text.Trim());
                product.CategoryId= int.Parse(txtCategoryID.Text.Trim());
                product.ProductName= txtProductName.Text.Trim();
                product.Weight = txtWeight.Text.Trim();
                product.UnitPrice = decimal.Parse(txtPrice.Text.Trim());
                product.UnitslnStock= int.Parse(txtStock.Text.Trim());
                
                switch (function)
                {
                    case "Add":
                        {
                            productDao.Insert(product);
                            loadProduct();
                            MessageBox.Show("Thêm thành công.", "Thông báo");
                            clear();
                            break;
                        }
                    case "Edit":
                        {
                            productDao.Update(product);
                            loadProduct();
                            MessageBox.Show("Sửa thành công.", "Thông báo");
                            clear();
                            break;
                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            
        }

        private void clear()
        {
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtProductID.Text.Trim());
            productDao.Delete(productId);
            MessageBox.Show("Xóa thành công.", "Thông báo");
            dgvProduct.DataSource = productDao.getList();
        }
    }
}
