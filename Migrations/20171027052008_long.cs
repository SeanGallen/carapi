using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace getVehicleLocationAPI.Migrations
{
    public partial class @long : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Active",
                table: "VechicleLocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "VechicleLocations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
