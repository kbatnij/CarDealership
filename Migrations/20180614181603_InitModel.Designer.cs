﻿// <auto-generated />
using System;
using CarDealership.Presistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarDealership.Migrations
{
    [DbContext(typeof(CarDealershipDbContext))]
    [Migration("20180614181603_InitModel")]
    partial class InitModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799");

            modelBuilder.Entity("CarDealership.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<bool?>("HasHeatedSeats");

                    b.Property<bool?>("HasLowMiles");

                    b.Property<bool?>("HasNavigation");

                    b.Property<bool?>("HasPowerWindows");

                    b.Property<bool?>("HasSunroof");

                    b.Property<bool?>("IsFourWheelDrive");

                    b.Property<string>("Make");

                    b.Property<decimal>("Price");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
