using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);  // Key göre farklı değerleri döndür, liste, bir ürün vs, bir data ver. Get, getbyid, getlist gibi.

        object Get(string key); // Üstekinin alternatifi.
        void Add(string key, object value, int duration); // Cache ekliyoruz, obje değerine ve key göre, buna birde kullanım süresi atuyoruz.

        bool IsAdd(string key); // Cache daha önce eklenmiş. Buna bakıyoruz.

        void Remove(string key); // Cacheden kaldır.
        void RemoveByPattern(string pattern); // Belli bir harf dizimine sahip olanları kaldırmak için. İçinde Get olanları kaldır gibi.

    }
}
