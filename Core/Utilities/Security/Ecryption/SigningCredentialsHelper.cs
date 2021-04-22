using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Ecryption
{
    public class SigningCredentialsHelper // Security key imzalı nesnesini dödndürecek ve bununla jwt sistemini kullanabilmiş olacağız.
        // Web apide doğrulama için hangi anahtarı kullanması gerektiğini ve ahangi algoritmayla yapması gerektiğini veriyoruz.
    {
       public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
