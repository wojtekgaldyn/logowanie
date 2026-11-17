using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Logowanie
{
    public partial class UsuwanieProfilu : Form
    {
        private string token;
        private KlientApi api;
        public UsuwanieProfilu(string token)
        {
            InitializeComponent();
            this.token = token;
            api = new KlientApi(token);
        }


        private void UsuwanieProfilu_Load(object sender, EventArgs e)
        {
        }

        private async void usunProfilButton_Click(object sender, EventArgs e)
        {
            using HttpClient klient = new HttpClient();
            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var dane = new
            {
                password = usunTextBox.Text,
            };
            string daneJson = JsonSerializer.Serialize(dane);
            using var zawartoscZapytania = new StringContent(daneJson, Encoding.UTF8, "application/json");
            try
            {
                using var zapytanie = new HttpRequestMessage(HttpMethod.Delete, "https://api.54-36-162-208.sslip.io/api/auth/me");

                zapytanie.Content = zawartoscZapytania;

                HttpResponseMessage odpowiedzApi = await klient.SendAsync(zapytanie);

                string wynik = await odpowiedzApi.Content.ReadAsStringAsync();

                if (odpowiedzApi.IsSuccessStatusCode)
                {
                    MessageBox.Show("Konto zostało usunięte.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Błąd: " + wynik);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message);
            }
        }

        private void wrocButton_Click(object sender, EventArgs e)
        {
            var profilForm = new ProfilForm(token);
            this.Close();
            profilForm.ShowDialog();
            this.Show();
        }
    }
}
