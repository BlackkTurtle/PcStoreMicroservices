﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PCStore.DAL;

#nullable disable

namespace PCStore.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241025100611_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("PCStore.Data.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("PCStore.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PCStore.Data.Models.Characteristics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Characteristics");
                });

            modelBuilder.Entity("PCStore.Data.Models.Contragent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contragents");
                });

            modelBuilder.Entity("PCStore.Data.Models.ContragentDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContragentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContragentId");

                    b.ToTable("ContragentDescriptions");
                });

            modelBuilder.Entity("PCStore.Data.Models.Count", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Counts");
                });

            modelBuilder.Entity("PCStore.Data.Models.CountManipulation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ManipulationId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantity")
                        .HasMaxLength(100)
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CountId");

                    b.HasIndex("ManipulationId");

                    b.ToTable("CountManipulations");
                });

            modelBuilder.Entity("PCStore.Data.Models.CountOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("FromCountId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<int>("ToCountId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FromCountId");

                    b.HasIndex("ToCountId");

                    b.ToTable("CountOperations");
                });

            modelBuilder.Entity("PCStore.Data.Models.Inventarizations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Inventarizations");
                });

            modelBuilder.Entity("PCStore.Data.Models.Manipulation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Operation")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Manipulations");
                });

            modelBuilder.Entity("PCStore.Data.Models.NakladnaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NakladnaTypes");
                });

            modelBuilder.Entity("PCStore.Data.Models.Nakladni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContragentId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<double>("Discount")
                        .HasColumnType("REAL");

                    b.Property<int>("NakladnaTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrderId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContragentId");

                    b.HasIndex("NakladnaTypeId");

                    b.ToTable("Nakladnis");
                });

            modelBuilder.Entity("PCStore.Data.Models.NakladniProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Discount")
                        .HasColumnType("REAL");

                    b.Property<int>("NakladnaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductStorageId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("NakladnaId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductStorageId");

                    b.ToTable("NakladniProducts");
                });

            modelBuilder.Entity("PCStore.Data.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<int>("CountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("NakladnaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CountId");

                    b.HasIndex("NakladnaId");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PCStore.Data.Models.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("PCStore.Data.Models.Photos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhotoLink")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("PCStore.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductCharacteristics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacteristicId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Linkable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacteristicId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCharacteristics");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductInventarization", b =>
                {
                    b.Property<int>("InventarizationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductStorageId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("QuantityDiff")
                        .HasColumnType("REAL");

                    b.HasKey("InventarizationId", "ProductStorageId");

                    b.HasIndex("ProductStorageId");

                    b.ToTable("ProductInventarizations");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductRestorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FromStorageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductStorageId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<int>("RestorageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ToStorageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FromStorageId");

                    b.HasIndex("ProductStorageId");

                    b.HasIndex("RestorageId");

                    b.HasIndex("ToStorageId");

                    b.ToTable("ProductRestorages");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductStorages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacteristicId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Quantity")
                        .HasColumnType("REAL");

                    b.Property<int>("StorageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StorageId");

                    b.ToTable("ProductStorages");
                });

            modelBuilder.Entity("PCStore.Data.Models.Restorages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RestorageDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Restorages");
                });

            modelBuilder.Entity("PCStore.Data.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("PCStore.Data.Models.ContragentDescription", b =>
                {
                    b.HasOne("PCStore.Data.Models.Contragent", "Contragent")
                        .WithMany("ContragentDescriptions")
                        .HasForeignKey("ContragentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contragent");
                });

            modelBuilder.Entity("PCStore.Data.Models.CountManipulation", b =>
                {
                    b.HasOne("PCStore.Data.Models.Count", "Count")
                        .WithMany("CountManipulations")
                        .HasForeignKey("CountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Manipulation", "Manipulation")
                        .WithMany("CountManipulations")
                        .HasForeignKey("ManipulationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Count");

                    b.Navigation("Manipulation");
                });

            modelBuilder.Entity("PCStore.Data.Models.CountOperation", b =>
                {
                    b.HasOne("PCStore.Data.Models.Count", "FromCount")
                        .WithMany("FromCountOperations")
                        .HasForeignKey("FromCountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Count", "ToCount")
                        .WithMany("ToCountOperations")
                        .HasForeignKey("ToCountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FromCount");

                    b.Navigation("ToCount");
                });

            modelBuilder.Entity("PCStore.Data.Models.Nakladni", b =>
                {
                    b.HasOne("PCStore.Data.Models.Contragent", "Contragent")
                        .WithMany("Nakladnis")
                        .HasForeignKey("ContragentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.NakladnaType", "NakladnaType")
                        .WithMany("Nakladnis")
                        .HasForeignKey("NakladnaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contragent");

                    b.Navigation("NakladnaType");
                });

            modelBuilder.Entity("PCStore.Data.Models.NakladniProducts", b =>
                {
                    b.HasOne("PCStore.Data.Models.Nakladni", "Nakladni")
                        .WithMany("NakladniProducts")
                        .HasForeignKey("NakladnaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Product", "Product")
                        .WithMany("NakladniProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.ProductStorages", "ProductStorage")
                        .WithMany("NakladniProducts")
                        .HasForeignKey("ProductStorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nakladni");

                    b.Navigation("Product");

                    b.Navigation("ProductStorage");
                });

            modelBuilder.Entity("PCStore.Data.Models.Payment", b =>
                {
                    b.HasOne("PCStore.Data.Models.Count", "Count")
                        .WithMany("Payments")
                        .HasForeignKey("CountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Nakladni", "Nakladni")
                        .WithMany("Payments")
                        .HasForeignKey("NakladnaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.PaymentType", "PaymentType")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Count");

                    b.Navigation("Nakladni");

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("PCStore.Data.Models.Photos", b =>
                {
                    b.HasOne("PCStore.Data.Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PCStore.Data.Models.Product", b =>
                {
                    b.HasOne("PCStore.Data.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductCharacteristics", b =>
                {
                    b.HasOne("PCStore.Data.Models.Characteristics", "Characteristic")
                        .WithMany("ProductCharacteristics")
                        .HasForeignKey("CharacteristicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Product", "Product")
                        .WithMany("ProductCharacteristics")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Characteristic");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductInventarization", b =>
                {
                    b.HasOne("PCStore.Data.Models.Inventarizations", "Inventarizations")
                        .WithMany("ProductInventarizations")
                        .HasForeignKey("InventarizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.ProductStorages", "ProductsStorage")
                        .WithMany("ProductInventarizations")
                        .HasForeignKey("ProductStorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventarizations");

                    b.Navigation("ProductsStorage");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductRestorage", b =>
                {
                    b.HasOne("PCStore.Data.Models.Storage", "FromStorage")
                        .WithMany("FromProductRestorage")
                        .HasForeignKey("FromStorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.ProductStorages", "ProductStorage")
                        .WithMany("ProductRestorages")
                        .HasForeignKey("ProductStorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Restorages", "Restorages")
                        .WithMany("ProductRestorages")
                        .HasForeignKey("RestorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Storage", "ToStorage")
                        .WithMany("ToProductRestorage")
                        .HasForeignKey("ToStorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FromStorage");

                    b.Navigation("ProductStorage");

                    b.Navigation("Restorages");

                    b.Navigation("ToStorage");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductStorages", b =>
                {
                    b.HasOne("PCStore.Data.Models.Product", "Product")
                        .WithMany("ProductStorages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PCStore.Data.Models.Storage", "Storage")
                        .WithMany("ProductStorages")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Storage");
                });

            modelBuilder.Entity("PCStore.Data.Models.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PCStore.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PCStore.Data.Models.Characteristics", b =>
                {
                    b.Navigation("ProductCharacteristics");
                });

            modelBuilder.Entity("PCStore.Data.Models.Contragent", b =>
                {
                    b.Navigation("ContragentDescriptions");

                    b.Navigation("Nakladnis");
                });

            modelBuilder.Entity("PCStore.Data.Models.Count", b =>
                {
                    b.Navigation("CountManipulations");

                    b.Navigation("FromCountOperations");

                    b.Navigation("Payments");

                    b.Navigation("ToCountOperations");
                });

            modelBuilder.Entity("PCStore.Data.Models.Inventarizations", b =>
                {
                    b.Navigation("ProductInventarizations");
                });

            modelBuilder.Entity("PCStore.Data.Models.Manipulation", b =>
                {
                    b.Navigation("CountManipulations");
                });

            modelBuilder.Entity("PCStore.Data.Models.NakladnaType", b =>
                {
                    b.Navigation("Nakladnis");
                });

            modelBuilder.Entity("PCStore.Data.Models.Nakladni", b =>
                {
                    b.Navigation("NakladniProducts");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("PCStore.Data.Models.PaymentType", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("PCStore.Data.Models.Product", b =>
                {
                    b.Navigation("NakladniProducts");

                    b.Navigation("Photos");

                    b.Navigation("ProductCharacteristics");

                    b.Navigation("ProductStorages");
                });

            modelBuilder.Entity("PCStore.Data.Models.ProductStorages", b =>
                {
                    b.Navigation("NakladniProducts");

                    b.Navigation("ProductInventarizations");

                    b.Navigation("ProductRestorages");
                });

            modelBuilder.Entity("PCStore.Data.Models.Restorages", b =>
                {
                    b.Navigation("ProductRestorages");
                });

            modelBuilder.Entity("PCStore.Data.Models.Storage", b =>
                {
                    b.Navigation("FromProductRestorage");

                    b.Navigation("ProductStorages");

                    b.Navigation("ToProductRestorage");
                });
#pragma warning restore 612, 618
        }
    }
}
