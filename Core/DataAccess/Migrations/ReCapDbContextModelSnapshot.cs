﻿using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(CarRentalContext))]
    partial class ReCapDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("OperationClaims");
            });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Email")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .HasColumnType("nvarchar(max)");

                b.Property<byte[]>("PasswordHash")
                    .HasColumnType("varbinary(max)");

                b.Property<byte[]>("PasswordSalt")
                    .HasColumnType("varbinary(max)");

                b.Property<bool>("Status")
                    .HasColumnType("bit");

                b.HasKey("Id");

                b.ToTable("Users");
            });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("OperationClaimId")
                    .HasColumnType("int");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("UserOperationClaims");
            });

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
            {
                b.Property<int>("BrandId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("BrandId");

                b.ToTable("Brands");
            });

            modelBuilder.Entity("Entities.Concrete.Car", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("BrandId")
                    .HasColumnType("int");

                b.Property<int>("ColorId")
                    .HasColumnType("int");

                b.Property<decimal>("DailyPrice")
                    .HasColumnType("decimal(18,2)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("ModelYear")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Cars");
            });

            modelBuilder.Entity("Entities.Concrete.CarImage", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CarId")
                    .HasColumnType("int");

                b.Property<DateTime?>("Date")
                    .HasColumnType("datetime2");

                b.Property<string>("ImagePath")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("CarImages");
            });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
            {
                b.Property<int>("ColorId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ColorId");

                b.ToTable("Colors");
            });

            modelBuilder.Entity("Entities.Concrete.Customer", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("CompanyName")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Customers");
            });

            modelBuilder.Entity("Entities.Concrete.Rental", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CarID")
                    .HasColumnType("int");

                b.Property<int>("CustomerID")
                    .HasColumnType("int");

                b.Property<DateTime>("RentDate")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("ReturnDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.ToTable("Rentals");
            });
#pragma warning restore 612, 618
        }
    }
}