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
                haslo = textBoxHaslo.Text,
            };

            string daneJson = JsonSerializer.Serialize(dane);
            using var zawartoscZapytania = new StringContent(daneJson, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await klient.PostAsync("https://api.54-36-162-208.sslip.io/api/auth/login", zawartoscZapytania);
                string wynik =await response.Content.ReadAsStringAsync();
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
    }
}
