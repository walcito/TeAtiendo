using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TeAtiendo.Application.DTOs;

namespace TeAtiendo.Web.Services
{
    public class AuthApiClient
    {
        private readonly HttpClient _http;

        public AuthApiClient(HttpClient http)
        {
            _http = http;
        }

       // public async Task<AuthResult?> LoginAsync(LoginRequest request)
       // {
           // TODO: endpoint real en API
           // return await _http.PostAsJsonAsync(""api/auth/login"", request)
                             // .Result.Content.ReadFromJsonAsync<AuthResult>();
       // }

       // public async Task<AuthResult?> RegisterAsync(RegisterRequest request)
        //{
            // TODO: endpoint real en API
            //return await _http.PostAsJsonAsync(""api/auth/register"", request)
                             // .Result.Content.ReadFromJsonAsync<AuthResult>();
      //  }
    }
}
