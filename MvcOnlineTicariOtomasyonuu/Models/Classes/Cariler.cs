using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyonuu.Models.Classes
{
    public class Cariler
    {
        [Key]
        public int CariID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariLastName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        public string CariCity { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariEmail { get; set; }
        public ICollection<SalesMovements> SalesMovements { get; set; }



    }
}