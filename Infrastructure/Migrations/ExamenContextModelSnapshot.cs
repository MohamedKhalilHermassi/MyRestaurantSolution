﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ExamenContext))]
    partial class ExamenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationCore.Domain.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PointFidelite")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Employe", b =>
                {
                    b.Property<string>("Cin")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantKey")
                        .HasColumnType("int");

                    b.Property<double>("Salaire")
                        .HasColumnType("float");

                    b.Property<int>("TypeEmploye")
                        .HasColumnType("int");

                    b.HasKey("Cin");

                    b.HasIndex("RestaurantKey");

                    b.ToTable("Employes");

                    b.HasDiscriminator<int>("TypeEmploye").HasValue(0);

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ApplicationCore.Domain.Reservation", b =>
                {
                    b.Property<int>("RestaurantFk")
                        .HasColumnType("int");

                    b.Property<int>("ClientFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("StatutReservation")
                        .HasColumnType("bit");

                    b.Property<int>("Table")
                        .HasColumnType("int");

                    b.HasKey("RestaurantFk", "ClientFk", "Date");

                    b.HasIndex("ClientFk");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Chef", b =>
                {
                    b.HasBaseType("ApplicationCore.Domain.Employe");

                    b.Property<string>("Specialite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("ApplicationCore.Domain.Serveur", b =>
                {
                    b.HasBaseType("ApplicationCore.Domain.Employe");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("ApplicationCore.Domain.Employe", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Restaurant", "Restaurant")
                        .WithMany("Employes")
                        .HasForeignKey("RestaurantKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Reservation", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Client", "Client")
                        .WithMany("Reservations")
                        .HasForeignKey("ClientFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Domain.Restaurant", "Restaurant")
                        .WithMany("Reservations")
                        .HasForeignKey("RestaurantFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Client", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Restaurant", b =>
                {
                    b.Navigation("Employes");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
