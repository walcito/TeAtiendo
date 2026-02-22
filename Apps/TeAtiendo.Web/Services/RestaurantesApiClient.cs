using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TeAtiendo.Application.DTOs;

namespace TeAtiendo.Web.Services
{
    public class RestaurantesApiClient
    {
        private readonly HttpClient _http;

        public RestaurantesApiClient(HttpClient http)
        {
            _http = http;
        }

       // public async Task<List<RestauranteDto>?> GetAllAsync()
      //  {
            //return await _http.GetFromJsonAsync<List<RestauranteDto>>(""api/restaurantes"");
      //  }
    }
}
