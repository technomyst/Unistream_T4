﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Unistream_T4.Models.Transactions;

#nullable disable

namespace Unistream_T4.Migrations
{
    [DbContext(typeof(TransactionDbContext))]
    partial class TransactionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Unistream_T4.Models.Transactions.ClientBalance", b =>
                {
                    b.Property<Guid>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastCalculationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ClientId");

                    b.ToTable("ClientBalances");
                });

            modelBuilder.Entity("Unistream_T4.Models.Transactions.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("ClientBalanceAfterAddTransaction")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("ClientBalanceAfterRevertTransaction")
                        .HasColumnType("numeric");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<DateTime>("InsertDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsReverted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("RevertDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<TimeSpan>("TimeZoneOffset")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.ToTable("Transactions");

                    b.HasDiscriminator().HasValue("Transaction");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Unistream_T4.Models.Transactions.CreditTransaction", b =>
                {
                    b.HasBaseType("Unistream_T4.Models.Transactions.Transaction");

                    b.HasDiscriminator().HasValue("CreditTransaction");
                });

            modelBuilder.Entity("Unistream_T4.Models.Transactions.DebitTransaction", b =>
                {
                    b.HasBaseType("Unistream_T4.Models.Transactions.Transaction");

                    b.HasDiscriminator().HasValue("DebitTransaction");
                });
#pragma warning restore 612, 618
        }
    }
}
