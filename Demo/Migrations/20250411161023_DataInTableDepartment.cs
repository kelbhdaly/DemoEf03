using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class DataInTableDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "ManagerId", "Name" },
                values: new object[,]
                {
                    { 90, null, "Test2" },
                    { 100, null, "Test02" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "HiringDate", "ManagerId", "Name" },
                values: new object[,]
                {
                    { 40, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Design" },
                    { 50, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Software" }
                });
        }
    }
}
