using EF_01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Configration
{
    internal class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(E => E.EmpId);

            modelBuilder.Entity<Employee>().Property(E => E.Name).IsRequired().HasColumnType("varchar").HasMaxLength(50);

            modelBuilder.Entity<Employee>().Property(E => E.Salary).IsRequired(false);

            modelBuilder.Entity<Employee>().Property(E => E.DateOfCreation).HasDefaultValue(DateTime.Now);
        }
    }
}
