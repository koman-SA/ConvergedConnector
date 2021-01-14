using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConvergedConnector.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 1, 14, 7, 13, 31, 824, DateTimeKind.Utc).AddTicks(4346));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2021, 1, 14, 7, 11, 37, 474, DateTimeKind.Utc).AddTicks(3399));
        }
    }
}
