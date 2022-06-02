using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyonuu.Models.Classes
{
    public class BillDetail
    {
        [Key]
        public int BillDetailID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Describe { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public Bills Bills{ get; set; }
    }
}