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
            int id = product.ProductId;
            tblProduct newproduct = getRow(id);
            if(newproduct != null)
            {
                newproduct.ProductName = product.ProductName;
                newproduct.CategoryId = product.CategoryId;
                newproduct.Weight = product.Weight;
                newproduct.UnitPrice = product.UnitPrice;
                newproduct.UnitslnStock = product.UnitslnStock;
                db.SaveChanges();
            }

            
        }


        public tblProduct getRow(int productId)
        {
            tblProduct product = db.tblProduct.Where(m=>m.ProductId == productId)
                .FirstOrDefault();
            return product;
        }

        public void Delete(int productId)
        {
            tblProduct newproduct = getRow(productId);
            if(newproduct != null)
            {
                db.tblProduct.Remove(newproduct);
                db.SaveChanges();
            }
        }

    }

}
