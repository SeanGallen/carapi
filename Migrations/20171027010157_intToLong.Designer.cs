﻿// <auto-generated />
using getVehicleLocationAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace getVehicleLocationAPI.Migrations
{
    [DbContext(typeof(LocationContext))]
    [Migration("20171027010157_intToLong")]
    partial class intToLong
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("getVehicleLocationAPI.Model.VehicleLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<long>("Latitude");

                    b.Property<long>("Longitude");

                    b.Property<int>("VehicleId");

                    b.Property<string>("VehicleLatLong");

                    b.HasKey("Id");

                    b.ToTable("VechicleLocations");
                });
#pragma warning restore 612, 618
        }
    }
}
