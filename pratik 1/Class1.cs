using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratik_1
{
    internal class ogrenci1
    {
        public string Ad;
        public string soyad;
        public string sehir; //public olarak tanımladığımız değişkenler sınıfın her yerinden erişilebilir oluyor

        public ogrenci1(string ad, string soyad, string sehir) //constructor oluşturduk ve parametre olarak ad, soyad ve şehir aldık
        {
            Ad = ad;
            this.soyad = soyad;
            this.sehir = sehir;//constructor içinde this anahtar kelimesiyle sınıfın değişkenlerine parametre olarak aldığımız değerleri atıyoruz
        }
    }
    }


