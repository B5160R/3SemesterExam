﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnikOpstart.Services.KundeProjekter.Database.SqlContext;

#nullable disable

namespace SqlMigrations.Migrations
{
    [DbContext(typeof(KundeProjekterContext))]
    [Migration("20221212153139_UserIdAdded")]
    partial class UserIdAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.KundeEntity", b =>
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

                    b.Property<int>("TlfNr")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kunder");
                });

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.OpgaveEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Kommentar")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("KompetenceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Process_Kategori")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeEstimat")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Opgaver");
                });

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.ProjektEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("KundeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KundeId");

                    b.ToTable("Projekter");
                });

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.ProjektOpgaveEntity", b =>
                {
                    b.Property<int>("ProjektId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OpgaveId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjektId", "OpgaveId");

                    b.HasIndex("OpgaveId");

                    b.ToTable("ProjektOpgaver");
                });

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.ProjektEntity", b =>
                {
                    b.HasOne("UnikOpstart.Services.KundeProjekter.Domain.Models.KundeEntity", "Kunde")
                        .WithMany("Projekter")
                        .HasForeignKey("KundeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kunde");
                });

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.ProjektOpgaveEntity", b =>
                {
                    b.HasOne("UnikOpstart.Services.KundeProjekter.Domain.Models.OpgaveEntity", "Opgave")
                        .WithMany("Projekter")
                        .HasForeignKey("OpgaveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UnikOpstart.Services.KundeProjekter.Domain.Models.ProjektEntity", "Projekt")
                        .WithMany("Opgaver")
                        .HasForeignKey("ProjektId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opgave");

                    b.Navigation("Projekt");
                });

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.KundeEntity", b =>
                {
                    b.Navigation("Projekter");
                });

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.OpgaveEntity", b =>
                {
                    b.Navigation("Projekter");
                });

            modelBuilder.Entity("UnikOpstart.Services.KundeProjekter.Domain.Models.ProjektEntity", b =>
                {
                    b.Navigation("Opgaver");
                });
#pragma warning restore 612, 618
        }
    }
}
