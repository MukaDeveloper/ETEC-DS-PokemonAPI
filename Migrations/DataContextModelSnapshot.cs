﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonApi.Data;

#nullable disable

namespace ETEC_DS_POKEMON.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PokemonApi.Models.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("PP")
                        .HasColumnType("int");

                    b.Property<int>("Poder")
                        .HasColumnType("int");

                    b.Property<int?>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("Precisao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PokemonId");

                    b.ToTable("TB_HABILIDADES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Um ataque corporal comum.",
                            Nome = "Tackle",
                            PP = 35,
                            Poder = 40,
                            Precisao = 100
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Reduz o Ataque do oponente.",
                            Nome = "Growl",
                            PP = 40,
                            Poder = 0,
                            Precisao = 100
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Ataca com vinhas ou chicotes.",
                            Nome = "Vine Whip",
                            PP = 25,
                            Poder = 45,
                            Precisao = 100
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Lâminas de folha são lançadas como navalhas.",
                            Nome = "Razor Leaf",
                            PP = 25,
                            Poder = 55,
                            Precisao = 95
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Ataque com uma rajada de fogo intenso.",
                            Nome = "Flamethrower",
                            PP = 15,
                            Poder = 90,
                            Precisao = 100
                        },
                        new
                        {
                            Id = 6,
                            Descricao = "Envolve o oponente em chamas por 2 a 5 turnos.",
                            Nome = "Fire Spin",
                            PP = 15,
                            Poder = 35,
                            Precisao = 85
                        },
                        new
                        {
                            Id = 7,
                            Descricao = "Um ataque cortante com alta chance de acerto crítico.",
                            Nome = "Slash",
                            PP = 20,
                            Poder = 70,
                            Precisao = 100
                        });
                });

            modelBuilder.Entity("PokemonApi.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<int>("Ataque")
                        .HasColumnType("int");

                    b.Property<int>("Defesa")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<int>("Nivel")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TreinadorId")
                        .HasColumnType("int");

                    b.Property<int>("Velocidade")
                        .HasColumnType("int");

                    b.Property<int>("Vida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TreinadorId");

                    b.ToTable("TB_POKEMONS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Altura = 0.69999999999999996,
                            Ataque = 49,
                            Defesa = 49,
                            Genero = "M",
                            Nivel = 1,
                            Nome = "Bulbasaur",
                            Peso = 6.9000000000000004,
                            Tipo = "[9,13]",
                            Velocidade = 45,
                            Vida = 45
                        },
                        new
                        {
                            Id = 2,
                            Altura = 1.0,
                            Ataque = 62,
                            Defesa = 63,
                            Genero = "M",
                            Nivel = 1,
                            Nome = "Ivysaur",
                            Peso = 13.0,
                            Tipo = "[9,13]",
                            Velocidade = 60,
                            Vida = 60
                        },
                        new
                        {
                            Id = 3,
                            Altura = 2.0,
                            Ataque = 82,
                            Defesa = 83,
                            Genero = "M",
                            Nivel = 1,
                            Nome = "Venusaur",
                            Peso = 100.0,
                            Tipo = "[9,13]",
                            Velocidade = 80,
                            Vida = 80
                        },
                        new
                        {
                            Id = 4,
                            Altura = 0.59999999999999998,
                            Ataque = 52,
                            Defesa = 43,
                            Genero = "M",
                            Nivel = 1,
                            Nome = "Charmander",
                            Peso = 8.5,
                            Tipo = "[6]",
                            Velocidade = 65,
                            Vida = 39
                        },
                        new
                        {
                            Id = 5,
                            Altura = 1.1000000000000001,
                            Ataque = 64,
                            Defesa = 58,
                            Genero = "M",
                            Nivel = 1,
                            Nome = "Charmeleon",
                            Peso = 19.0,
                            Tipo = "[6]",
                            Velocidade = 80,
                            Vida = 58
                        },
                        new
                        {
                            Id = 6,
                            Altura = 1.7,
                            Ataque = 84,
                            Defesa = 78,
                            Genero = "M",
                            Nivel = 1,
                            Nome = "Charizard",
                            Peso = 90.5,
                            Tipo = "[6,7]",
                            Velocidade = 100,
                            Vida = 78
                        });
                });

            modelBuilder.Entity("PokemonApi.Models.Treinador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Insignias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("Regiao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("TB_TREINADORES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Insignias = "[0]",
                            Nome = "Brock",
                            Regiao = "Kanto"
                        },
                        new
                        {
                            Id = 2,
                            Insignias = "[1]",
                            Nome = "Misty",
                            Regiao = "Kanto"
                        },
                        new
                        {
                            Id = 3,
                            Insignias = "[2]",
                            Nome = "Sg. Surge",
                            Regiao = "Kanto"
                        },
                        new
                        {
                            Id = 4,
                            Insignias = "[3]",
                            Nome = "Erika",
                            Regiao = "Kanto"
                        },
                        new
                        {
                            Id = 5,
                            Insignias = "[4]",
                            Nome = "Koga",
                            Regiao = "Kanto"
                        },
                        new
                        {
                            Id = 6,
                            Insignias = "[5]",
                            Nome = "Sabrina",
                            Regiao = "Kanto"
                        },
                        new
                        {
                            Id = 7,
                            Insignias = "[6]",
                            Nome = "Blaine",
                            Regiao = "Kanto"
                        },
                        new
                        {
                            Id = 8,
                            Insignias = "[7]",
                            Nome = "Giovanni",
                            Regiao = "Kanto"
                        });
                });

            modelBuilder.Entity("PokemonApi.Models.Habilidade", b =>
                {
                    b.HasOne("PokemonApi.Models.Pokemon", null)
                        .WithMany("Habilidades")
                        .HasForeignKey("PokemonId");
                });

            modelBuilder.Entity("PokemonApi.Models.Pokemon", b =>
                {
                    b.HasOne("PokemonApi.Models.Treinador", null)
                        .WithMany("Pokemons")
                        .HasForeignKey("TreinadorId");
                });

            modelBuilder.Entity("PokemonApi.Models.Pokemon", b =>
                {
                    b.Navigation("Habilidades");
                });

            modelBuilder.Entity("PokemonApi.Models.Treinador", b =>
                {
                    b.Navigation("Pokemons");
                });
#pragma warning restore 612, 618
        }
    }
}
