﻿// <auto-generated />
using System;
using Inheritance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inheritance.Migrations
{
    [DbContext(typeof(MyCompanyDbContext))]
    partial class MyCompanyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inheritance.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Inheritance.Models.FulltimeEmployee", b =>
                {
                    b.HasBaseType("Inheritance.Models.Employee");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.ToTable("FulltimeEmployee", (string)null);
                });

            modelBuilder.Entity("Inheritance.Models.ParttimeEmployee", b =>
                {
                    b.HasBaseType("Inheritance.Models.Employee");

                    b.Property<int>("CountOfHours")
                        .HasColumnType("int");

                    b.Property<decimal>("HourRate")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("ParttimeEmployee", (string)null);
                });

            modelBuilder.Entity("Inheritance.Models.FulltimeEmployee", b =>
                {
                    b.HasOne("Inheritance.Models.Employee", null)
                        .WithOne()
                        .HasForeignKey("Inheritance.Models.FulltimeEmployee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inheritance.Models.ParttimeEmployee", b =>
                {
                    b.HasOne("Inheritance.Models.Employee", null)
                        .WithOne()
                        .HasForeignKey("Inheritance.Models.ParttimeEmployee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
