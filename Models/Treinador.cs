using System.ComponentModel.DataAnnotations;
using PokemonApi.Models.Enuns;

namespace PokemonApi.Models
{
    public class Treinador
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public List<InsigniasEnum> Insignias { get; set; } = new();
        public string Regiao { get; set; } = "";
        public List<Pokemon> Pokemons { get; set; } = new();
        
    }
}