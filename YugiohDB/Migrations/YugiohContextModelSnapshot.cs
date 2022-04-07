﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YugiohDB;

#nullable disable

namespace YugiohDB.Migrations
{
    [DbContext(typeof(YugiohContext))]
    partial class YugiohContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("YugiohDB.Models.Card", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("Atk")
                        .HasColumnType("bigint");

                    b.Property<string>("Attribute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CardId")
                        .HasColumnType("bigint");

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

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("YugiohDB.Models.CardImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long?>("CardId")
                        .HasColumnType("bigint");

                    b.Property<string>("SetCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetRarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetRarityCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardImage");
                });

            modelBuilder.Entity("YugiohDB.Models.CardPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AmazonPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("CardId")
                        .HasColumnType("bigint");

                    b.Property<string>("CardmarketPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoolstuffincPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EbayPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcgplayerPrice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardPrices");
                });

            modelBuilder.Entity("YugiohDB.Models.CardSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long?>("CardId")
                        .HasColumnType("bigint");

                    b.Property<string>("SetCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetRarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SetRarityCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("CardSets");
                });

            modelBuilder.Entity("YugiohDB.Models.Card", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("Data")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("YugiohDB.Models.CardImage", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("CardImages")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("YugiohDB.Models.CardPrice", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("CardPrices")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("YugiohDB.Models.CardSet", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("CardSets")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("YugiohDB.Models.Card", b =>
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
