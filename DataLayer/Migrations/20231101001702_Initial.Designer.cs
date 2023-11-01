﻿// <auto-generated />
using System;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(SmallStoreContext))]
    [Migration("20231101001702_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("fullName");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("DataLayer.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("price");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("DataLayer.Models.ProductClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime")
                        .HasColumnName("created");

                    b.Property<int>("IdClient")
                        .HasColumnType("int")
                        .HasColumnName("idClient");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int")
                        .HasColumnName("idProduct");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdProduct");

                    b.ToTable("ProductClient", (string)null);
                });

            modelBuilder.Entity("DataLayer.Models.ProductClient", b =>
                {
                    b.HasOne("DataLayer.Models.Client", "IdClientNavigation")
                        .WithMany("ProductClients")
                        .HasForeignKey("IdClient")
                        .IsRequired()
                        .HasConstraintName("FK_ProductClient_Client");

                    b.HasOne("DataLayer.Models.Product", "IdProductNavigation")
                        .WithMany("ProductClients")
                        .HasForeignKey("IdProduct")
                        .IsRequired()
                        .HasConstraintName("FK_ProductClient_Product");

                    b.Navigation("IdClientNavigation");

                    b.Navigation("IdProductNavigation");
                });

            modelBuilder.Entity("DataLayer.Models.Client", b =>
                {
                    b.Navigation("ProductClients");
                });

            modelBuilder.Entity("DataLayer.Models.Product", b =>
                {
                    b.Navigation("ProductClients");
                });
#pragma warning restore 612, 618
        }
    }
}
