﻿// <auto-generated />
using System;
using Hotel.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.Database
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20240924224155_first_migration")]
    partial class first_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Hotel.app.Models.Guest", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<bool?>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Hotel.app.Models.Reserve", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GuestId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoomId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("Hotel.app.Models.Room", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Hotel.app.Models.Reserve", b =>
                {
                    b.HasOne("Hotel.app.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId");

                    b.HasOne("Hotel.app.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });
#pragma warning restore 612, 618
        }
    }
}
