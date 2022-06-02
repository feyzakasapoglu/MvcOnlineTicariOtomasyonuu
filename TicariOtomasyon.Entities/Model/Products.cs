using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Entites.Model
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Column(TypeName="Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public bool State { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Productİmage { get; set; }
        public Category Category { get; set; }
        public ICollection<SalesMovements>SalesMovements { get; set; } 






    }
}