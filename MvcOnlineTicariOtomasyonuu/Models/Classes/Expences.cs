using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyonuu.Models.Classes
{
    public class Expences
    {
        [Key]
        public int ExpenceID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Describe { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}