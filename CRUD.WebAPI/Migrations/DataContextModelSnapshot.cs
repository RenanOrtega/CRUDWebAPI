﻿// <auto-generated />
using CRUD.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("CRUD.WebAPI.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rg")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Cpf = "503.570.378-98",
                            DataNascimento = "29/12/2001",
                            Nome = "Thais",
                            Rg = "50.661.998-9"
                        },
                        new
                        {
                            Id = 1,
                            Cpf = "503.570.378-98",
                            DataNascimento = "29/12/2001",
                            Nome = "Renan",
                            Rg = "50.661.998-9"
                        },
                        new
                        {
                            Id = 3,
                            Cpf = "503.570.378-98",
                            DataNascimento = "29/12/2001",
                            Nome = "Silvao",
                            Rg = "50.661.998-9"
                        },
                        new
                        {
                            Id = 4,
                            Cpf = "503.570.378-98",
                            DataNascimento = "29/12/2001",
                            Nome = "Victor",
                            Rg = "50.661.998-9"
                        });
                });

            modelBuilder.Entity("CRUD.WebAPI.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Enderecos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 2,
                            Nome = "Rua Chico Bento",
                            Tipo = 2
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 1,
                            Nome = "Rua Maisa",
                            Tipo = 1
                        },
                        new
                        {
                            Id = 3,
                            ClienteId = 3,
                            Nome = "Rua Luisinho",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 4,
                            ClienteId = 1,
                            Nome = "Rua Lindoinha",
                            Tipo = 2
                        },
                        new
                        {
                            Id = 5,
                            ClienteId = 2,
                            Nome = "Rua Seila",
                            Tipo = 1
                        },
                        new
                        {
                            Id = 6,
                            ClienteId = 4,
                            Nome = "Rua Chico Bento",
                            Tipo = 2
                        });
                });

            modelBuilder.Entity("CRUD.WebAPI.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Numero")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Telefones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 2,
                            Numero = "(11) 1273468",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 2,
                            Numero = "(11) 1111111",
                            Tipo = 2
                        },
                        new
                        {
                            Id = 3,
                            ClienteId = 3,
                            Numero = "(11) 2222222",
                            Tipo = 1
                        },
                        new
                        {
                            Id = 4,
                            ClienteId = 4,
                            Numero = "(11) 4444444",
                            Tipo = 0
                        },
                        new
                        {
                            Id = 5,
                            ClienteId = 1,
                            Numero = "(11) 5555555",
                            Tipo = 1
                        },
                        new
                        {
                            Id = 6,
                            ClienteId = 1,
                            Numero = "(11) 9999999",
                            Tipo = 2
                        });
                });

            modelBuilder.Entity("CRUD.WebAPI.Models.Endereco", b =>
                {
                    b.HasOne("CRUD.WebAPI.Models.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CRUD.WebAPI.Models.Telefone", b =>
                {
                    b.HasOne("CRUD.WebAPI.Models.Cliente", "Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}