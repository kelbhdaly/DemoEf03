using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Demo.ModelConfiguration
{
    internal class InstructorConfiguration:IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id)
                .UseIdentityColumn(202500, 1);

            builder.Property(I => I.Name)
                     .HasColumnType("Varchar(50)");

            builder.HasOne(I => I.ManagedDepartment)
                .WithOne(D => D.Manager)
                .HasForeignKey<Department>(D => D.ManagerId);

            builder.HasOne(I => I.WorkingDepartment)
                .WithMany(D => D.Instructors)
                .HasForeignKey(I => I.WorkingDepartmentId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    
    }
}
