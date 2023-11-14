﻿// <auto-generated />
using System;
using CleanArchitectureDemo.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArchitectureDemo.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231114192841_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FacebookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StadiumId")
                        .HasColumnType("int");

                    b.Property<string>("TwitterUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoutubeUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StadiumId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("FlagUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThreeLetterIsoCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoLetterIsoCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("FacebookUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HeightInCm")
                        .HasColumnType("int");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerPositionId")
                        .HasColumnType("int");

                    b.Property<int?>("ShirtNo")
                        .HasColumnType("int");

                    b.Property<string>("TwitterUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("CountryId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BuiltYear")
                        .HasColumnType("int");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PitchLength")
                        .HasColumnType("int");

                    b.Property<int?>("PitchWidth")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Club", b =>
                {
                    b.HasOne("CleanArchitectureDemo.Domain.Entities.Stadium", "Stadium")
                        .WithMany("Clubs")
                        .HasForeignKey("StadiumId");

                    b.Navigation("Stadium");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Player", b =>
                {
                    b.HasOne("CleanArchitectureDemo.Domain.Entities.Club", "Club")
                        .WithMany("Players")
                        .HasForeignKey("ClubId");

                    b.HasOne("CleanArchitectureDemo.Domain.Entities.Country", "Country")
                        .WithMany("Players")
                        .HasForeignKey("CountryId");

                    b.Navigation("Club");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Stadium", b =>
                {
                    b.HasOne("CleanArchitectureDemo.Domain.Entities.Country", "Country")
                        .WithMany("Stadiums")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Club", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Country", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("Stadiums");
                });

            modelBuilder.Entity("CleanArchitectureDemo.Domain.Entities.Stadium", b =>
                {
                    b.Navigation("Clubs");
                });
#pragma warning restore 612, 618
        }
    }
}