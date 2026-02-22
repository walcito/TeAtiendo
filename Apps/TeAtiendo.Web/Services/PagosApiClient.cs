using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TeAtiendo.Application.DTOs;

namespace TeAtiendo.Web.Services
{
    public class PagosApiClient
    {
        private readonly HttpClient _http;

        public PagosApiClient(HttpClient http)
        {
            _http = http;
        }

       // public async Task<PagoDto?> PagarAsync(PagoCreateRequest request)
        //    var res = await _http.PostAsJsonAsync(""api/pagos"", request);
          //  return await res.Content.ReadFromJsonAsync<PagoDto>();
       // }

        //public async Task<List<PagoDto>?> GetByOrdenAsync(int idOrden)
        //{
           // return await _http.GetFromJsonAsync<List<PagoDto>>($""api/pagos/orden/{idOrden}"");
        //}
    }
}
