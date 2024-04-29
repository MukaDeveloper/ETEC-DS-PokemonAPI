using Microsoft.EntityFrameworkCore;
using PokemonApi.Models;
using PokemonApi.Models.Enuns;

namespace PokemonApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pokemon> TB_POKEMONS { get; set; }
        public DbSet<Habilidade> TB_HABILIDADES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>().ToTable("TB_POKEMONS");
            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon() { Id = 1, Nome = "Bulbasaur", Altura = 0.7, Peso = 6.9, Genero = "M", Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso }, Nivel = 1, Vida = 45, Ataque = 49, Defesa = 49, Velocidade = 45 },
                new Pokemon() { Id = 2, Nome = "Ivysaur", Altura = 1.0, Peso = 13.0, Genero = "M", Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso }, Nivel = 1, Vida = 60, Ataque = 62, Defesa = 63, Velocidade = 60 },
                new Pokemon() { Id = 3, Nome = "Venusaur", Altura = 2.0, Peso = 100.0, Genero = "M", Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso }, Nivel = 1, Vida = 80, Ataque = 82, Defesa = 83, Velocidade = 80 },
                new Pokemon() { Id = 4, Nome = "Charmander", Altura = 0.6, Peso = 8.5, Genero = "M", Tipo = new List<TipoEnum> { TipoEnum.Fogo }, Nivel = 1, Vida = 39, Ataque = 52, Defesa = 43, Velocidade = 65 },
                new Pokemon() { Id = 5, Nome = "Charmeleon", Altura = 1.1, Peso = 19.0, Genero = "M", Tipo = new List<TipoEnum> { TipoEnum.Fogo }, Nivel = 1, Vida = 58, Ataque = 64, Defesa = 58, Velocidade = 80 },
                new Pokemon() { Id = 6, Nome = "Charizard", Altura = 1.7, Peso = 90.5, Genero = "M", Tipo = new List<TipoEnum> { TipoEnum.Fogo, TipoEnum.Voador }, Nivel = 1, Vida = 78, Ataque = 84, Defesa = 78, Velocidade = 100 }
            );
            modelBuilder.Entity<Habilidade>().ToTable("TB_HABILIDADES");
            modelBuilder.Entity<Habilidade>().HasData(
                new Habilidade() { Id = 1, Nome = "Tackle", Descricao = "Um ataque corporal comum.", Poder = 40, Precisao = 100, PP = 35 },
                new Habilidade() { Id = 2, Nome = "Growl", Descricao = "Reduz o Ataque do oponente.", Poder = 0, Precisao = 100, PP = 40 },
                new Habilidade() { Id = 3, Nome = "Vine Whip", Descricao = "Ataca com vinhas ou chicotes.", Poder = 45, Precisao = 100, PP = 25 },
                new Habilidade() { Id = 4, Nome = "Razor Leaf", Descricao = "Lâminas de folha são lançadas como navalhas.", Poder = 55, Precisao = 95, PP = 25 },
                new Habilidade() { Id = 5, Nome = "Flamethrower", Descricao = "Ataque com uma rajada de fogo intenso.", Poder = 90, Precisao = 100, PP = 15 },
                new Habilidade() { Id = 6, Nome = "Fire Spin", Descricao = "Envolve o oponente em chamas por 2 a 5 turnos.", Poder = 35, Precisao = 85, PP = 15 },
                new Habilidade() { Id = 7, Nome = "Slash", Descricao = "Um ataque cortante com alta chance de acerto crítico.", Poder = 70, Precisao = 100, PP = 20 }
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(100);
        }
    }
}