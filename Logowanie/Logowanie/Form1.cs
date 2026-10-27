using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Logowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonLogowanie_Click(object sender, EventArgs e)
        {
            using HttpClient klient = new HttpClient();
            var dane = new
            {
                email = textBoxEmail.Text,
                password = textBoxHaslo.Text,
            };

            string daneJson = JsonSerializer.Serialize(dane);
            using var zawartoscZapytania = new StringContent(daneJson, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await klient.PostAsync("https://api.54-36-162-208.sslip.io/api/auth/login", zawartoscZapytania);
                string wynik = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    OdpowiedzNaLogowanie odpowiedzNaLogowanie = JsonSerializer.Deserialize<OdpowiedzNaLogowanie>(wynik);
                    string token = odpowiedzNaLogowanie.Token;
                    var profilForm = new ProfilForm(token);
                    this.Hide();
                    profilForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Niezalogowano" + wynik);
                }
            }

            catch (HttpRequestException ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonRejestracja_Click(object sender, EventArgs e)
        {
            string email = textBoxEmailRejestracja.Text.Trim();
            string haslo = textBoxHasloRejestracja.Text;
            string nazwa = textBoxNazwaRejestracja.Text.Trim();

            if (email == "" || haslo == "" || nazwa == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola.");
                return;
            }

            var dane = new
            {
                email = email,
                password = haslo,
                displayName = nazwa
            };

            string daneJson = JsonSerializer.Serialize(dane);
            using HttpClient klient = new HttpClient();
            using StringContent zawartosc = new StringContent(daneJson, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage odpowiedz = await klient.PostAsync("https://api.54-36-162-208.sslip.io/api/auth/register", zawartosc);
                string wynik = await odpowiedz.Content.ReadAsStringAsync();
                if (odpowiedz.IsSuccessStatusCode)
                {
                    MessageBox.Show("Konto zostało utworzone! Możesz się teraz zalogować.");
                }
                else
                {
                    MessageBox.Show("Rejestracja nie powiodła się.\n" +"Kod HTTP: " + (int)odpowiedz.StatusCode +"\n" + wynik);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Nie udało się połączyć z API:\n" + ex.Message);
            }
        }
    }
}
