﻿// <auto-generated />
using System;
using HongJun.Service.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HongJun.Service.Migrations
{
    [DbContext(typeof(MasterDbContext))]
    partial class MasterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HongJun.Service.Domina.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Creator")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GiteeId")
                        .HasColumnType("text");

                    b.Property<string>("GithubId")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Modifier")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<long>("ResidualCredit")
                        .HasColumnType("bigint");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("GiteeId");

                    b.HasIndex("GithubId");

                    b.HasIndex("Phone");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "4a4c4f60d5ae4f229b233368b96630be",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "239573049@qq.com",
                            IsDelete = false,
                            IsDisabled = false,
                            Password = "8679116b7794dd488b1a8b1214b1df66",
                            PasswordHas = "5472f96d643444379a2108fc700eab43",
                            ResidualCredit = 0L,
                            Role = "admin",
                            UserName = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
