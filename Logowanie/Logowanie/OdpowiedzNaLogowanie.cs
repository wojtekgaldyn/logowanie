using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Logowanie
{
    internal class OdpowiedzNaLogowanie
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonPropertyName("user")]
        public Uzytkownik Uzytkownik { get; set; }
    }
}
