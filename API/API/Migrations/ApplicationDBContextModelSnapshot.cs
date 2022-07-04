﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("DateTimeOffset(7)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("API.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cart_Id")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("CartItemId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("API.Models.Category", b =>
                {
                    b.Property<int>("Cat_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Cat_ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("API.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CustomerNumber")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CustomerPassword")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CustomerSurname")
                        .HasColumnType("varchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("API.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("O_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("O_Qty")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("API.Models.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cart_Id")
                        .HasColumnType("int");

                    b.Property<int>("Customer_o_Id")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<decimal>("OrdersAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrdersNumber")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("OrdersStatus")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("API.Models.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cat_Id")
                        .HasColumnType("int");

                    b.Property<string>("ProductDiscription")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProductImage1")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProductImage2")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProductImage3")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ProductName")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProductQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}