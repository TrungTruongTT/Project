using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManagement._2._Entity;
using System.Data.Entity;

namespace SaleManagement._3._Data
{
    internal class ProductDAO
    {
        private SaleDBContext db = new SaleDBContext();
        public List<tblProduct> getList()
        {
            //select * form product
            List<tblProduct> list = db.tblProduct.ToList();
            return list;
        }

        public void Insert(tblProduct product)
        {
            db.tblProduct.Add(product);
            db.SaveChanges();
        }

        public void Update(tblProduct product)
        {
            //db.Entry(product).State = EntityState.Modified;
            //db.SaveChanges();

            var entry = db.Entry(product);
            if(entry.State==EntityState.Detached || entry.State == EntityState.Modified)
            {
                db.Set<tblProduct>().Attach(product);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }



    }

}
