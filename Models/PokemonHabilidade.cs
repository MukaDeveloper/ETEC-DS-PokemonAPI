using PokemonApi.Models;

namespace PokemonApi.Models
{
    public class PokemonHabilidade
    {
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public int HabilidadeId { get; set; }
        public Habilidade Habilidade { get; set; }
    }
}