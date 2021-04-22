using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages // static vererk newlwmwkten kurtulduk.
    {
        public static string CarAdded = "Araba başarıyla eklendi";
        public static string CarNameInValid = "Araba ismi geçersizdir.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarsListed = "Arabalar başarıyla listelendi.";
        public static string CarDeleted="Araba başarıyla silindi.";

        public static string RentalAdded="Yeni kayıt oluşturulmuştur.";
        public static string RentalRelevance="Kayıt daha önce alınmış.";
        public static string RentalDeleted="Kayıt başarıyla silindi.";
        public static string RentalUpdated="Kayıt başarıyla güncellendi.";

        public static string BrandUpdated="Marka başarıyla güncellendi.";
        public static string BrandAdded="Marka başarıyla eklendi.";
        public static string BrandRelevance="Marka daha önce eklenmiş.";

        public static string ColorAdded="Renk başarıyla eklendi.";
        public static string ColorRelevance="Renk daha önce eklenmiş.";
        public static string ColorUpdated="Renk başarıyla güncellendi.";

        public static string UserAdded="Kullanıcı başarıyla eklendi.";
        public static string UserRelevance="Kullanıcı daha önce eklenmiş.";
        public static string UserDeleted="Kullanıcı başarıyla silinmiş.";
        public static string UserUpdated="Kullanıcı başarıyla güncellenmiş.";

        public static string CustomerAdded="Müşteri başarıyla eklendi";
        public static string CustomerRelevance="Müşteri daha önce eklenmiş.";
        public static string CustomerDeleted="Müşteri başarıyla silindi.";
        public static string CustomerUpdated="Müşteri başarıyla güncellendi.";
        public static string BrandDeleted="Marka başarıyla silindi";
        public static string ColorDeleted="Renk başarıyla silindi";
        public static string CarCountOfBrandError="Bu markadan daha fazla ekleyemezsiniz";
        public static string CarAddedError="Araba eklenemedi";
        public static string CarNameAlreadyExists="Bu araba ismi daha önce kullanımış";
        public static string BrandLimitExceed="Marka limidi dolu";
        public static string AuthorizationDenied="Erişim reddedildi.";
        public static string AccessTokenCreated="Erişim tokeni oluşturuldu.";
        public static string UserAlreadyExists="Bu kullanıcı mevcut";
        public static string SuccessfulLogin="Başarıyla giriş yapıldı";
        public static User PasswordError;
        public static User UserNotFound;
        public static string UserRegistered="Kullanıcı oluşturuldu.";
    }
}
