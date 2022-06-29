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
    public partial class frmOrder : Form
    {
        private OrderDAO orderdao = new OrderDAO();
        tblMember loginMember = null;
        public frmOrder(tblMember member)
        {
            InitializeComponent();
            loginMember = member;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Tài khoản : " + loginMember.Email;
            loadOrder();

        }


        private void loadOrder()
        {
            dgvOrder.DataSource = orderdao.getList();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex < 0 || rowindex >= dgvOrder.Rows.Count)
                {
                    throw new Exception("Chưa chọn đúng thông tin");
                }
                txtOrderID.Text = dgvOrder.Rows[rowindex].Cells["OrderId"].Value.ToString();
                cboMemberID.Text = dgvOrder.Rows[rowindex].Cells["MemberId"].Value.ToString();
                txtorderDate.Text = dgvOrder.Rows[rowindex].Cells["OrderDate"].Value.ToString();
                txtrequireDate.Text = dgvOrder.Rows[rowindex].Cells["RequiredDate"].Value.ToString();
                txtshippedDate.Text = dgvOrder.Rows[rowindex].Cells["ShippedDate"].Value.ToString();
                txtFreight.Text = dgvOrder.Rows[rowindex].Cells["Freight"].Value.ToString();


                int orderId = int.Parse(dgvOrder.Rows[rowindex].Cells["OrderId"].Value.ToString());
                loadDetail(orderId);
                //btnEdit.Enabled = true;
                //btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void loadDetail(int orderId)
        {
            dgvDetail.DataSource = orderdao.getListOrder(orderId);
        }
    }
}
