using System.Net.Http;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class AulaPokemon : MonoBehaviour
{
    HttpClient client= new HttpClient();
    private const string baseUrl = "https://pokeapi.co/api/v2/pokemon/pikachu";
    async void Start()
    {
        Pokemon pikachu = await GetDadosPokemon("pikachu");
        If(picachu)
        {


        }
        Pokemon Pikachu = await GetPokemon("pikachu");
        Debug.Log($"Nome :{Pikachu.name} - Peso: {Pikachu.weight}");
    }
    public async Task<Pokemon> GetPokemon(string nomePokemon)
    {
        string url = baseUrl + nomePokemon.ToLower();

        HttpResponseMessage response = await client.GetAsync(baseUrl + nomePokemon.ToLower());
        string responseJson = await response.Content.ReadAsStringAsync();
        Pokemon pokemon = JsonUtility.FromJson<Pokemon>(responseJson);
        return pokemon; 
    }
}
