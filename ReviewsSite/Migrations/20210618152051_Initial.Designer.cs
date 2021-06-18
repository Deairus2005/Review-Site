﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20210618152051_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Personal Hygiene",
                            Image = "handSoap.png",
                            Name = "Hand Soap"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Personal Hygiene",
                            Image = "deodorant.png",
                            Name = "Deodorant"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Health Beauty",
                            Image = "shampoo.png",
                            Name = "Shampoo"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Health Beauty",
                            Image = "facialCleanser.png",
                            Name = "Facial Cleanser"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Personal Hygiene",
                            Image = "cottonSwabs.png",
                            Name = "Cotton Swabs"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hand Soap",
                            ProductId = 1,
                            Rating = 3,
                            ReviewContent = "Gentle on the hands and smells pretty!"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Deodorant",
                            ProductId = 2,
                            Rating = 3,
                            ReviewContent = "Left me stanky and moist!  Terrible."
                        },
                        new
                        {
                            Id = 3,
                            Name = "Shampoo",
                            ProductId = 3,
                            Rating = 3,
                            ReviewContent = "Gentle on the hands and smells pretty!"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Facial Cleanser",
                            ProductId = 4,
                            Rating = 3,
                            ReviewContent = "Left me stanky and moist!  Terrible."
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cotton Swabs",
                            ProductId = 5,
                            Rating = 3,
                            ReviewContent = "Gentle on the hands and smells pretty!"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ReviewsSite.Models.Product", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}