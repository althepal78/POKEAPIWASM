using System.Text.Json.Serialization;

namespace PokeApi.Dtos
{
    public partial class GraphQlDto
    {
        [JsonPropertyName("data")]
        public Data? Data { get; set; }
    }

    public partial class Data
    {
        [JsonPropertyName("pokemon_v2_pokemon")]
        public List<PokemonV2Pokemon>? PokemonV2Pokemon { get; set; }
    }

    public partial class PokemonV2Pokemon
    {
        [JsonPropertyName("height")]
        public float Height { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("weight")]
        public float Weight { get; set; }

        [JsonPropertyName("pokemon_v2_pokemonabilities")]
        public List<PokemonV2Pokemonability>? PokemonV2Pokemonabilities { get; set; }

        [JsonPropertyName("pokemon_v2_pokemonsprites")]
        public List<PokemonV2Pokemonsprite>? PokemonV2Pokemonsprites { get; set; }
    }

    public partial class PokemonV2Pokemonability
    {
        [JsonPropertyName("pokemon_v2_ability")]
        public PokemonV2Ability? PokemonV2Ability { get; set; }
    }

    public partial class PokemonV2Ability
    {
        [JsonPropertyName("name")]
        public string? AbilityName { get; set; }
    }

    public partial class PokemonV2Pokemonsprite
    {
        [JsonPropertyName("sprites")]
        public string? Sprites { get; set; }
    }
}
