using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MvcOnlineTicariOtomasyonuu.Models.Classes
{
    public class Context:DbContext
    {
        DbSet<Admin> Admins { get; set; }
        DbSet<BillDetail>BillDetails { get; set; }
        DbSet<Bills> Bills { get; set; }
        DbSet<Cariler> Carilers { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Employees> Employees { get; set; }
        DbSet<Expences> Expences { get; set; }
        DbSet<Products> Products { get; set; }
        DbSet<SalesMovements> SalesMovements { get; set; }




    }
}