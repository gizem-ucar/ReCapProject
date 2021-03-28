using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string BrandNameInvalid = "Marka adı geçersiz";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string RentalCar = "Araç kiralandı";
        public static string RentalCarInvalid = "Araç kiralanamaz.Araç teslim edilmedi.";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdate = "Araç güncellendi.";
        public static string CarUpdateInvalid = "Araç güncellenemedi.";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string CarImageLimitExceeded { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static User PasswordError { get; internal set; }
        public static User UserNotFound { get; internal set; }
        public static string UserRegistered { get; internal set; }
    }
}
