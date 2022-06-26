namespace SaleManagement._2._Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblProduct")]
    public partial class tblProduct
    {
        

        [Key]
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(20)]
        public string Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public int UnitslnStock { get; set; }

        
    }
}
