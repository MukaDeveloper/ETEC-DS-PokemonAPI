

namespace PokemonApi.Models
{
    public class TreinadorPokemon
    {
        public int TreinadorId { get; set; }
        public Treinador Treinador { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public int? Nivel { get; set; }
        public int? Vida { get; set; }
        public int? Ataque { get; set; }
        public int? Defesa { get; set; }
        public int? Velocidade { get; set; }
    }
}