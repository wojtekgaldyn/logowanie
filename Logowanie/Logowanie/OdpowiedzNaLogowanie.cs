using System;
using System.Collections.Generic;
using System.Text;

namespace Logowanie
{
    internal class OdpowiedzNaLogowanie
    {
        public string Token { get; set; }
        public string ExpiresAt { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
    }
}
