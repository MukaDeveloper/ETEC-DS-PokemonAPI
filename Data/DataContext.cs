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

            modelBuilder.Entity<TreinadorPokemon>()
                .HasKey(tp => new { tp.TreinadorId, tp.PokemonId });

            modelBuilder.Entity<TreinadorPokemon>()
                .HasOne(tp => tp.Treinador)
                .WithMany(t => t.TreinadorPokemons)
                .HasForeignKey(tp => tp.TreinadorId);

            modelBuilder.Entity<TreinadorPokemon>()
                .HasOne(tp => tp.Pokemon)
                .WithMany(p => p.TreinadorPokemons)
                .HasForeignKey(tp => tp.PokemonId);

            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon() { Id = 1, Nome = "Bulbasaur", Altura = 0.7, Peso = 6.9, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 2, Nome = "Ivysaur", Altura = 1.0, Peso = 13.0, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 3, Nome = "Venusaur", Altura = 2.0, Peso = 100.0, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 4, Nome = "Charmander", Altura = 0.6, Peso = 8.5, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 5, Nome = "Charmeleon", Altura = 1.1, Peso = 19.0, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 6, Nome = "Charizard", Altura = 1.7, Peso = 90.5, Tipo = new List<TipoEnum> { TipoEnum.Fogo, TipoEnum.Voador } },
                new Pokemon() { Id = 7, Nome = "Squirtle", Altura = 0.5, Peso = 9.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 8, Nome = "Wartortle", Altura = 1.0, Peso = 22.5, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 9, Nome = "Blastoise", Altura = 1.6, Peso = 85.5, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 10, Nome = "Caterpie", Altura = 0.3, Peso = 2.9, Tipo = new List<TipoEnum> { TipoEnum.Inseto } },
                new Pokemon() { Id = 11, Nome = "Metapod", Altura = 0.7, Peso = 9.9, Tipo = new List<TipoEnum> { TipoEnum.Inseto } },
                new Pokemon() { Id = 12, Nome = "Butterfree", Altura = 1.1, Peso = 32.0, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Voador } },
                new Pokemon() { Id = 13, Nome = "Weedle", Altura = 0.3, Peso = 3.2, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Venenoso } },
                new Pokemon() { Id = 14, Nome = "Kakuna", Altura = 0.6, Peso = 10.0, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Venenoso } },
                new Pokemon() { Id = 15, Nome = "Beedrill", Altura = 1.0, Peso = 29.5, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Venenoso } },
                new Pokemon() { Id = 16, Nome = "Pidgey", Altura = 0.3, Peso = 1.8, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Voador } },
                new Pokemon() { Id = 17, Nome = "Pidgeotto", Altura = 1.1, Peso = 30.0, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Voador } },
                new Pokemon() { Id = 18, Nome = "Pidgeot", Altura = 1.5, Peso = 39.5, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Voador } },
                new Pokemon() { Id = 19, Nome = "Rattata", Altura = 0.3, Peso = 3.5, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 20, Nome = "Raticate", Altura = 0.7, Peso = 18.5, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 21, Nome = "Spearow", Altura = 0.3, Peso = 2.0, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Voador } },
                new Pokemon() { Id = 22, Nome = "Fearow", Altura = 1.2, Peso = 38.0, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Voador } },
                new Pokemon() { Id = 23, Nome = "Ekans", Altura = 2.0, Peso = 6.9, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 24, Nome = "Arbok", Altura = 3.5, Peso = 65.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 25, Nome = "Pikachu", Altura = 0.4, Peso = 6.0, Tipo = new List<TipoEnum> { TipoEnum.Eletrico } },
                new Pokemon() { Id = 26, Nome = "Raichu", Altura = 0.8, Peso = 30.0, Tipo = new List<TipoEnum> { TipoEnum.Eletrico } },
                new Pokemon() { Id = 27, Nome = "Sandshrew", Altura = 0.6, Peso = 12.0, Tipo = new List<TipoEnum> { TipoEnum.Terrestre } },
                new Pokemon() { Id = 28, Nome = "Sandslash", Altura = 1.0, Peso = 29.5, Tipo = new List<TipoEnum> { TipoEnum.Terrestre } },
                new Pokemon() { Id = 29, Nome = "Nidoran♀", Altura = 0.4, Peso = 7.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 30, Nome = "Nidorina", Altura = 0.8, Peso = 20.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 31, Nome = "Nidoqueen", Altura = 1.3, Peso = 60.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso, TipoEnum.Terrestre } },
                new Pokemon() { Id = 32, Nome = "Nidoran♂", Altura = 0.5, Peso = 9.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 33, Nome = "Nidorino", Altura = 0.9, Peso = 19.5, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 34, Nome = "Nidoking", Altura = 1.4, Peso = 62.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso, TipoEnum.Terrestre } },
                new Pokemon() { Id = 35, Nome = "Clefairy", Altura = 0.6, Peso = 7.5, Tipo = new List<TipoEnum> { TipoEnum.Fada } },
                new Pokemon() { Id = 36, Nome = "Clefable", Altura = 1.3, Peso = 40.0, Tipo = new List<TipoEnum> { TipoEnum.Fada } },
                new Pokemon() { Id = 37, Nome = "Vulpix", Altura = 0.6, Peso = 9.9, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 38, Nome = "Ninetales", Altura = 1.1, Peso = 19.9, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 39, Nome = "Jigglypuff", Altura = 0.5, Peso = 5.5, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Fada } },
                new Pokemon() { Id = 40, Nome = "Wigglytuff", Altura = 1.0, Peso = 12.0, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Fada } },
                new Pokemon() { Id = 41, Nome = "Zubat", Altura = 0.8, Peso = 7.5, Tipo = new List<TipoEnum> { TipoEnum.Voador, TipoEnum.Venenoso } },
                new Pokemon() { Id = 42, Nome = "Golbat", Altura = 1.6, Peso = 55.0, Tipo = new List<TipoEnum> { TipoEnum.Voador, TipoEnum.Venenoso } },
                new Pokemon() { Id = 43, Nome = "Oddish", Altura = 0.5, Peso = 5.4, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 44, Nome = "Gloom", Altura = 0.8, Peso = 8.6, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 45, Nome = "Vileplume", Altura = 1.2, Peso = 18.6, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 46, Nome = "Paras", Altura = 0.3, Peso = 5.4, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Planta } },
                new Pokemon() { Id = 47, Nome = "Parasect", Altura = 1.0, Peso = 29.5, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Planta } },
                new Pokemon() { Id = 48, Nome = "Venonat", Altura = 1.0, Peso = 30.0, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Venenoso } },
                new Pokemon() { Id = 49, Nome = "Venomoth", Altura = 1.5, Peso = 12.5, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Venenoso } },
                new Pokemon() { Id = 50, Nome = "Diglett", Altura = 0.2, Peso = 0.8, Tipo = new List<TipoEnum> { TipoEnum.Terrestre } },
                new Pokemon() { Id = 51, Nome = "Dugtrio", Altura = 0.7, Peso = 33.3, Tipo = new List<TipoEnum> { TipoEnum.Terrestre } },
                new Pokemon() { Id = 52, Nome = "Meowth", Altura = 0.4, Peso = 4.2, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 53, Nome = "Persian", Altura = 1.0, Peso = 32.0, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 54, Nome = "Psyduck", Altura = 0.8, Peso = 19.6, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 55, Nome = "Golduck", Altura = 1.7, Peso = 76.6, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 56, Nome = "Mankey", Altura = 0.5, Peso = 28.0, Tipo = new List<TipoEnum> { TipoEnum.Lutador } },
                new Pokemon() { Id = 57, Nome = "Primeape", Altura = 1.0, Peso = 32.0, Tipo = new List<TipoEnum> { TipoEnum.Lutador } },
                new Pokemon() { Id = 58, Nome = "Growlithe", Altura = 0.7, Peso = 19.0, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 59, Nome = "Arcanine", Altura = 1.9, Peso = 155.0, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 60, Nome = "Poliwag", Altura = 0.6, Peso = 12.4, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 61, Nome = "Poliwhirl", Altura = 1.0, Peso = 20.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 62, Nome = "Poliwrath", Altura = 1.3, Peso = 54.0, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Lutador } },
                new Pokemon() { Id = 63, Nome = "Abra", Altura = 0.9, Peso = 19.5, Tipo = new List<TipoEnum> { TipoEnum.Psiquico } },
                new Pokemon() { Id = 64, Nome = "Kadabra", Altura = 1.3, Peso = 56.5, Tipo = new List<TipoEnum> { TipoEnum.Psiquico } },
                new Pokemon() { Id = 65, Nome = "Alakazam", Altura = 1.5, Peso = 48.0, Tipo = new List<TipoEnum> { TipoEnum.Psiquico } },
                new Pokemon() { Id = 66, Nome = "Machop", Altura = 0.8, Peso = 19.5, Tipo = new List<TipoEnum> { TipoEnum.Lutador } },
                new Pokemon() { Id = 67, Nome = "Machoke", Altura = 1.5, Peso = 70.5, Tipo = new List<TipoEnum> { TipoEnum.Lutador } },
                new Pokemon() { Id = 68, Nome = "Machamp", Altura = 1.6, Peso = 130.0, Tipo = new List<TipoEnum> { TipoEnum.Lutador } },
                new Pokemon() { Id = 69, Nome = "Bellsprout", Altura = 0.7, Peso = 4.0, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 70, Nome = "Weepinbell", Altura = 1.0, Peso = 6.4, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 71, Nome = "Victreebel", Altura = 1.7, Peso = 15.5, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Venenoso } },
                new Pokemon() { Id = 72, Nome = "Tentacool", Altura = 0.9, Peso = 45.5, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Venenoso } },
                new Pokemon() { Id = 73, Nome = "Tentacruel", Altura = 1.6, Peso = 55.0, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Venenoso } },
                new Pokemon() { Id = 74, Nome = "Geodude", Altura = 0.4, Peso = 20.0, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Terrestre } },
                new Pokemon() { Id = 75, Nome = "Graveler", Altura = 1.0, Peso = 105.0, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Terrestre } },
                new Pokemon() { Id = 76, Nome = "Golem", Altura = 1.4, Peso = 300.0, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Terrestre } },
                new Pokemon() { Id = 77, Nome = "Ponyta", Altura = 1.0, Peso = 30.0, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 78, Nome = "Rapidash", Altura = 1.7, Peso = 95.0, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 79, Nome = "Slowpoke", Altura = 1.2, Peso = 36.0, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Psiquico } },
                new Pokemon() { Id = 80, Nome = "Slowbro", Altura = 1.6, Peso = 78.5, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Psiquico } },
                new Pokemon() { Id = 81, Nome = "Magnemite", Altura = 0.3, Peso = 6.0, Tipo = new List<TipoEnum> { TipoEnum.Eletrico, TipoEnum.Aco } },
                new Pokemon() { Id = 82, Nome = "Magneton", Altura = 1.0, Peso = 60.0, Tipo = new List<TipoEnum> { TipoEnum.Eletrico, TipoEnum.Aco } },
                new Pokemon() { Id = 83, Nome = "Farfetch'd", Altura = 0.8, Peso = 15.0, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Voador } },
                new Pokemon() { Id = 84, Nome = "Doduo", Altura = 1.4, Peso = 39.2, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Voador } },
                new Pokemon() { Id = 85, Nome = "Dodrio", Altura = 1.8, Peso = 85.2, Tipo = new List<TipoEnum> { TipoEnum.Normal, TipoEnum.Voador } },
                new Pokemon() { Id = 86, Nome = "Seel", Altura = 1.1, Peso = 90.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 87, Nome = "Dewgong", Altura = 1.7, Peso = 120.0, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Gelo } },
                new Pokemon() { Id = 88, Nome = "Grimer", Altura = 0.9, Peso = 30.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 89, Nome = "Muk", Altura = 1.2, Peso = 30.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 90, Nome = "Shellder", Altura = 0.3, Peso = 4.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 91, Nome = "Cloyster", Altura = 1.5, Peso = 132.5, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Gelo } },
                new Pokemon() { Id = 92, Nome = "Gastly", Altura = 1.3, Peso = 0.1, Tipo = new List<TipoEnum> { TipoEnum.Fantasma, TipoEnum.Venenoso } },
                new Pokemon() { Id = 93, Nome = "Haunter", Altura = 1.6, Peso = 0.1, Tipo = new List<TipoEnum> { TipoEnum.Fantasma, TipoEnum.Venenoso } },
                new Pokemon() { Id = 94, Nome = "Gengar", Altura = 1.5, Peso = 40.5, Tipo = new List<TipoEnum> { TipoEnum.Fantasma, TipoEnum.Venenoso } },
                new Pokemon() { Id = 95, Nome = "Onix", Altura = 8.8, Peso = 210.0, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Terrestre } },
                new Pokemon() { Id = 96, Nome = "Drowzee", Altura = 1.0, Peso = 32.4, Tipo = new List<TipoEnum> { TipoEnum.Psiquico } },
                new Pokemon() { Id = 97, Nome = "Hypno", Altura = 1.6, Peso = 75.6, Tipo = new List<TipoEnum> { TipoEnum.Psiquico } },
                new Pokemon() { Id = 98, Nome = "Krabby", Altura = 0.4, Peso = 6.5, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 99, Nome = "Kingler", Altura = 1.3, Peso = 60.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 100, Nome = "Voltorb", Altura = 0.5, Peso = 10.4, Tipo = new List<TipoEnum> { TipoEnum.Eletrico } },
                new Pokemon() { Id = 101, Nome = "Electrode", Altura = 1.2, Peso = 66.6, Tipo = new List<TipoEnum> { TipoEnum.Eletrico } },
                new Pokemon() { Id = 102, Nome = "Exeggcute", Altura = 0.4, Peso = 2.5, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Psiquico } },
                new Pokemon() { Id = 103, Nome = "Exeggutor", Altura = 2.0, Peso = 120.0, Tipo = new List<TipoEnum> { TipoEnum.Planta, TipoEnum.Psiquico } },
                new Pokemon() { Id = 104, Nome = "Cubone", Altura = 0.4, Peso = 6.5, Tipo = new List<TipoEnum> { TipoEnum.Terrestre } },
                new Pokemon() { Id = 105, Nome = "Marowak", Altura = 1.0, Peso = 45.0, Tipo = new List<TipoEnum> { TipoEnum.Terrestre } },
                new Pokemon() { Id = 106, Nome = "Hitmonlee", Altura = 1.5, Peso = 49.8, Tipo = new List<TipoEnum> { TipoEnum.Lutador } },
                new Pokemon() { Id = 107, Nome = "Hitmonchan", Altura = 1.4, Peso = 50.2, Tipo = new List<TipoEnum> { TipoEnum.Lutador } },
                new Pokemon() { Id = 108, Nome = "Lickitung", Altura = 1.2, Peso = 65.5, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 109, Nome = "Koffing", Altura = 0.6, Peso = 1.0, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 110, Nome = "Weezing", Altura = 1.2, Peso = 9.5, Tipo = new List<TipoEnum> { TipoEnum.Venenoso } },
                new Pokemon() { Id = 111, Nome = "Rhyhorn", Altura = 1.0, Peso = 115.0, Tipo = new List<TipoEnum> { TipoEnum.Terrestre, TipoEnum.Pedra } },
                new Pokemon() { Id = 112, Nome = "Rhydon", Altura = 1.9, Peso = 120.0, Tipo = new List<TipoEnum> { TipoEnum.Terrestre, TipoEnum.Pedra } },
                new Pokemon() { Id = 113, Nome = "Chansey", Altura = 1.1, Peso = 34.6, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 114, Nome = "Tangela", Altura = 1.0, Peso = 35.0, Tipo = new List<TipoEnum> { TipoEnum.Planta } },
                new Pokemon() { Id = 115, Nome = "Kangaskhan", Altura = 2.2, Peso = 80.0, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 116, Nome = "Horsea", Altura = 0.4, Peso = 8.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 117, Nome = "Seadra", Altura = 1.2, Peso = 25.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 118, Nome = "Goldeen", Altura = 0.6, Peso = 15.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 119, Nome = "Seaking", Altura = 1.3, Peso = 39.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 120, Nome = "Staryu", Altura = 0.8, Peso = 34.5, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 121, Nome = "Starmie", Altura = 1.1, Peso = 80.0, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Psiquico } },
                new Pokemon() { Id = 122, Nome = "Mr. Mime", Altura = 1.3, Peso = 54.5, Tipo = new List<TipoEnum> { TipoEnum.Psiquico } },
                new Pokemon() { Id = 123, Nome = "Scyther", Altura = 1.5, Peso = 56.0, Tipo = new List<TipoEnum> { TipoEnum.Inseto, TipoEnum.Voador } },
                new Pokemon() { Id = 124, Nome = "Jynx", Altura = 1.4, Peso = 40.6, Tipo = new List<TipoEnum> { TipoEnum.Gelo, TipoEnum.Psiquico } },
                new Pokemon() { Id = 125, Nome = "Electabuzz", Altura = 1.1, Peso = 30.0, Tipo = new List<TipoEnum> { TipoEnum.Eletrico } },
                new Pokemon() { Id = 126, Nome = "Magmar", Altura = 1.3, Peso = 44.5, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 127, Nome = "Pinsir", Altura = 1.5, Peso = 55.0, Tipo = new List<TipoEnum> { TipoEnum.Inseto } },
                new Pokemon() { Id = 128, Nome = "Tauros", Altura = 1.4, Peso = 88.4, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 129, Nome = "Magikarp", Altura = 0.9, Peso = 10.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 130, Nome = "Gyarados", Altura = 6.5, Peso = 235.0, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Voador } },
                new Pokemon() { Id = 131, Nome = "Lapras", Altura = 2.5, Peso = 220.0, Tipo = new List<TipoEnum> { TipoEnum.Agua, TipoEnum.Gelo } },
                new Pokemon() { Id = 132, Nome = "Ditto", Altura = 0.3, Peso = 4.0, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 133, Nome = "Eevee", Altura = 0.3, Peso = 6.5, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 134, Nome = "Vaporeon", Altura = 1.0, Peso = 29.0, Tipo = new List<TipoEnum> { TipoEnum.Agua } },
                new Pokemon() { Id = 135, Nome = "Jolteon", Altura = 0.8, Peso = 24.5, Tipo = new List<TipoEnum> { TipoEnum.Eletrico } },
                new Pokemon() { Id = 136, Nome = "Flareon", Altura = 0.9, Peso = 25.0, Tipo = new List<TipoEnum> { TipoEnum.Fogo } },
                new Pokemon() { Id = 137, Nome = "Porygon", Altura = 0.8, Peso = 36.5, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 138, Nome = "Omanyte", Altura = 0.4, Peso = 7.5, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Agua } },
                new Pokemon() { Id = 139, Nome = "Omastar", Altura = 1.0, Peso = 35.0, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Agua } },
                new Pokemon() { Id = 140, Nome = "Kabuto", Altura = 0.5, Peso = 11.5, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Agua } },
                new Pokemon() { Id = 141, Nome = "Kabutops", Altura = 1.3, Peso = 40.5, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Agua } },
                new Pokemon() { Id = 142, Nome = "Aerodactyl", Altura = 1.8, Peso = 59.0, Tipo = new List<TipoEnum> { TipoEnum.Pedra, TipoEnum.Voador } },
                new Pokemon() { Id = 143, Nome = "Snorlax", Altura = 2.1, Peso = 460.0, Tipo = new List<TipoEnum> { TipoEnum.Normal } },
                new Pokemon() { Id = 144, Nome = "Articuno", Altura = 1.7, Peso = 55.4, Tipo = new List<TipoEnum> { TipoEnum.Gelo, TipoEnum.Voador } },
                new Pokemon() { Id = 145, Nome = "Zapdos", Altura = 1.6, Peso = 52.6, Tipo = new List<TipoEnum> { TipoEnum.Eletrico, TipoEnum.Voador } },
                new Pokemon() { Id = 146, Nome = "Moltres", Altura = 2.0, Peso = 60.0, Tipo = new List<TipoEnum> { TipoEnum.Fogo, TipoEnum.Voador } },
                new Pokemon() { Id = 147, Nome = "Dratini", Altura = 1.8, Peso = 3.3, Tipo = new List<TipoEnum> { TipoEnum.Dragao } },
                new Pokemon() { Id = 148, Nome = "Dragonair", Altura = 4.0, Peso = 16.5, Tipo = new List<TipoEnum> { TipoEnum.Dragao } },
                new Pokemon() { Id = 149, Nome = "Dragonite", Altura = 2.2, Peso = 210.0, Tipo = new List<TipoEnum> { TipoEnum.Dragao, TipoEnum.Voador } },
                new Pokemon() { Id = 150, Nome = "Mewtwo", Altura = 2.0, Peso = 122.0, Tipo = new List<TipoEnum> { TipoEnum.Psiquico } },
                new Pokemon() { Id = 151, Nome = "Mew", Altura = 0.4, Peso = 4.0, Tipo = new List<TipoEnum> { TipoEnum.Psiquico } }
            );
            modelBuilder.Entity<Habilidade>().HasData(
                new Habilidade() { Id = 1, Nome = "Tackle", Descricao = "Um ataque corporal comum.", Poder = 40, Precisao = 100, PP = 35, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 2, Nome = "Growl", Descricao = "Reduz o Ataque do oponente.", Poder = 0, Precisao = 100, PP = 40, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 3, Nome = "Vine Whip", Descricao = "Ataca com vinhas ou chicotes.", Poder = 45, Precisao = 100, PP = 25, Tipo = TipoEnum.Planta },
                new Habilidade() { Id = 4, Nome = "Razor Leaf", Descricao = "Lâminas de folha são lançadas como navalhas.", Poder = 55, Precisao = 95, PP = 25, Tipo = TipoEnum.Planta },
                new Habilidade() { Id = 5, Nome = "Flamethrower", Descricao = "Ataque com uma rajada de fogo intenso.", Poder = 90, Precisao = 100, PP = 15, Tipo = TipoEnum.Fogo },
                new Habilidade() { Id = 6, Nome = "Fire Spin", Descricao = "Envolve o oponente em chamas por 2 a 5 turnos.", Poder = 35, Precisao = 85, PP = 15, Tipo = TipoEnum.Fogo },
                new Habilidade() { Id = 7, Nome = "Slash", Descricao = "Um ataque cortante com alta chance de acerto crítico.", Poder = 70, Precisao = 100, PP = 20, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 8, Nome = "Water Gun", Descricao = "Atira água com pressão no oponente.", Poder = 40, Precisao = 100, PP = 25, Tipo = TipoEnum.Agua },
                new Habilidade() { Id = 9, Nome = "Hydro Pump", Descricao = "Atira um jato de água poderoso no oponente.", Poder = 110, Precisao = 80, PP = 5, Tipo = TipoEnum.Agua },
                new Habilidade() { Id = 10, Nome = "Surf", Descricao = "Ataque com uma onda gigante. Pode ser usado fora de batalha para atravessar a água.", Poder = 90, Precisao = 100, PP = 15, Tipo = TipoEnum.Agua },
                new Habilidade() { Id = 11, Nome = "Thunderbolt", Descricao = "Ataque elétrico com chance de paralisar o oponente.", Poder = 90, Precisao = 100, PP = 15, Tipo = TipoEnum.Eletrico },
                new Habilidade() { Id = 12, Nome = "Thunder", Descricao = "Ataque elétrico poderoso com chance de paralisar o oponente.", Poder = 110, Precisao = 70, PP = 10, Tipo = TipoEnum.Eletrico },
                new Habilidade() { Id = 13, Nome = "Thunder Wave", Descricao = "Paralisa o oponente.", Poder = 0, Precisao = 90, PP = 20, Tipo = TipoEnum.Eletrico },
                new Habilidade() { Id = 14, Nome = "Dig", Descricao = "Cava um buraco no primeiro turno e ataca no segundo.", Poder = 80, Precisao = 100, PP = 10, Tipo = TipoEnum.Terrestre },
                new Habilidade() { Id = 15, Nome = "Earthquake", Descricao = "Um terremoto que atinge todos os Pokémon em campo.", Poder = 100, Precisao = 100, PP = 10, Tipo = TipoEnum.Terrestre },
                new Habilidade() { Id = 16, Nome = "Confusion", Descricao = "Ataque psíquico que pode confundir o oponente.", Poder = 50, Precisao = 100, PP = 25, Tipo = TipoEnum.Psiquico },
                new Habilidade() { Id = 17, Nome = "Psychic", Descricao = "Ataque psíquico poderoso que pode abaixar a Defesa Especial do oponente.", Poder = 90, Precisao = 100, PP = 10, Tipo = TipoEnum.Psiquico },
                new Habilidade() { Id = 18, Nome = "Hypnosis", Descricao = "Faz o oponente dormir.", Poder = 0, Precisao = 60, PP = 20, Tipo = TipoEnum.Psiquico },
                new Habilidade() { Id = 19, Nome = "Leech Life", Descricao = "Ataque que suga a vida do oponente.", Poder = 80, Precisao = 100, PP = 10, Tipo = TipoEnum.Inseto },
                new Habilidade() { Id = 20, Nome = "Acid", Descricao = "Ataque ácido que pode abaixar a Defesa do oponente.", Poder = 40, Precisao = 100, PP = 30, Tipo = TipoEnum.Venenoso },
                new Habilidade() { Id = 21, Nome = "Ember", Descricao = "Ataque com chamas pequenas. Pode queimar o oponente.", Poder = 40, Precisao = 100, PP = 25, Tipo = TipoEnum.Fogo },
                new Habilidade() { Id = 22, Nome = "Fire Blast", Descricao = "Ataque com uma bola de fogo que pode queimar o oponente.", Poder = 110, Precisao = 85, PP = 5, Tipo = TipoEnum.Fogo },
                new Habilidade() { Id = 23, Nome = "Rage", Descricao = "Aumenta o Ataque a cada turno que é atingido.", Poder = 20, Precisao = 100, PP = 20, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 24, Nome = "Teleport", Descricao = "Foge da batalha selvagem ou de uma batalha de treinador.", Poder = 0, Precisao = 100, PP = 20, Tipo = TipoEnum.Psiquico },
                new Habilidade() { Id = 25, Nome = "Night Shade", Descricao = "Ataque fantasma que causa dano igual ao nível do usuário.", Poder = 0, Precisao = 100, PP = 15, Tipo = TipoEnum.Fantasma },
                new Habilidade() { Id = 26, Nome = "Mimic", Descricao = "Copia a última habilidade usada pelo oponente.", Poder = 0, Precisao = 100, PP = 10, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 27, Nome = "Screech", Descricao = "Reduz a Defesa do oponente.", Poder = 0, Precisao = 85, PP = 40, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 28, Nome = "Double Team", Descricao = "Aumenta a evasão do usuário.", Poder = 0, Precisao = 100, PP = 15, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 29, Nome = "Recover", Descricao = "Recupera metade dos pontos de vida do usuário.", Poder = 0, Precisao = 100, PP = 10, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 30, Nome = "Harden", Descricao = "Aumenta a Defesa do usuário.", Poder = 0, Precisao = 100, PP = 30, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 31, Nome = "Minimize", Descricao = "Aumenta a evasão do usuário.", Poder = 0, Precisao = 100, PP = 20, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 32, Nome = "Smokescreen", Descricao = "Reduz a precisão do oponente.", Poder = 0, Precisao = 100, PP = 20, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 33, Nome = "Confuse Ray", Descricao = "Confunde o oponente.", Poder = 0, Precisao = 100, PP = 10, Tipo = TipoEnum.Fantasma },
                new Habilidade() { Id = 34, Nome = "Withdraw", Descricao = "Aumenta a Defesa do usuário.", Poder = 0, Precisao = 100, PP = 40, Tipo = TipoEnum.Agua },
                new Habilidade() { Id = 35, Nome = "Barrier", Descricao = "Aumenta a Defesa do usuário.", Poder = 0, Precisao = 100, PP = 20, Tipo = TipoEnum.Psiquico },
                new Habilidade() { Id = 36, Nome = "Light Screen", Descricao = "Reduz o dano de ataques especiais do oponente.", Poder = 0, Precisao = 100, PP = 30, Tipo = TipoEnum.Psiquico },
                new Habilidade() { Id = 37, Nome = "Haze", Descricao = "Remove todas as alterações de status.", Poder = 0, Precisao = 100, PP = 30, Tipo = TipoEnum.Gelo },
                new Habilidade() { Id = 38, Nome = "Reflect", Descricao = "Reduz o dano de ataques físicos do oponente.", Poder = 0, Precisao = 100, PP = 20, Tipo = TipoEnum.Psiquico },
                new Habilidade() { Id = 39, Nome = "Rock Tomb", Descricao = "Atira pedras no oponente. Pode reduzir a velocidade do oponente.", Poder = 60, Precisao = 95, PP = 15, Tipo = TipoEnum.Pedra },
                new Habilidade() { Id = 40, Nome = "Defense Curl", Descricao = "Aumenta a Defesa do usuário.", Poder = 0, Precisao = 100, PP = 40, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 41, Nome = "Focus Energy", Descricao = "Aumenta a chance de acerto crítico.", Poder = 0, Precisao = 100, PP = 30, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 42, Nome = "Bide", Descricao = "Guarda energia por 2 a 3 turnos e depois ataca.", Poder = 0, Precisao = 100, PP = 10, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 43, Nome = "Metronome", Descricao = "Usa um ataque aleatório.", Poder = 0, Precisao = 100, PP = 10, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 44, Nome = "Mirror Move", Descricao = "Copia o último ataque usado pelo oponente.", Poder = 0, Precisao = 100, PP = 20, Tipo = TipoEnum.Voador },
                new Habilidade() { Id = 45, Nome = "Self-Destruct", Descricao = "Causa dano ao usuário e ao oponente.", Poder = 200, Precisao = 100, PP = 5, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 46, Nome = "Egg Bomb", Descricao = "Atira ovos no oponente.", Poder = 100, Precisao = 75, PP = 10, Tipo = TipoEnum.Normal },
                new Habilidade() { Id = 47, Nome = "Lick", Descricao = "Ataque com a língua. Pode paralisar o oponente.", Poder = 20, Precisao = 100, PP = 30, Tipo = TipoEnum.Fantasma },
                new Habilidade() { Id = 48, Nome = "Smog", Descricao = "Ataque de fumaça venenosa. Pode envenenar o oponente.", Poder = 30, Precisao = 70, PP = 20, Tipo = TipoEnum.Venenoso },
                new Habilidade() { Id = 49, Nome = "Sludge", Descricao = "Ataque de lodo venenoso. Pode envenenar o oponente.", Poder = 65, Precisao = 100, PP = 20, Tipo = TipoEnum.Venenoso },
                new Habilidade() { Id = 50, Nome = "Bone Club", Descricao = "Ataque com um osso. Pode causar acerto crítico.", Poder = 65, Precisao = 85, PP = 20, Tipo = TipoEnum.Terrestre },
                new Habilidade() { Id = 51, Nome = "Fire Punch", Descricao = "Ataque de soco em chamas. Pode queimar o oponente.", Poder = 75, Precisao = 100, PP = 15, Tipo = TipoEnum.Fogo },
                new Habilidade() { Id = 52, Nome = "Ice Punch", Descricao = "Ataque de soco congelante. Pode congelar o oponente.", Poder = 75, Precisao = 100, PP = 15, Tipo = TipoEnum.Gelo },
                new Habilidade() { Id = 53, Nome = "Thunder Punch", Descricao = "Ataque de soco elétrico. Pode paralisar o oponente.", Poder = 75, Precisao = 100, PP = 15, Tipo = TipoEnum.Eletrico },
                new Habilidade() { Id = 54, Nome = "Dragon Rage", Descricao = "Causa 40 pontos de dano.", Poder = 40, Precisao = 100, PP = 10, Tipo = TipoEnum.Dragao },
                new Habilidade() { Id = 55, Nome = "Bind", Descricao = "Prende o oponente por 2 a 5 turnos.", Poder = 15, Precisao = 85, PP = 20, Tipo = TipoEnum.Normal }
            );
            modelBuilder.Entity<Treinador>().HasData(
                new Treinador() { Id = 1, Nome = "Brock", Insignias = new List<InsigniasEnum> { InsigniasEnum.Rocha }, Regiao = "Kanto" },
                new Treinador() { Id = 2, Nome = "Misty", Insignias = new List<InsigniasEnum> { InsigniasEnum.Cascata }, Regiao = "Kanto" },
                new Treinador() { Id = 3, Nome = "Sg. Surge", Insignias = new List<InsigniasEnum> { InsigniasEnum.Trovao }, Regiao = "Kanto" },
                new Treinador() { Id = 4, Nome = "Erika", Insignias = new List<InsigniasEnum> { InsigniasEnum.ArcoIris }, Regiao = "Kanto" },
                new Treinador() { Id = 5, Nome = "Koga", Insignias = new List<InsigniasEnum> { InsigniasEnum.Alma }, Regiao = "Kanto" },
                new Treinador() { Id = 6, Nome = "Sabrina", Insignias = new List<InsigniasEnum> { InsigniasEnum.Pantano }, Regiao = "Kanto" },
                new Treinador() { Id = 7, Nome = "Blaine", Insignias = new List<InsigniasEnum> { InsigniasEnum.Vulcao }, Regiao = "Kanto" },
                new Treinador() { Id = 8, Nome = "Giovanni", Insignias = new List<InsigniasEnum> { InsigniasEnum.Terra }, Regiao = "Kanto" }
            );
            modelBuilder.Entity<TreinadorPokemon>().HasData(
                new TreinadorPokemon() { TreinadorId = 1, PokemonId = 74, Nivel = 12, Habilidade1Id = 1, Habilidade2Id = 40 },
                new TreinadorPokemon() { TreinadorId = 1, PokemonId = 95, Nivel = 14, Habilidade1Id = 1, Habilidade2Id = 30, Habilidade3Id = 54, Habilidade4Id = 39 }
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(100);
        }
    }
}