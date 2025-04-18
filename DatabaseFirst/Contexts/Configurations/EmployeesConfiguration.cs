﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DatabaseFirst.Contexts;
using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirst.Contexts.Configurations
{
    public partial class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> entity)
        {
            entity.HasKey(e => e.EmployeeId);

            entity.HasIndex(e => e.LastName, "LastName");

            entity.HasIndex(e => e.PostalCode, "PostalCode");

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Extension).HasMaxLength(4);
            entity.Property(e => e.FirstName).HasMaxLength(10);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.HomePhone).HasMaxLength(24);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Notes).HasColumnType("ntext");
            entity.Property(e => e.Photo).HasColumnType("image");
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.Title).HasMaxLength(30);
            entity.Property(e => e.TitleOfCourtesy).HasMaxLength(25);

            entity.HasOne(d => d.ReportsToNavigation).WithMany(p => p.InverseReportsToNavigation)
                .HasForeignKey(d => d.ReportsTo)
                .HasConstraintName("FK_Employees_Employees");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Employees> entity);
    }
}
