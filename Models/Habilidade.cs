using System.ComponentModel.DataAnnotations;

namespace PokemonApi.Models {
    public class Habilidade {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Descricao { get; set; } = "";
        public int Poder { get; set; }
        public int Precisao { get; set; }
        public int PP { get; set; }
        public List<Pokemon>? Pokemons { get; set; }
    }
}