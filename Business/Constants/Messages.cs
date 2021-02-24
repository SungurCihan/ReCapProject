using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi en az 2 karakter uzunluğunda olmalıdır.";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba bilgileri güncellendi";

        //Brand
        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi en az 2 karakter uzunluğunda olmalıdır.";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka bilgileri güncellendi";

        //Color
        public static string ColorAdded = "Renk eklendi";
        public static string ColorNameInvalid = "Renk ismi en az 2 karakter uzunluğunda olmalıdır.";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk bilgileri güncellendi";

        //User
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi";

        //Customer
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";

        //Rental
        public static string RentalAdded = "Araba kiralandı";
        public static string RentalDeleted = "Araba geri döndürüldü";
        public static string RentalUpdated = "Kiralama bilgileri güncellendi";
        public static string RentalNotReturnError = "Araba geri döndürülmemiş";

        //Company
        //User
        public static string CompanyAdded = "Şirket eklendi";
        public static string CompanyDeleted = "Şirket silindi";
        public static string CompanyUpdated = "Şirket bilgileri güncellendi";
    }
}
