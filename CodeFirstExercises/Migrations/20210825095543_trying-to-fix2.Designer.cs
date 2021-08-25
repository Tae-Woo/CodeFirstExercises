﻿// <auto-generated />
using System;
using CodeFirstExercises.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirstExercises.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210825095543_trying-to-fix2")]
    partial class tryingtofix2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirstExercises.Data.Bil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasRadio")
                        .HasColumnType("bit");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RegNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CodeFirstExercises.Data.Lastbil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoadVolumeKvm")
                        .HasColumnType("int");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("RegNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("CodeFirstExercises.Data.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("CodeFirstExercises.Data.Bil", b =>
                {
                    b.HasOne("CodeFirstExercises.Data.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("CodeFirstExercises.Data.Lastbil", b =>
                {
                    b.HasOne("CodeFirstExercises.Data.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerId");

                    b.Navigation("Manufacturer");
                });
#pragma warning restore 612, 618
        }
    }
}
