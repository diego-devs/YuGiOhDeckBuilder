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
    [DbContext(typeof(YGODeckBuilder.Data.YgoContext))]
    [Migration("20230108012536_CreateYgoDB")]
    partial class CreateYgoDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YugiohDB.Models.BanlistInfo", b =>
                {
                    b.Property<int>("BanlistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "banlistinfo_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BanlistId"));

                    b.Property<string>("Ban_GOAT")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ban_goat");

                    b.Property<string>("Ban_OCG")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ban_ocg");

                    b.Property<string>("Ban_TCG")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ban_tcg");

                    b.Property<int>("CardId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "card_id");

                    b.HasKey("BanlistId");

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.ToTable("BanlistInfo");

                    b.HasAnnotation("Relational:JsonPropertyName", "banlist_info");
                });

            modelBuilder.Entity("YugiohDB.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "card_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<string>("Archetype")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "archetype");

                    b.Property<int?>("Atk")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "atk");

                    b.Property<string>("Attribute")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "attribute");

                    b.Property<int?>("CardId1")
                        .HasColumnType("int");

                    b.Property<int?>("DeckId")
                        .HasColumnType("int");

                    b.Property<int?>("DeckId1")
                        .HasColumnType("int");

                    b.Property<int?>("DeckId2")
                        .HasColumnType("int");

                    b.Property<int?>("Def")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "def");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "desc");

                    b.Property<int>("KonamiCardId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<int?>("Level")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "level");

                    b.Property<int?>("LinkVal")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "linkval");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "race");

                    b.Property<int?>("Scale")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "scale");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "type");

                    b.HasKey("CardId");

                    b.HasIndex("CardId1");

                    b.HasIndex("DeckId");

                    b.HasIndex("DeckId1");

                    b.HasIndex("DeckId2");

                    b.ToTable("Cards");

                    b.HasAnnotation("Relational:JsonPropertyName", "data");
                });

            modelBuilder.Entity("YugiohDB.Models.CardImages", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "image_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("CardImageId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("ImageLocalUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ImageLocalUrl");

                    b.Property<string>("ImageLocalUrlCropped")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ImageLocalUrlCroppped");

                    b.Property<string>("ImageLocalUrlSmall")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ImageLocalUrlSmall");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "image_url");

                    b.Property<string>("ImageUrlCropped")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "image_url_croppped");

                    b.Property<string>("ImageUrlSmall")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "image_url_small");

                    b.HasKey("ImageId");

                    b.HasIndex("CardId");

                    b.ToTable("Images");

                    b.HasAnnotation("Relational:JsonPropertyName", "card_images");
                });

            modelBuilder.Entity("YugiohDB.Models.CardPrices", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "price_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriceId"));

                    b.Property<string>("Amazon")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "amazon_price");

                    b.Property<int>("CardId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "card_id");

                    b.Property<string>("CardMarket")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "cardmarket_price");

                    b.Property<string>("CoolStuffInc")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "coolstuffinc_price");

                    b.Property<string>("Ebay")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ebay_price");

                    b.Property<string>("TcgPlayer")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "tcgplayer_price");

                    b.HasKey("PriceId");

                    b.HasIndex("CardId");

                    b.ToTable("CardPrices");

                    b.HasAnnotation("Relational:JsonPropertyName", "card_prices");
                });

            modelBuilder.Entity("YugiohDB.Models.CardSet", b =>
                {
                    b.Property<int>("CardSetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "cardset_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardSetId"));

                    b.Property<int>("CardId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "card_id");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_code");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_name");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_price");

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_rarity");

                    b.Property<string>("RarityCode")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_rarity_code");

                    b.HasKey("CardSetId");

                    b.HasIndex("CardId");

                    b.ToTable("CardSets");

                    b.HasAnnotation("Relational:JsonPropertyName", "card_sets");
                });

            modelBuilder.Entity("YugiohDB.Models.Deck", b =>
                {
                    b.Property<int>("DeckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "deck_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeckId"));

                    b.Property<string>("DeckName")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "deck_name");

                    b.HasKey("DeckId");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("YugiohDB.Models.MiscInfo", b =>
                {
                    b.Property<int>("MiscId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "miscinfo_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MiscId"));

                    b.Property<string>("BetaName")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "beta_name");

                    b.Property<int>("CardId")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "card_id");

                    b.Property<int>("DownVotes")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "downvotes");

                    b.Property<int>("HasEffect")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "has_effect");

                    b.Property<string>("OcgDate")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "ocg_date");

                    b.Property<string>("TcgDate")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "tcg_date");

                    b.Property<string>("TreatedAs")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "treated_as");

                    b.Property<int>("UpVotes")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "upvotes");

                    b.Property<long>("Views")
                        .HasColumnType("bigint")
                        .HasAnnotation("Relational:JsonPropertyName", "views");

                    b.Property<int>("ViewsWeek")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "viewsweek");

                    b.HasKey("MiscId");

                    b.HasIndex("CardId");

                    b.ToTable("CardMiscInformation");

                    b.HasAnnotation("Relational:JsonPropertyName", "misc_info");
                });

            modelBuilder.Entity("YugiohDB.Models.SetInfo", b =>
                {
                    b.Property<int>("SetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "setinfo_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SetId"));

                    b.Property<int>("NumOfCards")
                        .HasColumnType("int")
                        .HasAnnotation("Relational:JsonPropertyName", "num_of_cards");

                    b.Property<string>("SetCode")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_code");

                    b.Property<string>("SetName")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "set_name");

                    b.Property<string>("TcgDate")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "tcg_date");

                    b.HasKey("SetId");

                    b.ToTable("SetInformation");
                });

            modelBuilder.Entity("YugiohDB.Models.BanlistInfo", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithOne("BanlistInfo")
                        .HasForeignKey("YugiohDB.Models.BanlistInfo", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YugiohDB.Models.Card", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("Data")
                        .HasForeignKey("CardId1");

                    b.HasOne("YugiohDB.Models.Deck", null)
                        .WithMany("ExtraDeck")
                        .HasForeignKey("DeckId");

                    b.HasOne("YugiohDB.Models.Deck", null)
                        .WithMany("MainDeck")
                        .HasForeignKey("DeckId1");

                    b.HasOne("YugiohDB.Models.Deck", null)
                        .WithMany("SideDeck")
                        .HasForeignKey("DeckId2");
                });

            modelBuilder.Entity("YugiohDB.Models.CardImages", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("CardImages")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("YugiohDB.Models.CardPrices", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("CardPrices")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YugiohDB.Models.CardSet", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("CardSets")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YugiohDB.Models.MiscInfo", b =>
                {
                    b.HasOne("YugiohDB.Models.Card", null)
                        .WithMany("MiscInfo")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YugiohDB.Models.Card", b =>
                {
                    b.Navigation("BanlistInfo");

                    b.Navigation("CardImages");

                    b.Navigation("CardPrices");

                    b.Navigation("CardSets");

                    b.Navigation("Data");

                    b.Navigation("MiscInfo");
                });

            modelBuilder.Entity("YugiohDB.Models.Deck", b =>
                {
                    b.Navigation("ExtraDeck");

                    b.Navigation("MainDeck");

                    b.Navigation("SideDeck");
                });
#pragma warning restore 612, 618
        }
    }
}
