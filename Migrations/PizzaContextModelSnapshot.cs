﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pizza_management.Models;

#nullable disable

namespace pizza_management.Migrations
{
    [DbContext(typeof(PizzaContext))]
    partial class PizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("pizza_management.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("pizza_management.Models.OrderPizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderPizza");
                });

            modelBuilder.Entity("pizza_management.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Pizza");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Margherita",
                            Price = 5f
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ortolana",
                            Price = 6f
                        },
                        new
                        {
                            Id = 3,
                            Name = "Diavola",
                            Price = 6.5f
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bufalina",
                            Price = 7f
                        });
                });

            modelBuilder.Entity("pizza_management.Models.OrderPizza", b =>
                {
                    b.HasOne("pizza_management.Models.Order", null)
                        .WithMany("OrderPizzas")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("pizza_management.Models.Order", b =>
                {
                    b.Navigation("OrderPizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
