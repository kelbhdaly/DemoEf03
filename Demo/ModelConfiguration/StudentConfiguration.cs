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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasOne(S => S.DepLocated)
                .WithMany(D => D.StuLocated)
                .HasForeignKey(S => S.DepLocatedId);


            //builder.HasMany(S => S.Courses)
            //    .WithMany(C => C.Students)
            //    .UsingEntity(Rt => Rt.ToTable(""));


            
        }
    }
}
