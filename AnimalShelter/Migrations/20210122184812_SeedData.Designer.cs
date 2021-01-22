﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20210122184812_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CatId");

                    b.ToTable("Cats");

                    b.HasData(
                        new
                        {
                            CatId = 1,
                            Age = 3,
                            Name = "Neptune"
                        },
                        new
                        {
                            CatId = 2,
                            Age = 12,
                            Name = "Rosie"
                        },
                        new
                        {
                            CatId = 3,
                            Age = 7,
                            Name = "Socks"
                        },
                        new
                        {
                            CatId = 4,
                            Age = 8,
                            Name = "Duncan"
                        },
                        new
                        {
                            CatId = 5,
                            Age = 4,
                            Name = "Midnight"
                        });
                });

            modelBuilder.Entity("AnimalShelter.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DogId");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            DogId = 1,
                            Age = 8,
                            Name = "Helo"
                        },
                        new
                        {
                            DogId = 2,
                            Age = 11,
                            Name = "Kiva"
                        },
                        new
                        {
                            DogId = 3,
                            Age = 12,
                            Name = "Jasper"
                        },
                        new
                        {
                            DogId = 4,
                            Age = 3,
                            Name = "Yates"
                        },
                        new
                        {
                            DogId = 5,
                            Age = 5,
                            Name = "Nico"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}