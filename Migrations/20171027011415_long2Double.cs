using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace getVehicleLocationAPI.Migrations
{
    public partial class long2Double : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "VechicleLocations",
                type: "float",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "VechicleLocations",
                type: "float",
                nullable: false,
                oldClrType: typeof(long));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Longitude",
                table: "VechicleLocations",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<long>(
                name: "Latitude",
                table: "VechicleLocations",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
