namespace PokemonApi.Models {
    public class Habilidade {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Descricao { get; set; } = "";
        public int Poder { get; set; }
        public int Precisao { get; set; }
        public int PP { get; set; }
    }
}