using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace getVehicleLocationAPI.Migrations
{
    public partial class intToLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Longitude",
                table: "VechicleLocations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "Latitude",
                table: "VechicleLocations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Longitude",
                table: "VechicleLocations",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Latitude",
                table: "VechicleLocations",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
