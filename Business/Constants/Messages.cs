using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string DailyPriceİnvalid = "Günlük Fiyat Sıfırdan Büyük Olmalı";
        public static string Descriptionİnvalid = "En az iki karakter girmelisin";
        public static string CarListed="Arabalar Listelendi";
        public static string ListError="Listelenemedi.Sistem Bakımda";
        public static string CarDeleted="Silindi";
        public static string CarUpdate="Güncellendi";
        public static string ColorAdded="Renk Eklendi";
        public static string BrandAdded="Marka Eklendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renk Listelelendi";
        public static string BrandListed = "Marka Listelendi";
        internal static string CustomerAdded="Kullanıcı Eklendi";
        internal static string Added="Eklendi";
        internal static string Deleted="Silindi";
        internal static string Updated="Güncellendi";
        internal static string RentInvalid="Kiralama Başarısız";
        internal static string ReturnDate="Araç Teslim Edilmemiş";

        public static string CarImageAdded { get; internal set; }
        public static string ImagesLimit { get; internal set; }
    }
}
