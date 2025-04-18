using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.ModelConfiguration
{
    internal class DepartmentConfiguration :IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.DeptID);
            builder.Property(D => D.DeptID)
                .UseIdentityColumn(10, 10)
                .HasColumnType("integer");
            builder.HasMany<Student>(D => D.StuLocated)
                .WithOne(S => S.DepLocated)
                .HasForeignKey(S => S.DepLocatedId);
            //builder.Property(D => D.HiringDate)
            //    .HasDefaultValueSql("getdate()");


          
        }
    }
}
