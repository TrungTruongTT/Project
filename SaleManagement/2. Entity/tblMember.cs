namespace SaleManagement._2._Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMember")]
    public partial class tblMember
    {
        

        [Key]
        public int MemberId { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(15)]
        public string City { get; set; }

        [Required]
        [StringLength(15)]
        public string Country { get; set; }

        
    }
}
