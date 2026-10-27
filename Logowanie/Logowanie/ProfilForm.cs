using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.ApplicationServices;

namespace Logowanie
{
    public partial class ProfilForm : Form
    {
        private string token;
        private KlientApi api;
        public ProfilForm(string token)
        {
            InitializeComponent();
            this.token = token;
            api = new KlientApi(token);
        }
        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelBio_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            EdytujForm edytujForm = new EdytujForm(token);
            this.Hide();
            edytujForm.ShowDialog();
            this.Show();
        }

        private async void ProfilForm_Load(object sender, EventArgs e)
        {
            Uzytkownik uzytkownik = await api.PobierzProfil();

            labelPobranaNazwa.Text = uzytkownik.NazwaUzytkownika;
            labelPobranyEmail.Text = uzytkownik.Email;
            labelPobraneBio.Text = uzytkownik.Bio;
        }

        private async void buttonWyloguj_Click(object sender, EventArgs e)
        {
            using HttpClient klient = new HttpClient();
            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            {
                HttpResponseMessage odpowiedzApi = await klient.PostAsync("https://api.54-36-162-208.sslip.io/api/auth/logout", null);
                string wynik = await odpowiedzApi.Content.ReadAsStringAsync();
                if (!odpowiedzApi.IsSuccessStatusCode)
                {
                    throw new Exception("Nie udało się wylogować: " + wynik);
                }
                else
                {
                    MessageBox.Show("Wylogowano pomyślnie.");
                    this.Close();
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }
    }
}
