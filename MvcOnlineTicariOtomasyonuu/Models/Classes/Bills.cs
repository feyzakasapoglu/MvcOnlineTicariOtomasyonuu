using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyonuu.Models.Classes
{
    public class Bills
    {
        [Key]
        public int BillID { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string BillSequenceNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string BillSerialNo { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxOffice { get; set; }

        public DateTime Time { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimEden { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }
         public ICollection<BillDetail>BillDetails { get; set; }
    }
}