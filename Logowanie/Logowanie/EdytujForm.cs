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
        private KlientApi api;
        public EdytujForm(string token)
        {
            InitializeComponent();
            this.token = token;
            api = new KlientApi(token);
        }
        private void labeledytujEmail_Click(object sender, EventArgs e)
        {
            using HttpClient klient = new HttpClient();
            klient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            try
            {

            }
            catch 
            {

            }
        }

        private async void EdytujForm_Load(object sender, EventArgs e)
        {
            Uzytkownik uzytkownik = await api.PobierzProfil();
            labelAktualnaNazwa.Text = $"Aktualna nazwa uzytkownika: {uzytkownik.NazwaUzytkownika}";
            labelAktualneBio.Text = $"Aktualne Bio: {uzytkownik.Bio}";
        }

        private void buttonEdytujBio_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdytujNazwe_Click(object sender, EventArgs e)
        {

        }
    }
}
