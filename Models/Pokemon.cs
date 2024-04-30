using System.ComponentModel.DataAnnotations;
using PokemonApi.Models.Enuns;

namespace PokemonApi.Models {
    public class Pokemon {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Genero { get; set; } = "";
        public List<TipoEnum> Tipo { get; set; } = new();
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int Velocidade { get; set; }
        public List<Habilidade> Habilidades { get; set; } = new();
    }
}