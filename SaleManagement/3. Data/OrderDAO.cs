using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManagement._2._Entity;

namespace SaleManagement._3._Data
{
    internal class OrderDAO
    {
        SaleDBContext db = new SaleDBContext();
        public List<tblOrder> getList()
        {
            return db.tblOrder.ToList();
        }

        public List<tblOrderDetail> getListOrder(int orderId){
            return db.tblOrderDetail.Where(m=>m.OrderId==orderId).ToList();
        }
    }
}
