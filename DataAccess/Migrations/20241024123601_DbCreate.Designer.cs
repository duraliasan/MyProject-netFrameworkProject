﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241024123601_DbCreate")]
    partial class DbCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserRoleClaim", b =>
                {
                    b.Property<int>("UserRoleClaimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserRoleClaimID"));

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserRoleClaimID");

                    b.ToTable("UserRoleClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("DistrictID")
                        .HasColumnType("int");

                    b.Property<int>("NeighborhoodID")
                        .HasColumnType("int");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Entities.Concrete.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.HasKey("CartID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Entities.Concrete.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemID"));

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CartItemID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryImage")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Property<int>("ColorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorID"));

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ColorImage")
                        .HasColumnType("int");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Entities.Concrete.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateOnly?>("CustomerBirthOfDate")
                        .HasColumnType("date");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnable")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("customerPassword")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("customerPasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Entities.Concrete.Email", b =>
                {
                    b.Property<int>("EmailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailID"));

                    b.Property<string>("EmailEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnable")
                        .HasColumnType("bit");

                    b.Property<bool>("SendMessage")
                        .HasColumnType("bit");

                    b.HasKey("EmailID");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Entities.Concrete.ImageUrl", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<string>("ImageDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageID");

                    b.ToTable("ImageUrls");
                });

            modelBuilder.Entity("Entities.Concrete.Phone", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneID"));

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isEnable")
                        .HasColumnType("bit");

                    b.Property<bool>("sendMessage")
                        .HasColumnType("bit");

                    b.HasKey("PhoneID");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("ColorID")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ProductWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QualityID")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("UnitsInStock")
                        .HasColumnType("smallint");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.Concrete.Quality", b =>
                {
                    b.Property<int>("QualityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QualityID"));

                    b.Property<string>("QualityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QualityID");

                    b.ToTable("Qualities");
                });
#pragma warning restore 612, 618
        }
    }
}