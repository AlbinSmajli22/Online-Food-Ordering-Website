﻿// <auto-generated />
using LabCours.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabCours.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LabCours.Employe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emaili")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mbiemri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passwordi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employes");
                });
#pragma warning restore 612, 618
        }
    }
}
