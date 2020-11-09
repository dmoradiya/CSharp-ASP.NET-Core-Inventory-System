﻿// <auto-generated />
using Inventory_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inventory_System.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20201109214942_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Inventory_System.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<bool>("Discontinue")
                        .HasColumnType("bool");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int>("Quantity")
                        .HasColumnType("int(10)");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            Discontinue = true,
                            Name = "IPhone 3G",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -2,
                            Discontinue = true,
                            Name = "IPhone 3",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -3,
                            Discontinue = true,
                            Name = "IPhone 4",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -5,
                            Discontinue = false,
                            Name = "IPhone 4S",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -6,
                            Discontinue = false,
                            Name = "IPhone 5",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -7,
                            Discontinue = false,
                            Name = "IPhone 5S",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -8,
                            Discontinue = false,
                            Name = "IPhone 6",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -9,
                            Discontinue = false,
                            Name = "IPhone 6S",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -10,
                            Discontinue = false,
                            Name = "IPhone 7",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -11,
                            Discontinue = false,
                            Name = "IPhone 7Plus",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -12,
                            Discontinue = false,
                            Name = "IPhone 8",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -13,
                            Discontinue = false,
                            Name = "IPhone 8Plus",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -14,
                            Discontinue = false,
                            Name = "IPhone X",
                            Quantity = 0
                        },
                        new
                        {
                            ID = -15,
                            Discontinue = false,
                            Name = "IPhone 11",
                            Quantity = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
