using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ETEC_DS_POKEMON.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_TREINADORES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Insignias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Regiao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TREINADORES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_POKEMONS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Genero = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Ataque = table.Column<int>(type: "int", nullable: false),
                    Defesa = table.Column<int>(type: "int", nullable: false),
                    Velocidade = table.Column<int>(type: "int", nullable: false),
                    TreinadorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_POKEMONS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_POKEMONS_TB_TREINADORES_TreinadorId",
                        column: x => x.TreinadorId,
                        principalTable: "TB_TREINADORES",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Poder = table.Column<int>(type: "int", nullable: false),
                    Precisao = table.Column<int>(type: "int", nullable: false),
                    PP = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_HABILIDADES_TB_POKEMONS_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "TB_POKEMONS",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Descricao", "Nome", "PP", "Poder", "PokemonId", "Precisao" },
                values: new object[,]
                {
                    { 1, "Um ataque corporal comum.", "Tackle", 35, 40, null, 100 },
                    { 2, "Reduz o Ataque do oponente.", "Growl", 40, 0, null, 100 },
                    { 3, "Ataca com vinhas ou chicotes.", "Vine Whip", 25, 45, null, 100 },
                    { 4, "Lâminas de folha são lançadas como navalhas.", "Razor Leaf", 25, 55, null, 95 },
                    { 5, "Ataque com uma rajada de fogo intenso.", "Flamethrower", 15, 90, null, 100 },
                    { 6, "Envolve o oponente em chamas por 2 a 5 turnos.", "Fire Spin", 15, 35, null, 85 },
                    { 7, "Um ataque cortante com alta chance de acerto crítico.", "Slash", 20, 70, null, 100 }
                });

            migrationBuilder.InsertData(
                table: "TB_POKEMONS",
                columns: new[] { "Id", "Altura", "Ataque", "Defesa", "Genero", "Nivel", "Nome", "Peso", "Tipo", "TreinadorId", "Velocidade", "Vida" },
                values: new object[,]
                {
                    { 1, 0.69999999999999996, 49, 49, "M", 1, "Bulbasaur", 6.9000000000000004, "[9,13]", null, 45, 45 },
                    { 2, 1.0, 62, 63, "M", 1, "Ivysaur", 13.0, "[9,13]", null, 60, 60 },
                    { 3, 2.0, 82, 83, "M", 1, "Venusaur", 100.0, "[9,13]", null, 80, 80 },
                    { 4, 0.59999999999999998, 52, 43, "M", 1, "Charmander", 8.5, "[6]", null, 65, 39 },
                    { 5, 1.1000000000000001, 64, 58, "M", 1, "Charmeleon", 19.0, "[6]", null, 80, 58 },
                    { 6, 1.7, 84, 78, "M", 1, "Charizard", 90.5, "[6,7]", null, 100, 78 }
                });

            migrationBuilder.InsertData(
                table: "TB_TREINADORES",
                columns: new[] { "Id", "Insignias", "Nome", "Regiao" },
                values: new object[,]
                {
                    { 1, "[0]", "Brock", "Kanto" },
                    { 2, "[1]", "Misty", "Kanto" },
                    { 3, "[2]", "Sg. Surge", "Kanto" },
                    { 4, "[3]", "Erika", "Kanto" },
                    { 5, "[4]", "Koga", "Kanto" },
                    { 6, "[5]", "Sabrina", "Kanto" },
                    { 7, "[6]", "Blaine", "Kanto" },
                    { 8, "[7]", "Giovanni", "Kanto" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_HABILIDADES_PokemonId",
                table: "TB_HABILIDADES",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_POKEMONS_TreinadorId",
                table: "TB_POKEMONS",
                column: "TreinadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_POKEMONS");

            migrationBuilder.DropTable(
                name: "TB_TREINADORES");
        }
    }
}
