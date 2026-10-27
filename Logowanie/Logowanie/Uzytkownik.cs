using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Logowanie
{
    public class Uzytkownik
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("email")]
        public string Email {  get; set; }

        [JsonPropertyName("displayName")]
        public string NazwaUzytkownika { get; set; }

        [JsonPropertyName("bio")]
        public string Bio {  get; set; }
    }
}
