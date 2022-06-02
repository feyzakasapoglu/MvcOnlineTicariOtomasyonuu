using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyonuu.Models.Classes
{
    public class SalesMovements
    {
        [Key]
        public int SalesID { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SumPrice { get; set; }
        public Products Products { get; set; }
        public Cariler Carilers { get; set; }
        public  Employees Employees { get; set; }



    }
}