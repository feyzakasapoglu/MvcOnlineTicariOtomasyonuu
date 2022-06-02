using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.Entites.Model;

namespace TicariOtomasyon.DAL.EF.Contexts
{
   public class TicariDbContext:DbContext
    {
       public DbSet<Admin> Admins { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Expences> Expences { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<SalesMovements> SalesMovements { get; set; }

        public TicariDbContext()
        {

        }

        public TicariDbContext(DbContextOptions<TicariDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=TicariOtomasyon;trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
            
        }

    }
}
