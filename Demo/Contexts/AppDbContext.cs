using EF_01.Configration;
using EF_01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Contexts
{
    internal class AppDbContext : DbContext
    {

        // Microsoft.EntityFrameworkCore


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey("EmpId");
            //modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);

            //modelBuilder.Entity<Employee>().Property(E => E.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50);

            //modelBuilder.Entity<Employee>().Property(E => E.Salary).IsRequired(false);

            //modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);


            modelBuilder.ApplyConfiguration(new EmployeeConfigration());


        }



        public AppDbContext() : base() 
        {
            
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = App01; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }


    }
}
