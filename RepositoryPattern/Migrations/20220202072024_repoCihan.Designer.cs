﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryPattern.Data;

#nullable disable

namespace RepositoryPattern.Migrations
{
    [DbContext(typeof(RepoCihanDBContext))]
    [Migration("20220202072024_repoCihan")]
    partial class repoCihan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RepositoryPattern.Model.Personel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdıveİkinciAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personeller");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d0d14eff-83a2-451b-8ebf-03a4faaa0309"),
                            AdıveİkinciAdı = "Cihan",
                            Eposta = "Cihancik@gmail.com",
                            Soyadı = "Güler",
                            Telefon = "05335187892"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
