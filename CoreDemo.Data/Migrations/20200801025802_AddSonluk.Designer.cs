﻿// <auto-generated />
using System;
using CoreDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreDemo.Data.Migrations
{
    [DbContext(typeof(CoreContext))]
    [Migration("20200801025802_AddSonluk")]
    partial class AddSonluk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreDemo.Domain.CRM_BARCODE_COMMODITY_TEST", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BARCODE")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("BEGINNING")
                        .HasColumnType("int");

                    b.Property<string>("BEIZ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BZSL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BZXS")
                        .HasColumnType("int");

                    b.Property<int>("CJR")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CJSJ")
                        .HasColumnType("datetime2");

                    b.Property<int>("CLONEBARCODE")
                        .HasColumnType("int");

                    b.Property<int>("CPZL")
                        .HasColumnType("int");

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ISACTIVE")
                        .HasColumnType("int");

                    b.Property<int>("ISEDIT")
                        .HasColumnType("int");

                    b.Property<string>("PIPECODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PP")
                        .HasColumnType("int");

                    b.Property<int>("QUANTITY")
                        .HasColumnType("int");

                    b.Property<int>("SERIES")
                        .HasColumnType("int");

                    b.Property<string>("SQR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VERSION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("XGR")
                        .HasColumnType("int");

                    b.Property<DateTime?>("XGSJ")
                        .HasColumnType("datetime2");

                    b.Property<int>("XH")
                        .HasColumnType("int");

                    b.Property<string>("YWY")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sonluks");
                });
#pragma warning restore 612, 618
        }
    }
}
