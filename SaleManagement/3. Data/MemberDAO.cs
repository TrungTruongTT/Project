using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManagement._2._Entity;
using SaleManagement._4._Business_Object;
namespace SaleManagement._3._Data
{
    internal class MemberDAO
    {
        private SaleDBContext db = new SaleDBContext();

        public tblMember getRow(string tendangnhap)
        {
            tblMember member = db.tblMember.Where(m => m.Email == tendangnhap).FirstOrDefault();
            return member;
        }
    }
}
