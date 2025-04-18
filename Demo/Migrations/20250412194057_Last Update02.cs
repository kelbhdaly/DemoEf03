using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class LastUpdate02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HiringDate",
                table: "Departments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DeptID",
                keyValue: 90,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DeptID",
                keyValue: 100,
                columns: new string[0],
                values: new object[0]);
        }
    }
}
