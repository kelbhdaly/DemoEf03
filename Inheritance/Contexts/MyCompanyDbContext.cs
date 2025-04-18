using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Models;
using Microsoft.EntityFrameworkCore;

namespace Inheritance.Contexts
{
    internal class MyCompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=MyCompany; Trusted_Connection=True ; TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<FulltimeEmployee>()
            //    .HasBaseType(typeof(Employee));


            //modelBuilder.Entity<ParttimeEmployee>()
            //    .HasBaseType(typeof(Employee));

            //modelBuilder.Entity<Employee>()
            //    .HasDiscriminator<string>("EmployeeType")
            //    .HasValue<FulltimeEmployee>("FTE")
            //    .HasValue<ParttimeEmployee>("PTE");
            modelBuilder.Entity<ParttimeEmployee>().ToTable("ParttimeEmployee");
            modelBuilder.Entity<FulltimeEmployee>().ToTable("FulltimeEmployee");
        }

        public DbSet<ParttimeEmployee> ParttimeEmployees { get; set; }
        public DbSet<FulltimeEmployee> FulltimeEmployees { get; set; }

        public DbSet<Employee> Employees { get; set; }



    }
}
