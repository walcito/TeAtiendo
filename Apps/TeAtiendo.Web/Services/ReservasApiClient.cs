using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TeAtiendo.Application.DTOs;

namespace TeAtiendo.Web.Services
{
    public class ReservasApiClient
    {
        private readonly HttpClient _http;

        public ReservasApiClient(HttpClient http)
        {
            _http = http;
        }

        //public async Task<ReservaDto?> CrearAsync(ReservaCreateRequest request)
       // {
            //var res = await _http.PostAsJsonAsync(""api/reservas"", request);
            //return await res.Content.ReadFromJsonAsync<ReservaDto>();
       // }

        //public async Task<List<ReservaDto>?> GetByUsuarioAsync(int idUsuario)
       // {
            //return await _http.GetFromJsonAsync<List<ReservaDto>>($""api/reservas/usuario/{idUsuario}"");
      //  }
    }
}
