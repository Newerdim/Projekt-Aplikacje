﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt_Aplikacje.Data;

namespace Projekt_Aplikacje.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Projekt_Aplikacje.Models.DataGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DataGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Waga",
                            Unit = "kg"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kalorie",
                            Unit = "kcal"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sen",
                            Unit = "h"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Woda",
                            Unit = "ml"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Trening",
                            Unit = "h"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Samopoczucie",
                            Unit = ""
                        });
                });

            modelBuilder.Entity("Projekt_Aplikacje.Models.DataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DataGroupId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DataGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Datas");
                });

            modelBuilder.Entity("Todo.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(4000)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(4000)");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Projekt_Aplikacje.Models.DataModel", b =>
                {
                    b.HasOne("Projekt_Aplikacje.Models.DataGroup", "DataGroup")
                        .WithMany("Datas")
                        .HasForeignKey("DataGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Todo.Models.User", "User")
                        .WithMany("Datas")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
