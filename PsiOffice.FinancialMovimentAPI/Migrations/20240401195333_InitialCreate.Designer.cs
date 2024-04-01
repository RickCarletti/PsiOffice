﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PsiOffice.FinancialMovimentAPI.Model.Context;

#nullable disable

namespace PsiOffice.FinancialMovimentAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20240401195333_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PsiOffice.FinancialMovimentAPI.Model.FinancialMoviment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Additions")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("additions");

                    b.Property<decimal>("BaseValue")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("base_value");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<decimal>("Discounts")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("discounts");

                    b.Property<DateTime>("DtCreation")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dt_creation");

                    b.Property<DateTime>("DtPayment")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("dt_payment");

                    b.Property<decimal>("FullValue")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("full_value");

                    b.Property<bool>("IsExpense")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_expense");

                    b.HasKey("Id");

                    b.ToTable("financial_moviment");
                });
#pragma warning restore 612, 618
        }
    }
}