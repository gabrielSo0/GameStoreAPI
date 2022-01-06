﻿// <auto-generated />
using System;
using GameStore.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameStore.WebAPI.Migrations
{
    [DbContext(typeof(GameStoreContext))]
    [Migration("20220106231422_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("GameOrder", b =>
                {
                    b.Property<int>("GamesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrdersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GamesId", "OrdersId");

                    b.HasIndex("OrdersId");

                    b.ToTable("GameOrder");
                });

            modelBuilder.Entity("GameStore.WebAPI.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1998, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gabriel",
                            PhoneNumber = "123456",
                            Surname = "Silva"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1991, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John",
                            PhoneNumber = "456789",
                            Surname = "Wick"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1980, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Darth",
                            PhoneNumber = "789456",
                            Surname = "Vader"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jessica",
                            PhoneNumber = "515846",
                            Surname = "Laura"
                        });
                });

            modelBuilder.Entity("GameStore.WebAPI.Model.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberOfPlayers")
                        .HasColumnType("TEXT");

                    b.Property<string>("Plataform")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Action",
                            Name = "Ghost Of Tsushima",
                            Price = 64.109999999999999,
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Action",
                            Name = "Marvels Guardians of the Galaxy",
                            Price = 29.989999999999998,
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Genre = "RPG",
                            Name = "The Witcher 3",
                            Price = 33.990000000000002,
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Action",
                            Name = "God of War",
                            Price = 19.989999999999998,
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GameStore.WebAPI.Model.GameOrder", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("GamesOrders");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            GameId = 1,
                            OrderId = 2
                        },
                        new
                        {
                            GameId = 1,
                            OrderId = 3
                        },
                        new
                        {
                            GameId = 2,
                            OrderId = 1
                        },
                        new
                        {
                            GameId = 2,
                            OrderId = 2
                        },
                        new
                        {
                            GameId = 3,
                            OrderId = 4
                        },
                        new
                        {
                            GameId = 3,
                            OrderId = 3
                        },
                        new
                        {
                            GameId = 4,
                            OrderId = 1
                        },
                        new
                        {
                            GameId = 4,
                            OrderId = 3
                        },
                        new
                        {
                            GameId = 4,
                            OrderId = 4
                        });
                });

            modelBuilder.Entity("GameStore.WebAPI.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            DateOrder = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            DateOrder = new DateTime(2020, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            DateOrder = new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 4,
                            DateOrder = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GameOrder", b =>
                {
                    b.HasOne("GameStore.WebAPI.Model.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameStore.WebAPI.Model.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameStore.WebAPI.Model.GameOrder", b =>
                {
                    b.HasOne("GameStore.WebAPI.Model.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameStore.WebAPI.Model.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("GameStore.WebAPI.Model.Order", b =>
                {
                    b.HasOne("GameStore.WebAPI.Model.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GameStore.WebAPI.Model.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
