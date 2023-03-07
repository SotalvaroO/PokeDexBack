
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PokeDexBack.Infrastructure.Contracts;
using PokeDexBack.Infrastructure.Models;
using System;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Json;

namespace PokeDexBack.Infrastructure.Clients
{
    public class BaseHttpClient<T> : IApiClient<T> where T : class
    {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;
        private readonly ApiSettings _url;

        public BaseHttpClient(IHttpClientFactory httpClientFactory, IOptions<ApiSettings> url)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient();
            _url = new ApiSettings() { UrlString = "https://pokeapi.co/api/v2/" };  //TODO: revisar que sucedió con la inyección de dependencias, porque no está trayendo el valor del string
        }

        public async Task<T> GetAsync(int offset = 0, int pageSize = 20, string endpoint = "")
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync($"{_url.UrlString}{endpoint}?limit={pageSize}&offset={offset}"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<T>(apiResponse);
                    return data;
                }
                return null;
            }
        }
    }
}
