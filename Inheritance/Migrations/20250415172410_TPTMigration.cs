using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class TPTMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FulltimeEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FulltimeEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FulltimeEmployee_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParttimeEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    HourRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CountOfHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParttimeEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParttimeEmployee_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FulltimeEmployee");

            migrationBuilder.DropTable(
                name: "ParttimeEmployee");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
