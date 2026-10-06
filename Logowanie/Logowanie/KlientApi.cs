using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Headers;
using System.Text.Json;
namespace Logowanie
{
    public class KlientApi
    {
        private readonly HttpClient klient;
        private readonly string token;

        public KlientApi(string token)
        {
            this.token = token;
            klient = new HttpClient();

            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
        public async Task<Uzytkownik> PobierzProfil()
        {
            HttpResponseMessage odpowiedzApi = await klient.GetAsync("http://localhost:3000/api/auth/me");
            string wynik = await odpowiedzApi.Content.ReadAsStringAsync();
            if (!odpowiedzApi.IsSuccessStatusCode) {
                throw new Exception("Nie udało się pobrać profilu: " + wynik);
            }
            OdpowiedzNaLogowanie odpowiedz = JsonSerializer.Deserialize<OdpowiedzNaLogowanie>(wynik);
            return odpowiedz.Uzytkownik;
        }
    }
}
