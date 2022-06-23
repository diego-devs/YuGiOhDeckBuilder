﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YugiohDB;

#nullable disable

namespace YugiohDB.Migrations
{
    [DbContext(typeof(YugiohContext))]
    [Migration("20220623013953_CreateYgoDB")]
    partial class CreateYgoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YugiohDB.Models.CardImage", b =>
                {
                    b.Property<int>("InternalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InternalId"), 1L, 1);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int?>("CardModelInternalID")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrlSmall")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InternalId");

                    b.HasIndex("CardModelInternalID");

                    b.ToTable("CardImage");
                });

            modelBuilder.Entity("YugiohDB.Models.CardModel", b =>
                {
                    b.Property<int>("InternalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InternalID"), 1L, 1);

                    b.Property<long>("Atk")
                        .HasColumnType("bigint");

                    b.Property<string>("Attribute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardID")
                        .HasColumnType("int");

                    b.Property<int?>("CardModelInternalID")
                        .HasColumnType("int");

                    b.Property<long>("Def")
                        .HasColumnType("bigint");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Level")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InternalID");

                    b.HasIndex("CardModelInternalID");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("YugiohDB.Models.PriceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Amazon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardMarket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CardModelInternalID")
                        .HasColumnType("int");

                    b.Property<string>("CoolStuffInc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ebay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcgPlayer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardModelInternalID");

                    b.ToTable("CardPrices");
                });

            modelBuilder.Entity("YugiohDB.Models.SetModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CardModelInternalID")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RarityCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardModelInternalID");

                    b.ToTable("CardSets");
                });

            modelBuilder.Entity("YugiohDB.Models.CardImage", b =>
                {
                    b.HasOne("YugiohDB.Models.CardModel", null)
                        .WithMany("CardImages")
                        .HasForeignKey("CardModelInternalID");
                });

            modelBuilder.Entity("YugiohDB.Models.CardModel", b =>
                {
                    b.HasOne("YugiohDB.Models.CardModel", null)
                        .WithMany("Data")
                        .HasForeignKey("CardModelInternalID");
                });

            modelBuilder.Entity("YugiohDB.Models.PriceModel", b =>
                {
                    b.HasOne("YugiohDB.Models.CardModel", null)
                        .WithMany("CardPrices")
                        .HasForeignKey("CardModelInternalID");
                });

            modelBuilder.Entity("YugiohDB.Models.SetModel", b =>
                {
                    b.HasOne("YugiohDB.Models.CardModel", null)
                        .WithMany("CardSets")
                        .HasForeignKey("CardModelInternalID");
                });

            modelBuilder.Entity("YugiohDB.Models.CardModel", b =>
                {
                    b.Navigation("CardImages");

                    b.Navigation("CardPrices");

                    b.Navigation("CardSets");

                    b.Navigation("Data");
                });
#pragma warning restore 612, 618
        }
    }
}