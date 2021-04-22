using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken // Kullancının sistemde kullancağı vereceği erişim tokenı.
    {
        public string Token { get; set; } // Kullancı, adını ve şifresiyle giriş yaptığında biz ona bir token vereceğiz
        public DateTime Expiration { get; set; } // Tokenın bir kullanım süresi olacak.
    }
}
