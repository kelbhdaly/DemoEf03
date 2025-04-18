using System.Reflection;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Contexts
{
    internal class ItiDb : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ITIDB; Trusted_Connection=True; TrustServerCertificate=True");
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            //modelBuilder.Entity<Department>().HasData(
            //  new Department() { ID = 40, Name = "Design", HiringDate = new DateTime(2025 , 12,5)},
            //  new Department() { ID = 50, Name = "Software", HiringDate = new DateTime(2025,1,15) }
            // );

            modelBuilder.Entity<Department>().HasData(

                new Department() { Name = "Test2", DeptID= 90 },
                new Department() { DeptID = 100, Name = "Test02" }

                );

        }

        #region Convert Model To Table In DB
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        //      public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Employee> Employees { get; set; }

        #endregion
    }
}
