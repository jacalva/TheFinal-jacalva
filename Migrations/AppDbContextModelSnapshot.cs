﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheFinal_jacalva.Models;

#nullable disable

namespace TheFinal_jacalva.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("TheFinal_jacalva.Models.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CopiesSold")
                        .HasColumnType("REAL");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GameTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<double>("YearReleased")
                        .HasColumnType("REAL");

                    b.HasKey("GameID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("TheFinal_jacalva.Models.Studio", b =>
                {
                    b.Property<int>("StudioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudioName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("acquisitionyear")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudioID");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("TheFinal_jacalva.Models.StudioGame", b =>
                {
                    b.Property<int>("GameID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudioID")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameID", "StudioID");

                    b.HasIndex("StudioID");

                    b.ToTable("StudioGames");
                });

            modelBuilder.Entity("TheFinal_jacalva.Models.StudioGame", b =>
                {
                    b.HasOne("TheFinal_jacalva.Models.Game", "Game")
                        .WithMany("StudioGames")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheFinal_jacalva.Models.Studio", "Studio")
                        .WithMany("StudioGames")
                        .HasForeignKey("StudioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("TheFinal_jacalva.Models.Game", b =>
                {
                    b.Navigation("StudioGames");
                });

            modelBuilder.Entity("TheFinal_jacalva.Models.Studio", b =>
                {
                    b.Navigation("StudioGames");
                });
#pragma warning restore 612, 618
        }
    }
}
