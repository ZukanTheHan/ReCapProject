using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper // Kullanıcı sisteme girmek için bilgilerini verdiğinde yetkileri kontrol edilerek bir jwt oluşturulur.
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
