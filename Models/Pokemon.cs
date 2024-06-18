using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using PokemonApi.Models.Enuns;

namespace PokemonApi.Models {
    public class Pokemon {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Genero { get; set; } = "";
        public List<TipoEnum> Tipo { get; set; }
        public List<TreinadorPokemon> TreinadorPokemons { get; set; } = new();
    }
}