using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Logowanie
{
    public partial class EdytujForm : Form
    {
        private string token;
        private KlientApi api;
        public EdytujForm(string token)
        {
            InitializeComponent();
            this.token = token;
            api = new KlientApi(token);
        }
        private void labeledytujEmail_Click(object sender, EventArgs e)
        {

        }

        private async void EdytujForm_Load(object sender, EventArgs e)
        {
            Uzytkownik uzytkownik = await api.PobierzProfil();
            labelAktualnaNazwa.Text = uzytkownik.NazwaUzytkownika;
            labelAktualneBio.Text = uzytkownik.Bio;
        }

        private async void buttonEdytujBio_Click(object sender, EventArgs e)
        {
            using HttpClient klient = new HttpClient();
            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var dane = new
            {
                bio = textBoxBio.Text,
            };
            string daneJson = JsonSerializer.Serialize(dane);
            using StringContent zawartosc = new StringContent(daneJson, Encoding.UTF8, "application/json");


            try
            {
                HttpResponseMessage odpowiedzApi = await klient.PatchAsync("https://api.54-36-162-208.sslip.io/api/auth/me", zawartosc);
                string wynik = await odpowiedzApi.Content.ReadAsStringAsync();
                if (odpowiedzApi.IsSuccessStatusCode)
                {
                    OdpowiedzNaLogowanie odpowiedz = JsonSerializer.Deserialize<OdpowiedzNaLogowanie>(wynik);

                    Uzytkownik uzytkownik = odpowiedz.Uzytkownik;
                    labelAktualneBio.Text = uzytkownik.Bio;
                }
                else
                {
                    MessageBox.Show("Nie udało się zmienić bio: " + wynik);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message);
            }
        }

        private async void buttonEdytujNazwe_Click(object sender, EventArgs e)
        {
            using HttpClient klient = new HttpClient();
            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var dane = new
            {
                displayName = textBoxNazwa.Text,
            };

            string daneJson = JsonSerializer.Serialize(dane);
            using StringContent zawartosc = new StringContent(daneJson, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage odpowiedzApi = await klient.PatchAsync("https://api.54-36-162-208.sslip.io/api/auth/me", zawartosc);
                string wynik = await odpowiedzApi.Content.ReadAsStringAsync();
                if (odpowiedzApi.IsSuccessStatusCode)
                {
                    OdpowiedzNaLogowanie odpowiedz = JsonSerializer.Deserialize<OdpowiedzNaLogowanie>(wynik);

                    Uzytkownik uzytkownik = odpowiedz.Uzytkownik;
                    labelAktualnaNazwa.Text = uzytkownik.NazwaUzytkownika;
                }
                else
                {
                    MessageBox.Show("Nie udało się zmienić nazwy: " + wynik);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message);
            }
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
