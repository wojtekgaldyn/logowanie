using System.Net.Http;
using System.Text;
using System.Text.Json;

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
            using HttpClient client = new HttpClient();

            var dane = new
            {
                login = textBoxLogin.Text,
                haslo = textBoxHaslo.Text,
            };

            string json = JsonSerializer.Serialize(dane);
        }
    }
}
