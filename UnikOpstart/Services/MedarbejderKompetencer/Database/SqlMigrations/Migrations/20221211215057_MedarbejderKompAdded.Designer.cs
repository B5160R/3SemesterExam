﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnikOpstart.Services.MedarbejderKompetencer.Database.SqlContext;

#nullable disable

namespace UnikOpstart.Services.Database.SqlMigrations.Migrations
{
    [DbContext(typeof(MedarbejderKompetencerContext))]
    [Migration("20221211215057_MedarbejderKompAdded")]
    partial class MedarbejderKompAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("UnikOpstart.Services.MedarbejderKompetencer.Domain.Models.KompetenceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Egenskab")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KompetenceEntities");
                });

            modelBuilder.Entity("UnikOpstart.Services.MedarbejderKompetencer.Domain.Models.MedarbejderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNr")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProcessRole")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MedarbejderEntities");
                });

            modelBuilder.Entity("UnikOpstart.Services.MedarbejderKompetencer.Domain.Models.MedarbejderKompEntity", b =>
                {
                    b.Property<int>("MedarbejderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KompetenceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("MedarbejderId", "KompetenceId");

                    b.HasIndex("KompetenceId");

                    b.ToTable("MedarbejderKompetencer");
                });

            modelBuilder.Entity("UnikOpstart.Services.MedarbejderKompetencer.Domain.Models.MedarbejderKompEntity", b =>
                {
                    b.HasOne("UnikOpstart.Services.MedarbejderKompetencer.Domain.Models.KompetenceEntity", "Kompetence")
                        .WithMany("Medarbejdere")
                        .HasForeignKey("KompetenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UnikOpstart.Services.MedarbejderKompetencer.Domain.Models.MedarbejderEntity", "Medarbejder")
                        .WithMany("Kompetencer")
                        .HasForeignKey("MedarbejderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kompetence");

                    b.Navigation("Medarbejder");
                });

            modelBuilder.Entity("UnikOpstart.Services.MedarbejderKompetencer.Domain.Models.KompetenceEntity", b =>
                {
                    b.Navigation("Medarbejdere");
                });

            modelBuilder.Entity("UnikOpstart.Services.MedarbejderKompetencer.Domain.Models.MedarbejderEntity", b =>
                {
                    b.Navigation("Kompetencer");
                });
#pragma warning restore 612, 618
        }
    }
}
