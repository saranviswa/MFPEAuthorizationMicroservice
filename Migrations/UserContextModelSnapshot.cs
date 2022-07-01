﻿// <auto-generated />
using System;
using AuthorizationAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthorizationAPI.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorizationAPI.Models.UserCredentials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BanTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Counter")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Mumbai",
                            BanTime = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Counter = 0,
                            Password = "ADwq/exoLHtjFRAKDR/3EnOOj+wsqkpqne0lo0Tvl1PFtZ7WDOzPYQd6gUTZNCf1Zw==",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Delhi",
                            BanTime = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Counter = 0,
                            Password = "AGuu2XTe6tR4OGwcuabUf7cZSorjWOoa7iFcHULlpYGGt1kgctcBeIAiLebgq6VOCA==",
                            Username = "user"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
