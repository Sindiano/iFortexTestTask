﻿// <auto-generated />
using System;
using Lab5TestTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab5TestTask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250314131030_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab5TestTask.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeviceType")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndedAtUTC")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartedAtUTC")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeviceType = 2,
                            EndedAtUTC = new DateTime(2024, 1, 12, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 1, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DeviceType = 1,
                            EndedAtUTC = new DateTime(2024, 2, 12, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 2, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            DeviceType = 0,
                            EndedAtUTC = new DateTime(2024, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 7
                        },
                        new
                        {
                            Id = 4,
                            DeviceType = 0,
                            EndedAtUTC = new DateTime(2024, 4, 12, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 4, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 6
                        },
                        new
                        {
                            Id = 5,
                            DeviceType = 2,
                            EndedAtUTC = new DateTime(2024, 5, 12, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 5, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            DeviceType = 2,
                            EndedAtUTC = new DateTime(2024, 6, 12, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 6, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 7,
                            DeviceType = 1,
                            EndedAtUTC = new DateTime(2024, 7, 12, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 7, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 5
                        },
                        new
                        {
                            Id = 8,
                            DeviceType = 1,
                            EndedAtUTC = new DateTime(2024, 8, 12, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 8, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 9,
                            DeviceType = 1,
                            EndedAtUTC = new DateTime(2024, 9, 12, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2024, 9, 12, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 10,
                            DeviceType = 0,
                            EndedAtUTC = new DateTime(2025, 10, 12, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 11,
                            DeviceType = 2,
                            EndedAtUTC = new DateTime(2025, 11, 12, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 5
                        },
                        new
                        {
                            Id = 12,
                            DeviceType = 1,
                            EndedAtUTC = new DateTime(2025, 12, 12, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 13,
                            DeviceType = 0,
                            EndedAtUTC = new DateTime(2025, 11, 12, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 14,
                            DeviceType = 0,
                            EndedAtUTC = new DateTime(2025, 12, 12, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2025, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 15,
                            DeviceType = 2,
                            EndedAtUTC = new DateTime(2025, 10, 12, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            StartedAtUTC = new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Lab5TestTask.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "user1@gmail.com",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "user2@gmail.com",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            Email = "user3@gmail.com",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Email = "user4@gmail.com",
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            Email = "user5@gmail.com",
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            Email = "user6@gmail.com",
                            Status = 0
                        },
                        new
                        {
                            Id = 7,
                            Email = "user7@gmail.com",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Lab5TestTask.Models.Session", b =>
                {
                    b.HasOne("Lab5TestTask.Models.User", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lab5TestTask.Models.User", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
