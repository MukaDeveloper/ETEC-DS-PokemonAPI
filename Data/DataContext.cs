using Microsoft.EntityFrameworkCore;
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer
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
        public DbSet<Habilidade> TB_TREINADORES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>().ToTable("TB_POKEMONS");
            modelBuilder.Entity<Habilidade>().ToTable("TB_HABILIDADES");
            modelBuilder.Entity<Treinador>().ToTable("TB_TREINADORES");
            modelBuilder.Entity<TreinadorPokemon>().ToTable("TB_TREINADORES_POKEMONS");
            modelBuilder.Entity<PokemonHabilidade>().ToTable("TB_POKEMONS_HABILIDADES");

            modelBuilder.Entity<Treinador>()
                .HasMany(p => p.Pokemons)
                .WithOne(t => t.Treinador)
                .HasForeignKey(e => e.TreinadorId)
                .IsRequired(false);

            modelBuilder.Entity<TreinadorPokemon>()
                .HasKey(tp => new { tp.PokemonId, tp.TreinadorId });

            // Relacionamento muitos-para-muitos entre Pokemon e Habilidade
            // modelBuilder.Entity<Pokemon>()
            //     .HasMany(p => p.Habilidades)
            //     .WithMany(h => h.Pokemons)
            //     .UsingEntity<Dictionary<string, object>>(
            //         "TB_POKEMONS_HABILIDADES",
            //         j => j.HasOne<Habilidade>().WithMany().HasForeignKey("HabilidadeId"),
            //         j => j.HasOne<Pokemon>().WithMany().HasForeignKey("PokemonId")
            //     );

            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon() { Id = 1, Nome = "Bulbasaur", Altura = 0.7, Peso = 6.9, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 2, Nome = "Ivysaur", Altura = 1.0, Peso = 13.0, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 3, Nome = "Venusaur", Altura = 2.0, Peso = 100.0, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 4, Nome = "Charmander", Altura = 0.6, Peso = 8.5, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 5, Nome = "Charmeleon", Altura = 1.1, Peso = 19.0, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 6, Nome = "Charizard", Altura = 1.7, Peso = 90.5, Tipo = new List<TipoEnum> { TipoEnum.Fogo, TipoEnum.Voador }  },
                new Pokemon() { Id = 74, Nome = "Geodude", Altura = 0.4, Peso = 20.0, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Terrestre } },
                new Pokemon() { Id = 95, Nome = "Onix", Altura = 8.8, Peso = 210.0, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Terrestre } }
            );
            modelBuilder.Entity<Habilidade>().HasData(
                new Habilidade() { Id = 1, Nome = "Tackle", Descricao = "Um ataque corporal comum.", Poder = 40, Precisao = 100, PP = 35 },
                new Habilidade() { Id = 2, Nome = "Growl", Descricao = "Reduz o Ataque do oponente.", Poder = 0, Precisao = 100, PP = 40 },
                new Habilidade() { Id = 3, Nome = "Vine Whip", Descricao = "Ataca com vinhas ou chicotes.", Poder = 45, Precisao = 100, PP = 25 },
                new Habilidade() { Id = 4, Nome = "Razor Leaf", Descricao = "Lâminas de folha são lançadas como navalhas.", Poder = 55, Precisao = 95, PP = 25 },
                new Habilidade() { Id = 5, Nome = "Flamethrower", Descricao = "Ataque com uma rajada de fogo intenso.", Poder = 90, Precisao = 100, PP = 15 },
                new Habilidade() { Id = 6, Nome = "Fire Spin", Descricao = "Envolve o oponente em chamas por 2 a 5 turnos.", Poder = 35, Precisao = 85, PP = 15 },
                new Habilidade() { Id = 7, Nome = "Slash", Descricao = "Um ataque cortante com alta chance de acerto crítico.", Poder = 70, Precisao = 100, PP = 20 }
            );
            modelBuilder.Entity<Treinador>().HasData(
                new Treinador() { Id = 1, Nome = "Brock", Insignias = new List<InsigniasEnum> { InsigniasEnum.Rocha }, Regiao = "Kanto", Pokemons = new List<Pokemon> { } },
                new Treinador() { Id = 2, Nome = "Misty", Insignias = new List<InsigniasEnum> { InsigniasEnum.Cascata }, Regiao = "Kanto", Pokemons = new List<Pokemon> { } },
                new Treinador() { Id = 3, Nome = "Sg. Surge", Insignias = new List<InsigniasEnum> { InsigniasEnum.Trovao }, Regiao = "Kanto", Pokemons = new List<Pokemon> { } },
                new Treinador() { Id = 4, Nome = "Erika", Insignias = new List<InsigniasEnum> { InsigniasEnum.ArcoIris }, Regiao = "Kanto", Pokemons = new List<Pokemon> { } },
                new Treinador() { Id = 5, Nome = "Koga", Insignias = new List<InsigniasEnum> { InsigniasEnum.Alma }, Regiao = "Kanto", Pokemons = new List<Pokemon> { } },
                new Treinador() { Id = 6, Nome = "Sabrina", Insignias = new List<InsigniasEnum> { InsigniasEnum.Pantano }, Regiao = "Kanto", Pokemons = new List<Pokemon> { } },
                new Treinador() { Id = 7, Nome = "Blaine", Insignias = new List<InsigniasEnum> { InsigniasEnum.Vulcao }, Regiao = "Kanto", Pokemons = new List<Pokemon> { } },
                new Treinador() { Id = 8, Nome = "Giovanni", Insignias = new List<InsigniasEnum> { InsigniasEnum.Terra }, Regiao = "Kanto", Pokemons = new List<Pokemon> { } }
            );
            modelBuilder.Entity<TreinadorPokemon>().HasData(
                new TreinadorPokemon() { TreinadorId = 1, PokemonId = 74, Nivel = 12 }
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(100);
        }
    }
}