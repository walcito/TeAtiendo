using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TeAtiendo.Application.DTOs;

namespace TeAtiendo.Web.Services
{
    public class OrdenesApiClient
    {
        private readonly HttpClient _http;

        public OrdenesApiClient(HttpClient http)
        {
            _http = http;
        }

        //public async Task<OrdenDto?> CrearAsync(OrdenCreateRequest request)
        //{
           // var res = await _http.PostAsJsonAsync(""api/ordenes"", request);
           // return await res.Content.ReadFromJsonAsync<OrdenDto>();
      //}

       // public async Task<List<OrdenDto>?> GetByUsuarioAsync(int idUsuario)
       // {
           // return await _http.GetFromJsonAsync<List<OrdenDto>>($""api/ordenes/usuario/{idUsuario}"");
       // }
    }
}
