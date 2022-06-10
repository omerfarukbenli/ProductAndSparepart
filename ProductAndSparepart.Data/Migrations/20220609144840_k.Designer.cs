﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductAndSparepart.Data.Context;

#nullable disable

namespace ProductAndSparepart.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220609144840_k")]
    partial class k
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductAndSparepart.Entity.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductAndSparepart.Entity.Models.ProductWithSparepart", b =>
                {
                    b.Property<int>("SparepartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("SparepartID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductWithSpareparts");
                });

            modelBuilder.Entity("ProductAndSparepart.Entity.Models.Sparepart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SparepartCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SparepartName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SparepartPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Spareparts");
                });

            modelBuilder.Entity("ProductAndSparepart.Entity.Models.ProductWithSparepart", b =>
                {
                    b.HasOne("ProductAndSparepart.Entity.Models.Product", "Product")
                        .WithMany("ProductWithSpareparts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductAndSparepart.Entity.Models.Sparepart", "Sparepart")
                        .WithMany("ProductWithSpareparts")
                        .HasForeignKey("SparepartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sparepart");
                });

            modelBuilder.Entity("ProductAndSparepart.Entity.Models.Product", b =>
                {
                    b.Navigation("ProductWithSpareparts");
                });

            modelBuilder.Entity("ProductAndSparepart.Entity.Models.Sparepart", b =>
                {
                    b.Navigation("ProductWithSpareparts");
                });
#pragma warning restore 612, 618
        }
    }
}
