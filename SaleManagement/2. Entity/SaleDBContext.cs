using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SaleManagement._2._Entity
{
    public partial class SaleDBContext : DbContext
    {
        public SaleDBContext()
            : base("name=SaleDBContext")
        {
        }

        public virtual DbSet<tblMember> tblMember { get; set; }
        public virtual DbSet<tblOrder> tblOrder { get; set; }
        public virtual DbSet<tblOrderDetail> tblOrderDetail { get; set; }
        public virtual DbSet<tblProduct> tblProduct { get; set; }

        
    }
}
