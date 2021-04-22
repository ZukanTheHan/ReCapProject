using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Ecryption
{
    public class SecurityKeyHelper // Oluşturulan security keylerin jwt aspnet gibi sistemlerin anlayacağı dile dönüştürülmesi gerekiyor.
    {
        public static SecurityKey CreateSecurityKey (string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
