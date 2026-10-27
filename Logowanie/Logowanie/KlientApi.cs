using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Net.Http.Headers;
namespace Logowanie
{
    public class KlientApi
    {
        private readonly HttpClient klient;
        private readonly string token;

        public KlientApi(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new Exception("Token jest pusty!");
            }
            this.token = token;
            klient = new HttpClient();

            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
        public async Task<Uzytkownik> PobierzProfil()
        {
            HttpResponseMessage odpowiedzApi = await klient.GetAsync("https://api.54-36-162-208.sslip.io/api/auth/me");
            string wynik = await odpowiedzApi.Content.ReadAsStringAsync();
            if (!odpowiedzApi.IsSuccessStatusCode) {
                throw new Exception("Nie udało się pobrać profilu: " + wynik);
            }
            OdpowiedzNaLogowanie odpowiedz = JsonSerializer.Deserialize<OdpowiedzNaLogowanie>(wynik);
            return odpowiedz.Uzytkownik;
        }
    }
}
