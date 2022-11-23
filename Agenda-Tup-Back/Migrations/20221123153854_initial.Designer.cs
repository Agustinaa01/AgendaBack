﻿// <auto-generated />
using Agenda_Tup_Back.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendaTupBack.Migrations
{
    [DbContext(typeof(AgendaApiContext))]
    [Migration("20221123153854_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Agenda_Tup_Back.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("CelularNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("state")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            CelularNumber = "+54341234975",
                            Email = "Amigo@gmail.com",
                            LastName = "Cruz",
                            Name = "Esmeralda",
                            UserId = 2,
                            state = 0
                        },
                        new
                        {
                            Id = 3,
                            CelularNumber = "+54114567789",
                            LastName = "Romero",
                            Name = "Daniela",
                            UserId = 1,
                            state = 0
                        },
                        new
                        {
                            Id = 2,
                            CelularNumber = "+54341345367",
                            Name = "Maria",
                            UserId = 1,
                            state = 0
                        },
                        new
                        {
                            Id = 1,
                            CelularNumber = "+543436789513",
                            Email = "Hijo@gmail.com",
                            LastName = "Castillo",
                            Name = "Juan",
                            UserId = 2,
                            state = 0
                        });
                });

            modelBuilder.Entity("Agenda_Tup_Back.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rol")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Email = "danaMolina@gmail.com",
                            LastName = "Molina",
                            Password = "456def",
                            Rol = 0,
                            UserName = "Dana"
                        },
                        new
                        {
                            Id = 1,
                            Email = "ericaGomez@gmail.com",
                            LastName = "Lechuga",
                            Password = "123abc",
                            Rol = 0,
                            UserName = "Erica"
                        });
                });

            modelBuilder.Entity("Agenda_Tup_Back.Entities.Contact", b =>
                {
                    b.HasOne("Agenda_Tup_Back.Entities.User", "User")
                        .WithMany("Contact")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Agenda_Tup_Back.Entities.User", b =>
                {
                    b.Navigation("Contact");
                });
#pragma warning restore 612, 618
        }
    }
}
