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


        public List<tblMember> getList()
        {
            
            return db.tblMember.ToList();
        }

        

        public void Insert(tblMember member)
        {
            db.tblMember.Add(member);
            db.SaveChanges();
        }

        public void Update(tblMember member)
        {
            int memberId = member.MemberId;

            tblMember newmember = GetRowByID(memberId);

            if(newmember != null)
            {
                newmember.MemberId = member.MemberId;
                newmember.Password = member.Password;
                newmember.Email = member.Email;
                newmember.CompanyName = member.CompanyName;
                newmember.City = member.City;
                newmember.Country = member.Country;

                db.SaveChanges();
            }
        }

        public tblMember GetRowByID(int memberId)
        {
            return db.tblMember.Where(m => m.MemberId == memberId).FirstOrDefault();
        }

        public void Delete(tblMember member)
        {
            
                db.tblMember.Remove(member);
                db.SaveChanges();
            
        }
    }
}
