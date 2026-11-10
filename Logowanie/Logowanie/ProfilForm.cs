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
        private async void ProfilForm_Load(object sender, EventArgs e)
        {
            Uzytkownik uzytkownik = await api.PobierzProfil();
            materialListView1.Columns.Clear();
            materialListView1.Items.Clear();

            // 2. Dodawanie kolumn (Nazwa kolumny, Szerokość w pikselach, Wyrównanie tekstu)
            materialListView1.Columns.Add("", 200, HorizontalAlignment.Left);
            materialListView1.Columns.Add("", 500, HorizontalAlignment.Left);

            // 3. Tworzenie i dodawanie wierszy z danymi
            ListViewItem row1 = new ListViewItem("Email:");
            row1.SubItems.Add(uzytkownik.Email);
            ListViewItem row2 = new ListViewItem("Nazwa uzytkownika:");
            row2.SubItems.Add(uzytkownik.NazwaUzytkownika);
            ListViewItem row3 = new ListViewItem("Bio:");
            row3.SubItems.Add(uzytkownik.Bio);

            // 4. Wrzucenie gotowych wierszy do tabeli
            materialListView1.Items.AddRange(new ListViewItem[] { row1, row2, row3 });
        }


        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            EdytujForm edytujForm = new EdytujForm(token);
            this.Close();
            edytujForm.ShowDialog();
            this.Show();
        }

        private async void buttonWyloguj_Click_1(object sender, EventArgs e)
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

        private void usunButton_Click(object sender, EventArgs e)
        {
            UsuwanieProfilu usunForm = new UsuwanieProfilu(token);
            this.Close();
            usunForm.ShowDialog();
            this.Show();
        }
    }
}
