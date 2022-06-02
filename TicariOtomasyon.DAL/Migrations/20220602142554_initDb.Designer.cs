﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicariOtomasyon.DAL.EF.Contexts;

namespace TicariOtomasyon.DAL.Migrations
{
    [DbContext(typeof(TicariDbContext))]
    [Migration("20220602142554_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Authority")
                        .HasMaxLength(1)
                        .HasColumnType("Varchar(1)");

                    b.Property<string>("Password")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("UserName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.BillDetail", b =>
                {
                    b.Property<int>("BillDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BillsBillID")
                        .HasColumnType("int");

                    b.Property<string>("Describe")
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BillDetailID");

                    b.HasIndex("BillsBillID");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Bills", b =>
                {
                    b.Property<int>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillSequenceNo")
                        .HasMaxLength(1)
                        .HasColumnType("Char(1)");

                    b.Property<string>("BillSerialNo")
                        .HasMaxLength(10)
                        .HasColumnType("Varchar(10)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaxOffice")
                        .HasMaxLength(60)
                        .HasColumnType("Varchar(60)");

                    b.Property<string>("TeslimAlan")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("TeslimEden")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("BillID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Cariler", b =>
                {
                    b.Property<int>("CariID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CariCity")
                        .HasMaxLength(13)
                        .HasColumnType("Varchar(13)");

                    b.Property<string>("CariEmail")
                        .HasMaxLength(50)
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("CariLastName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("CariName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("CariID");

                    b.ToTable("Carilers");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Employees", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeImage")
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<string>("EmployeeLastName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Expences", b =>
                {
                    b.Property<int>("ExpenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Describe")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ExpenceID");

                    b.ToTable("Expences");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)");

                    b.Property<string>("Productİmage")
                        .HasMaxLength(250)
                        .HasColumnType("Varchar(250)");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<short>("Stock")
                        .HasColumnType("smallint");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.SalesMovements", b =>
                {
                    b.Property<int>("SalesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarilersCariID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeesEmployeeID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductsProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SumPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SalesID");

                    b.HasIndex("CarilersCariID");

                    b.HasIndex("EmployeesEmployeeID");

                    b.HasIndex("ProductsProductID");

                    b.ToTable("SalesMovements");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.BillDetail", b =>
                {
                    b.HasOne("TicariOtomasyon.Entites.Model.Bills", "Bills")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillsBillID");

                    b.Navigation("Bills");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Employees", b =>
                {
                    b.HasOne("TicariOtomasyon.Entites.Model.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Products", b =>
                {
                    b.HasOne("TicariOtomasyon.Entites.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.SalesMovements", b =>
                {
                    b.HasOne("TicariOtomasyon.Entites.Model.Cariler", "Carilers")
                        .WithMany("SalesMovements")
                        .HasForeignKey("CarilersCariID");

                    b.HasOne("TicariOtomasyon.Entites.Model.Employees", "Employees")
                        .WithMany("SalesMovements")
                        .HasForeignKey("EmployeesEmployeeID");

                    b.HasOne("TicariOtomasyon.Entites.Model.Products", "Products")
                        .WithMany("SalesMovements")
                        .HasForeignKey("ProductsProductID");

                    b.Navigation("Carilers");

                    b.Navigation("Employees");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Bills", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Cariler", b =>
                {
                    b.Navigation("SalesMovements");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Employees", b =>
                {
                    b.Navigation("SalesMovements");
                });

            modelBuilder.Entity("TicariOtomasyon.Entites.Model.Products", b =>
                {
                    b.Navigation("SalesMovements");
                });
#pragma warning restore 612, 618
        }
    }
}