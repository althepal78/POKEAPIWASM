using Microsoft.AspNetCore.Components;
using PokeApi.Dtos;
using System.Text;
using System.Text.Json;

namespace PokeApi.Pages
{
    public partial class GraphPoke
    {
        [Inject]
        private  HttpClient? Http { get; set; }

      


        public GraphPoke(HttpClient? http) => Http = http;


        public async Task<GraphQlDto> GetTwenty(GraphQlDto Pokemon)
        {
            var queryObj = new
            {
                query = @"{pokemon_v2_pokemon(limit:20 offset:0){height name weight pokemon_v2_pokemonabilities{pokemon_v2_ability{name}}pokemon_v2_pokemonsprites{sprites}}}"
            };

            var lauchQuery = new StringContent(
                    JsonSerializer.Serialize(queryObj),
                    Encoding.UTF8,
                    "application/json");

            var response = await Http.PostAsync("https://beta.pokeapi.co/graphql/v1beta", lauchQuery);

            if (response.IsSuccessStatusCode)
            {
                var gqlData = await JsonSerializer.DeserializeAsync<GraphQlDto>(await response.Content.ReadAsStreamAsync());
               
                Pokemon = gqlData;
                         
                return Pokemon;
            }


            return Pokemon;
        }
    }
}
