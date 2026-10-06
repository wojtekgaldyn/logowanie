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
    public partial class EdytujForm : Form
    {
        private string token;
        public EdytujForm(string token)
        {
            InitializeComponent();
            this.token = token;
            PobierzProfil();
        }
        private async void PobierzProfil()
        {
            using HttpClient klient = new HttpClient();
            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            {
                HttpResponseMessage odpowiedzApi = await klient.GetAsync("http://localhost:3000/api/auth/me");
                string wynik = await odpowiedzApi.Content.ReadAsStringAsync();
                if (odpowiedzApi.IsSuccessStatusCode)
                {
                    OdpowiedzNaLogowanie odpowiedzNaPobranie = JsonSerializer.Deserialize<OdpowiedzNaLogowanie>(wynik);
                    Uzytkownik uzytkownik = odpowiedzNaPobranie.Uzytkownik;

                    labelAktualnaNazwa.Text = $"Aktualna nazwa: {uzytkownik.NazwaUzytkownika}";
                    labelAktualneBio.Text = $"Aktualne Bio: {uzytkownik.Bio}";
                }
                else
                {
                    MessageBox.Show("Nie udalo sie pobrac profilu" + wynik);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Blad polaczenia" + ex.Message);
            }
        }
        private void labeledytujEmail_Click(object sender, EventArgs e)
        {
            using HttpClient klient = new HttpClient();
            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        private void EdytujForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdytujBio_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdytujNazwe_Click(object sender, EventArgs e)
        {

        }
    }
}
