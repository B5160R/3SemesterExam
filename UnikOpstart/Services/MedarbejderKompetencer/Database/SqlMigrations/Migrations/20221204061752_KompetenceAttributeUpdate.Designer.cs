﻿// <auto-generated />
using UnikOpstart.Services.MedarbejderKompetencer.Database.SqlContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace UnikOpstart.Services.Database.SqlMigrations.Migrations
{
    [DbContext(typeof(MedarbejderKompetencerContext))]
    [Migration("20221204061752_KompetenceAttributeUpdate")]
    partial class KompetenceAttributeUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Kompetence.Domain.Model.KompetenceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Egenskab")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MedarbejderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("KompetenceEntities");
                });

            modelBuilder.Entity("Medarbejder.Domain.Model.MedarbejderEntity", b =>
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

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MedarbejderEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
