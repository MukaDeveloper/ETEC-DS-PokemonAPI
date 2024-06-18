using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ETEC_DS_POKEMON.Migrations
{
    /// <inheritdoc />
    public partial class StructureCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
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
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_POKEMONS", x => x.Id);
                });

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
                name: "TB_TREINADORES_POKEMONS",
                columns: table => new
                {
                    TreinadorId = table.Column<int>(type: "int", nullable: false),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: true),
                    Vida = table.Column<int>(type: "int", nullable: true),
                    Ataque = table.Column<int>(type: "int", nullable: true),
                    Defesa = table.Column<int>(type: "int", nullable: true),
                    Velocidade = table.Column<int>(type: "int", nullable: true),
                    Habilidade1Id = table.Column<int>(type: "int", nullable: false),
                    Habilidade2Id = table.Column<int>(type: "int", nullable: true),
                    Habilidade3Id = table.Column<int>(type: "int", nullable: true),
                    Habilidade4Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TREINADORES_POKEMONS", x => new { x.TreinadorId, x.PokemonId });
                    table.ForeignKey(
                        name: "FK_TB_TREINADORES_POKEMONS_TB_POKEMONS_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "TB_POKEMONS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_TREINADORES_POKEMONS_TB_TREINADORES_TreinadorId",
                        column: x => x.TreinadorId,
                        principalTable: "TB_TREINADORES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Descricao", "Nome", "PP", "Poder", "Precisao", "Tipo" },
                values: new object[,]
                {
                    { 1, "Um ataque corporal comum.", "Tackle", 35, 40, 100, 12 },
                    { 2, "Reduz o Ataque do oponente.", "Growl", 40, 0, 100, 12 },
                    { 3, "Ataca com vinhas ou chicotes.", "Vine Whip", 25, 45, 100, 9 },
                    { 4, "Lâminas de folha são lançadas como navalhas.", "Razor Leaf", 25, 55, 95, 9 },
                    { 5, "Ataque com uma rajada de fogo intenso.", "Flamethrower", 15, 90, 100, 6 },
                    { 6, "Envolve o oponente em chamas por 2 a 5 turnos.", "Fire Spin", 15, 35, 85, 6 },
                    { 7, "Um ataque cortante com alta chance de acerto crítico.", "Slash", 20, 70, 100, 12 },
                    { 8, "Atira água com pressão no oponente.", "Water Gun", 25, 40, 100, 17 },
                    { 9, "Atira um jato de água poderoso no oponente.", "Hydro Pump", 5, 110, 80, 17 },
                    { 10, "Ataque com uma onda gigante. Pode ser usado fora de batalha para atravessar a água.", "Surf", 15, 90, 100, 17 },
                    { 11, "Ataque elétrico com chance de paralisar o oponente.", "Thunderbolt", 15, 90, 100, 3 },
                    { 12, "Ataque elétrico poderoso com chance de paralisar o oponente.", "Thunder", 10, 110, 70, 3 },
                    { 13, "Paralisa o oponente.", "Thunder Wave", 20, 0, 90, 3 },
                    { 14, "Cava um buraco no primeiro turno e ataca no segundo.", "Dig", 10, 80, 100, 10 },
                    { 15, "Um terremoto que atinge todos os Pokémon em campo.", "Earthquake", 10, 100, 100, 10 },
                    { 16, "Ataque psíquico que pode confundir o oponente.", "Confusion", 25, 50, 100, 14 },
                    { 17, "Ataque psíquico poderoso que pode abaixar a Defesa Especial do oponente.", "Psychic", 10, 90, 100, 14 },
                    { 18, "Faz o oponente dormir.", "Hypnosis", 20, 0, 60, 14 },
                    { 19, "Ataque que suga a vida do oponente.", "Leech Life", 10, 80, 100, 0 },
                    { 20, "Ataque ácido que pode abaixar a Defesa do oponente.", "Acid", 30, 40, 100, 13 },
                    { 21, "Ataque com chamas pequenas. Pode queimar o oponente.", "Ember", 25, 40, 100, 6 },
                    { 22, "Ataque com uma bola de fogo que pode queimar o oponente.", "Fire Blast", 5, 110, 85, 6 },
                    { 23, "Aumenta o Ataque a cada turno que é atingido.", "Rage", 20, 20, 100, 12 },
                    { 24, "Foge da batalha selvagem ou de uma batalha de treinador.", "Teleport", 20, 0, 100, 14 },
                    { 25, "Ataque fantasma que causa dano igual ao nível do usuário.", "Night Shade", 15, 0, 100, 8 },
                    { 26, "Copia a última habilidade usada pelo oponente.", "Mimic", 10, 0, 100, 12 },
                    { 27, "Reduz a Defesa do oponente.", "Screech", 40, 0, 85, 12 },
                    { 28, "Aumenta a evasão do usuário.", "Double Team", 15, 0, 100, 12 },
                    { 29, "Recupera metade dos pontos de vida do usuário.", "Recover", 10, 0, 100, 12 },
                    { 30, "Aumenta a Defesa do usuário.", "Harden", 30, 0, 100, 12 },
                    { 31, "Aumenta a evasão do usuário.", "Minimize", 20, 0, 100, 12 },
                    { 32, "Reduz a precisão do oponente.", "Smokescreen", 20, 0, 100, 12 },
                    { 33, "Confunde o oponente.", "Confuse Ray", 10, 0, 100, 8 },
                    { 34, "Aumenta a Defesa do usuário.", "Withdraw", 40, 0, 100, 17 },
                    { 35, "Aumenta a Defesa do usuário.", "Barrier", 20, 0, 100, 14 },
                    { 36, "Reduz o dano de ataques especiais do oponente.", "Light Screen", 30, 0, 100, 14 },
                    { 37, "Remove todas as alterações de status.", "Haze", 30, 0, 100, 11 },
                    { 38, "Reduz o dano de ataques físicos do oponente.", "Reflect", 20, 0, 100, 14 },
                    { 39, "Atira pedras no oponente. Pode reduzir a velocidade do oponente.", "Rock Tomb", 15, 60, 95, 15 },
                    { 40, "Aumenta a Defesa do usuário.", "Defense Curl", 40, 0, 100, 12 },
                    { 41, "Aumenta a chance de acerto crítico.", "Focus Energy", 30, 0, 100, 12 },
                    { 42, "Guarda energia por 2 a 3 turnos e depois ataca.", "Bide", 10, 0, 100, 12 },
                    { 43, "Usa um ataque aleatório.", "Metronome", 10, 0, 100, 12 },
                    { 44, "Copia o último ataque usado pelo oponente.", "Mirror Move", 20, 0, 100, 7 },
                    { 45, "Causa dano ao usuário e ao oponente.", "Self-Destruct", 5, 200, 100, 12 },
                    { 46, "Atira ovos no oponente.", "Egg Bomb", 10, 100, 75, 12 },
                    { 47, "Ataque com a língua. Pode paralisar o oponente.", "Lick", 30, 20, 100, 8 },
                    { 48, "Ataque de fumaça venenosa. Pode envenenar o oponente.", "Smog", 20, 30, 70, 13 },
                    { 49, "Ataque de lodo venenoso. Pode envenenar o oponente.", "Sludge", 20, 65, 100, 13 },
                    { 50, "Ataque com um osso. Pode causar acerto crítico.", "Bone Club", 20, 65, 85, 10 },
                    { 51, "Ataque de soco em chamas. Pode queimar o oponente.", "Fire Punch", 15, 75, 100, 6 },
                    { 52, "Ataque de soco congelante. Pode congelar o oponente.", "Ice Punch", 15, 75, 100, 11 },
                    { 53, "Ataque de soco elétrico. Pode paralisar o oponente.", "Thunder Punch", 15, 75, 100, 3 },
                    { 54, "Causa 40 pontos de dano.", "Dragon Rage", 10, 40, 100, 2 },
                    { 55, "Prende o oponente por 2 a 5 turnos.", "Bind", 20, 15, 85, 12 }
                });

            migrationBuilder.InsertData(
                table: "TB_POKEMONS",
                columns: new[] { "Id", "Altura", "Genero", "Nome", "Peso", "Tipo" },
                values: new object[,]
                {
                    { 1, 0.69999999999999996, "", "Bulbasaur", 6.9000000000000004, "[9,13]" },
                    { 2, 1.0, "", "Ivysaur", 13.0, "[9,13]" },
                    { 3, 2.0, "", "Venusaur", 100.0, "[9,13]" },
                    { 4, 0.59999999999999998, "", "Charmander", 8.5, "[6]" },
                    { 5, 1.1000000000000001, "", "Charmeleon", 19.0, "[6]" },
                    { 6, 1.7, "", "Charizard", 90.5, "[6,7]" },
                    { 7, 0.5, "", "Squirtle", 9.0, "[17]" },
                    { 8, 1.0, "", "Wartortle", 22.5, "[17]" },
                    { 9, 1.6000000000000001, "", "Blastoise", 85.5, "[17]" },
                    { 10, 0.29999999999999999, "", "Caterpie", 2.8999999999999999, "[0]" },
                    { 11, 0.69999999999999996, "", "Metapod", 9.9000000000000004, "[0]" },
                    { 12, 1.1000000000000001, "", "Butterfree", 32.0, "[0,7]" },
                    { 13, 0.29999999999999999, "", "Weedle", 3.2000000000000002, "[0,13]" },
                    { 14, 0.59999999999999998, "", "Kakuna", 10.0, "[0,13]" },
                    { 15, 1.0, "", "Beedrill", 29.5, "[0,13]" },
                    { 16, 0.29999999999999999, "", "Pidgey", 1.8, "[12,7]" },
                    { 17, 1.1000000000000001, "", "Pidgeotto", 30.0, "[12,7]" },
                    { 18, 1.5, "", "Pidgeot", 39.5, "[12,7]" },
                    { 19, 0.29999999999999999, "", "Rattata", 3.5, "[12]" },
                    { 20, 0.69999999999999996, "", "Raticate", 18.5, "[12]" },
                    { 21, 0.29999999999999999, "", "Spearow", 2.0, "[12,7]" },
                    { 22, 1.2, "", "Fearow", 38.0, "[12,7]" },
                    { 23, 2.0, "", "Ekans", 6.9000000000000004, "[13]" },
                    { 24, 3.5, "", "Arbok", 65.0, "[13]" },
                    { 25, 0.40000000000000002, "", "Pikachu", 6.0, "[3]" },
                    { 26, 0.80000000000000004, "", "Raichu", 30.0, "[3]" },
                    { 27, 0.59999999999999998, "", "Sandshrew", 12.0, "[10]" },
                    { 28, 1.0, "", "Sandslash", 29.5, "[10]" },
                    { 29, 0.40000000000000002, "", "Nidoran♀", 7.0, "[13]" },
                    { 30, 0.80000000000000004, "", "Nidorina", 20.0, "[13]" },
                    { 31, 1.3, "", "Nidoqueen", 60.0, "[13,10]" },
                    { 32, 0.5, "", "Nidoran♂", 9.0, "[13]" },
                    { 33, 0.90000000000000002, "", "Nidorino", 19.5, "[13]" },
                    { 34, 1.3999999999999999, "", "Nidoking", 62.0, "[13,10]" },
                    { 35, 0.59999999999999998, "", "Clefairy", 7.5, "[4]" },
                    { 36, 1.3, "", "Clefable", 40.0, "[4]" },
                    { 37, 0.59999999999999998, "", "Vulpix", 9.9000000000000004, "[6]" },
                    { 38, 1.1000000000000001, "", "Ninetales", 19.899999999999999, "[6]" },
                    { 39, 0.5, "", "Jigglypuff", 5.5, "[12,4]" },
                    { 40, 1.0, "", "Wigglytuff", 12.0, "[12,4]" },
                    { 41, 0.80000000000000004, "", "Zubat", 7.5, "[7,13]" },
                    { 42, 1.6000000000000001, "", "Golbat", 55.0, "[7,13]" },
                    { 43, 0.5, "", "Oddish", 5.4000000000000004, "[9,13]" },
                    { 44, 0.80000000000000004, "", "Gloom", 8.5999999999999996, "[9,13]" },
                    { 45, 1.2, "", "Vileplume", 18.600000000000001, "[9,13]" },
                    { 46, 0.29999999999999999, "", "Paras", 5.4000000000000004, "[0,9]" },
                    { 47, 1.0, "", "Parasect", 29.5, "[0,9]" },
                    { 48, 1.0, "", "Venonat", 30.0, "[0,13]" },
                    { 49, 1.5, "", "Venomoth", 12.5, "[0,13]" },
                    { 50, 0.20000000000000001, "", "Diglett", 0.80000000000000004, "[10]" },
                    { 51, 0.69999999999999996, "", "Dugtrio", 33.299999999999997, "[10]" },
                    { 52, 0.40000000000000002, "", "Meowth", 4.2000000000000002, "[12]" },
                    { 53, 1.0, "", "Persian", 32.0, "[12]" },
                    { 54, 0.80000000000000004, "", "Psyduck", 19.600000000000001, "[17]" },
                    { 55, 1.7, "", "Golduck", 76.599999999999994, "[17]" },
                    { 56, 0.5, "", "Mankey", 28.0, "[5]" },
                    { 57, 1.0, "", "Primeape", 32.0, "[5]" },
                    { 58, 0.69999999999999996, "", "Growlithe", 19.0, "[6]" },
                    { 59, 1.8999999999999999, "", "Arcanine", 155.0, "[6]" },
                    { 60, 0.59999999999999998, "", "Poliwag", 12.4, "[17]" },
                    { 61, 1.0, "", "Poliwhirl", 20.0, "[17]" },
                    { 62, 1.3, "", "Poliwrath", 54.0, "[17,5]" },
                    { 63, 0.90000000000000002, "", "Abra", 19.5, "[14]" },
                    { 64, 1.3, "", "Kadabra", 56.5, "[14]" },
                    { 65, 1.5, "", "Alakazam", 48.0, "[14]" },
                    { 66, 0.80000000000000004, "", "Machop", 19.5, "[5]" },
                    { 67, 1.5, "", "Machoke", 70.5, "[5]" },
                    { 68, 1.6000000000000001, "", "Machamp", 130.0, "[5]" },
                    { 69, 0.69999999999999996, "", "Bellsprout", 4.0, "[9,13]" },
                    { 70, 1.0, "", "Weepinbell", 6.4000000000000004, "[9,13]" },
                    { 71, 1.7, "", "Victreebel", 15.5, "[9,13]" },
                    { 72, 0.90000000000000002, "", "Tentacool", 45.5, "[17,13]" },
                    { 73, 1.6000000000000001, "", "Tentacruel", 55.0, "[17,13]" },
                    { 74, 0.40000000000000002, "", "Geodude", 20.0, "[15,10]" },
                    { 75, 1.0, "", "Graveler", 105.0, "[15,10]" },
                    { 76, 1.3999999999999999, "", "Golem", 300.0, "[15,10]" },
                    { 77, 1.0, "", "Ponyta", 30.0, "[6]" },
                    { 78, 1.7, "", "Rapidash", 95.0, "[6]" },
                    { 79, 1.2, "", "Slowpoke", 36.0, "[17,14]" },
                    { 80, 1.6000000000000001, "", "Slowbro", 78.5, "[17,14]" },
                    { 81, 0.29999999999999999, "", "Magnemite", 6.0, "[3,16]" },
                    { 82, 1.0, "", "Magneton", 60.0, "[3,16]" },
                    { 83, 0.80000000000000004, "", "Farfetch'd", 15.0, "[12,7]" },
                    { 84, 1.3999999999999999, "", "Doduo", 39.200000000000003, "[12,7]" },
                    { 85, 1.8, "", "Dodrio", 85.200000000000003, "[12,7]" },
                    { 86, 1.1000000000000001, "", "Seel", 90.0, "[17]" },
                    { 87, 1.7, "", "Dewgong", 120.0, "[17,11]" },
                    { 88, 0.90000000000000002, "", "Grimer", 30.0, "[13]" },
                    { 89, 1.2, "", "Muk", 30.0, "[13]" },
                    { 90, 0.29999999999999999, "", "Shellder", 4.0, "[17]" },
                    { 91, 1.5, "", "Cloyster", 132.5, "[17,11]" },
                    { 92, 1.3, "", "Gastly", 0.10000000000000001, "[8,13]" },
                    { 93, 1.6000000000000001, "", "Haunter", 0.10000000000000001, "[8,13]" },
                    { 94, 1.5, "", "Gengar", 40.5, "[8,13]" },
                    { 95, 8.8000000000000007, "", "Onix", 210.0, "[15,10]" },
                    { 96, 1.0, "", "Drowzee", 32.399999999999999, "[14]" },
                    { 97, 1.6000000000000001, "", "Hypno", 75.599999999999994, "[14]" },
                    { 98, 0.40000000000000002, "", "Krabby", 6.5, "[17]" },
                    { 99, 1.3, "", "Kingler", 60.0, "[17]" },
                    { 100, 0.5, "", "Voltorb", 10.4, "[3]" },
                    { 101, 1.2, "", "Electrode", 66.599999999999994, "[3]" },
                    { 102, 0.40000000000000002, "", "Exeggcute", 2.5, "[9,14]" },
                    { 103, 2.0, "", "Exeggutor", 120.0, "[9,14]" },
                    { 104, 0.40000000000000002, "", "Cubone", 6.5, "[10]" },
                    { 105, 1.0, "", "Marowak", 45.0, "[10]" },
                    { 106, 1.5, "", "Hitmonlee", 49.799999999999997, "[5]" },
                    { 107, 1.3999999999999999, "", "Hitmonchan", 50.200000000000003, "[5]" },
                    { 108, 1.2, "", "Lickitung", 65.5, "[12]" },
                    { 109, 0.59999999999999998, "", "Koffing", 1.0, "[13]" },
                    { 110, 1.2, "", "Weezing", 9.5, "[13]" },
                    { 111, 1.0, "", "Rhyhorn", 115.0, "[10,15]" },
                    { 112, 1.8999999999999999, "", "Rhydon", 120.0, "[10,15]" },
                    { 113, 1.1000000000000001, "", "Chansey", 34.600000000000001, "[12]" },
                    { 114, 1.0, "", "Tangela", 35.0, "[9]" },
                    { 115, 2.2000000000000002, "", "Kangaskhan", 80.0, "[12]" },
                    { 116, 0.40000000000000002, "", "Horsea", 8.0, "[17]" },
                    { 117, 1.2, "", "Seadra", 25.0, "[17]" },
                    { 118, 0.59999999999999998, "", "Goldeen", 15.0, "[17]" },
                    { 119, 1.3, "", "Seaking", 39.0, "[17]" },
                    { 120, 0.80000000000000004, "", "Staryu", 34.5, "[17]" },
                    { 121, 1.1000000000000001, "", "Starmie", 80.0, "[17,14]" },
                    { 122, 1.3, "", "Mr. Mime", 54.5, "[14]" },
                    { 123, 1.5, "", "Scyther", 56.0, "[0,7]" },
                    { 124, 1.3999999999999999, "", "Jynx", 40.600000000000001, "[11,14]" },
                    { 125, 1.1000000000000001, "", "Electabuzz", 30.0, "[3]" },
                    { 126, 1.3, "", "Magmar", 44.5, "[6]" },
                    { 127, 1.5, "", "Pinsir", 55.0, "[0]" },
                    { 128, 1.3999999999999999, "", "Tauros", 88.400000000000006, "[12]" },
                    { 129, 0.90000000000000002, "", "Magikarp", 10.0, "[17]" },
                    { 130, 6.5, "", "Gyarados", 235.0, "[17,7]" },
                    { 131, 2.5, "", "Lapras", 220.0, "[17,11]" },
                    { 132, 0.29999999999999999, "", "Ditto", 4.0, "[12]" },
                    { 133, 0.29999999999999999, "", "Eevee", 6.5, "[12]" },
                    { 134, 1.0, "", "Vaporeon", 29.0, "[17]" },
                    { 135, 0.80000000000000004, "", "Jolteon", 24.5, "[3]" },
                    { 136, 0.90000000000000002, "", "Flareon", 25.0, "[6]" },
                    { 137, 0.80000000000000004, "", "Porygon", 36.5, "[12]" },
                    { 138, 0.40000000000000002, "", "Omanyte", 7.5, "[15,17]" },
                    { 139, 1.0, "", "Omastar", 35.0, "[15,17]" },
                    { 140, 0.5, "", "Kabuto", 11.5, "[15,17]" },
                    { 141, 1.3, "", "Kabutops", 40.5, "[15,17]" },
                    { 142, 1.8, "", "Aerodactyl", 59.0, "[15,7]" },
                    { 143, 2.1000000000000001, "", "Snorlax", 460.0, "[12]" },
                    { 144, 1.7, "", "Articuno", 55.399999999999999, "[11,7]" },
                    { 145, 1.6000000000000001, "", "Zapdos", 52.600000000000001, "[3,7]" },
                    { 146, 2.0, "", "Moltres", 60.0, "[6,7]" },
                    { 147, 1.8, "", "Dratini", 3.2999999999999998, "[2]" },
                    { 148, 4.0, "", "Dragonair", 16.5, "[2]" },
                    { 149, 2.2000000000000002, "", "Dragonite", 210.0, "[2,7]" },
                    { 150, 2.0, "", "Mewtwo", 122.0, "[14]" },
                    { 151, 0.40000000000000002, "", "Mew", 4.0, "[14]" }
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

            migrationBuilder.InsertData(
                table: "TB_TREINADORES_POKEMONS",
                columns: new[] { "PokemonId", "TreinadorId", "Ataque", "Defesa", "Habilidade1Id", "Habilidade2Id", "Habilidade3Id", "Habilidade4Id", "Nivel", "Velocidade", "Vida" },
                values: new object[,]
                {
                    { 74, 1, null, null, 1, 40, null, null, 12, null, null },
                    { 95, 1, null, null, 1, 30, 54, 39, 14, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_TREINADORES_POKEMONS_PokemonId",
                table: "TB_TREINADORES_POKEMONS",
                column: "PokemonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_TREINADORES_POKEMONS");

            migrationBuilder.DropTable(
                name: "TB_POKEMONS");

            migrationBuilder.DropTable(
                name: "TB_TREINADORES");
        }
    }
}
