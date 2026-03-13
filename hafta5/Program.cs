using Microsoft.Extensions.Primitives;
using System.Text;
#region string keyword

// referans türlü olduğu halde programlama diinde bir keyword barındıran tek dil stringdir.
// Bu nedenle string türünde bir değişken tanımlarken string yerine @string kullanarak keyword'ü kaçırabiliriz.
// string esasında char türünde bir dizidir.yani charların bir araya gelmesiyle oluşan bir türdür.
// bu nedenle string türünde bir değişken tanımlarken char türünde bir dizi tanımlamış oluruz.  
// string türü bir referans türüdür. bu nedenle string türünde bir değişken tanımlarken bellekte bir alan tahsis edilir ve bu alana string türünde bir değer atanır.
// string türünde bir değişken tanımlarken null veya empty atayabiliriz. null atadığımızda ilgili değişkenin bir alan tahsis etmediği anlamına gelirken
// empty atadığımızda ilgili değişkenin bir alan tahsis ettiği ancak bu alanın boş olduğu anlamına gelir.
// string ifadeler char dizisi olduğundan dolayı indexlenebilirler. dolayısıyla string ifadelere indexer kullanabiliriz.

//Console.WriteLine(a[4]);

// string özünde bir char dizisi olabilir ama yapısal olarak hala string oldugu icin array kullanılamaz.

//for (int i = 0; i < a.Length; i++)
//{
//    if (a[i] =='k')
//        Console.WriteLine(i);

//}
// + oporatörü string bir ifadeyle herhangibi bir türü işleme tabi tutarken object + string davranışı sergiler.ve sonuc olarak geriye string değer  döndürür.
// bu nedenle string bir ifadeyle herhangi bir türü işleme tabi tutarken o türün string karşılığına bakılır ve o şekilde işleme tabi tutulur.
// eğer ki o türün string karşılığı yoksa o türün object karşılığına bakılır ve o şekilde işleme tabi tutulur.
// eğer ki o türün object karşılığı da yoksa o türün kendisi işleme tabi tutulur.

#region formatlama + opratörü string.format() metodu ve string interpolation

//int yas = 25;
//string isim = "burak", soyad="gunay" , tcno="25122319790" ;
//bool medenihal = false;

// + oparatörü
// Console.WriteLine("İsim  : "+ isim +  "    "  + "Soyad  : " + soyad + "     " + "Tc kimlik No  :"+ tcno + "      " + "Yaşı  : "+ yas + "      " +  "Medenihal  : "+ (medenihal ?"evli" : "bekar"));


//string format() metodu
// string.Format() metodu string bir ifadeyle herhangi bir türü işleme tabi tutarken object + string davranışı sergiler.ve sonuc olarak geriye string değer  döndürür.
// sırasıyla 0,1,2,3,4... şeklinde giden indexler alır ve bu indexlere karşılık gelen değerleri string ifadenin içine yerleştirir.
// Console.WriteLine(string.Format("İsim  : {0}    Soyad  : {1}     Tc kimlik No  :{2}      Yaşı  : {3}      Medenihal  : {4}", isim, soyad, tcno, yas, medenihal ? "evli" : "bekar"));


// string interpolation
// string interpolation string bir ifadeyle herhangi bir türü işleme tabi tutarken object + string davranışı sergiler.ve sonuc olarak geriye string değer  döndürür.
// string interpolation string bir ifadenin içine süslü parantezler {} içinde ilgili türün string karşılığını yerleştirir. $ işareti ile string interpolation kullanılır.
// Console.WriteLine($"İsim  : {isim}    Soyad  : {soyad}     Tc kimlik No  :{tcno}      Yaşı  : {yas}      Medenihal  : {(medenihal ? "evli" : "bekar")}");
// NOT :  ternary operatörü kullanılırken parantez içine alınmalıdır.
#endregion
#region Null 

// bir değiken nullable / referans eğer ki null alıyorsa ilgili değişkenin bir alan tahsis etmediği anlamına gelir.
// değer türlü bir değikenin null alması için nullable olması gerekir.
// int? a = null; // nullable int türünde bir değişken tanımladık ve null atadık.
// null olan bir değişkeni kullanmaya çalıştığımızda runtime hatası alırız. bu nedenle null olan bir değişkeni kullanmadan önce null olup olmadığını kontrol etmemiz gerekir.

#endregion

#region empty
// bir değişken nullable/referans eğer ki empty alıyorsa ilgili değişkenin bir alan tahsis ettiği ancak bu alanın boş olduğu anlamına gelir.
// tüm değerlere empty atayabiliriz.
// default değeri empty'dir.
// empty olan bir değişkeni kullanmaya çalıştığımızda runtime hatası almayız. bu nedenle empty olan bir değişkeni kullanmadan önce empty olup olmadığını kontrol etmemize gerek yoktur.
//int b = default;            // int türünde bir değişken tanımladık ve default atadık.
//int c = 0;                  // int türünde bir değişken tanımladık ve 0 atadık.bu defaulttur ve emptydir.
//bool b1 = false;            // bool türünde bir değişken tanımladık ve false atadık. bu defaulttur ve emptydir.

//string a = "";              // string türünde bir değişken tanımladık ve empty string atadık. bu defaulttur ve emptydir. bellekte alan tahsis edilmiştir ancak bu alan boş bir stringdir.
//string a2 = null;           // string türünde bir değişken tanımladık ve null atadık. bu defaulttur ve empty değildir. bellekte alan tahsis edilmediği anlamına gelir.
//string a3 = string.Empty;    // string türünde bir değişken tanımladık ve string.Empty atadık. "string a = "";" ile aynı anlama gelir.
#endregion



#endregion
#region isnullorEmpty
// string türünde bir değişkenin null veya empty olup olmadığını kontrol etmek için string.IsNullOrEmpty() metodunu kullanabiliriz.

//if (!string.IsNullOrEmpty(a))
//    {
//    Console.WriteLine("a değişkeni null veya empty değildir."); // yada 
//    }

//if (a != string.Empty && a is not null)
//    Console.WriteLine(a);

#endregion
#region isNullOrWhiteSpace
// string türünde bir değişkenin null, empty veya sadece boşluk karakterlerinden oluşup oluşmadığını kontrol etmek için string.IsNullOrWhiteSpace() metodunu kullanabiliriz.

//if (!string.IsNullOrWhiteSpace(a))
//   Console.WriteLine("a değişkeni null, empty veya sadece boşluk karakterlerinden oluşmamıştır.");
#endregion
#region string kaçış karakterleri
// \o null sonlandırıcı karakterdir veya veri kanallarında veri sonunu belirtmek için kullanılır.
// \n bir alt satır karakteri
// \t tab karakteri
// \r satır başı carriage return karakteri
// \a alarm/bip karakteri
// \b backspace karakteri
// \f sayfa ilerleme karakteri
// \v dikey tab karakteri
// \" çift tırnak karakteri
// \' tek tırnak karakteri
// \ backslash karakteri
// \ karakterini kaçırmak için kullanılır.kaçıs karakteridir.
#endregion
#region verbatim ve interpolated string 

//int yas = 25;
//string isim = "burak", soyad = "gunay", tcno = "25122319790";
//string mailm = @$"Merhaba {isim} {soyad},
//tc kimlik numaranız: {tcno}
//yaşınız: {yas}";
//Console.WriteLine(mailm.ToString());

#endregion
#region string fonksiyonları
//string a = "bir kar yağar ince ince";
//string üzerinde işlemler yapmaya yarayan özelliklerdir.

#region contains() metodu
// ilgili string ifadenin içinde belirli bir karakter veya karakter dizisinin olup olmadığını kontrol etmek için kullanılır. boolean değer döndürür.
// büyük küçük harf duyarlıdır. bu nedenle "kar" ifadesi "Kar" ifadesinden farklıdır.

//bool sonuc = a.Contains("kar");
//Console.WriteLine(sonuc);
#endregion
#region startsWith() metodu
// ilgili string ifadenin belirli bir karakter veya karakter dizisiyle başlayıp başlamadığını kontrol etmek için kullanılır. boolean değer döndürür.
// büyük küçük harf duyarlıdır. bu nedenle "bir" ifadesi "Bir" ifadesinden farklıdır.

//Console.WriteLine(a.StartsWith("bir"));

#endregion
#region endsWith() metodu
// verilen bir string ifadenin belirli bir karakter veya karakter dizisiyle bitip bitmediğini kontrol etmek için kullanılır. boolean değer döndürür.
// büyük küçük harf duyarlıdır. bu nedenle "ince" ifadesi "Ince" ifadesinden farklıdır.

//Console.WriteLine(a.EndsWith("ince"));

#endregion
#region equals() metodu
// verilen iki string ifadenin birbirine eşit olup olmadığını kontrol etmek için kullanılır. boolean değer döndürür.
// büyük küçük harf duyarlıdır. bu nedenle "bir kar yağar ince ince" ifadesi "Bir kar yağar ince ince" ifadesinden farklıdır.

//Console.WriteLine(a.Equals("bir kar yağar ince ince"));
#endregion
#region compare() metodu
// verilen iki string ifadeyi karşılaştırmak için kullanılır. int değer döndürür.
// eğer ki ilk string ifade ikinci string ifadeye göre daha küçükse -1 değer döndürür.
// eğer ki ilk string ifade ikinci string ifadeye göre daha büyükse 1 değer döndürür.
// eğer ki ilk string ifade ikinci string ifadeye eşitse 0 döndürür.

//Console.WriteLine(string.Compare(a, "z"));
//Console.WriteLine(string.Compare(a,a));
//Console.WriteLine(string.Compare(a, "bir"));
#endregion
#region compareTo() metodu
// verilen bir string ifadeyi başka bir string ifadeyle karşılaştırmak için kullanılır. int değer döndürür.
//Console.WriteLine(a.CompareTo("z"));
//Console.WriteLine(a.CompareTo(a));
//Console.WriteLine(a.CompareTo("bir"));
#endregion
#region indexOf() metodu
// verilen bir karakter veya karakter dizisinin string ifadenin içerisinde olup olmadığını int döndürür.
// eğer ki verilen karakter veya karakter dizisi string ifadenin içinde geçmiyorsa -1 döndürür.
// eğer ki verilen karakter veya karakter dizisi string ifadenin içinde geçiyorsa ilk harfinin indexini döndürür.
// aranan bir kelimeyse ilk harfinin indexini döndürür.

//Console.WriteLine(a.IndexOf("kar"));
#endregion
#region insert() metodu
// verilen bir string ifadeyi başka bir string ifadenin belirli bir indexine eklemek için kullanılır. string değer döndürür.
// varolan değer değişmez.ayrı bir string ifade döndürülür.
//Console.WriteLine(a.Insert(0, "hava ")); // 0 indexine "hava " ifadesini ekler ve geriye yeni bir string ifade döndürür.
#endregion
#region remove() metodu
// verilen bir string ifadenin belirli bir indexinden başlayarak belirli bir sayıda karakteri silmek için kullanılır. string değer döndürür.
// varolan değer değişmez.ayrı bir string ifade döndürülür.

//Console.WriteLine(a.Remove(0, 4)); // 0 indexinden başlayarak 4 karakteri siler ve geriye yeni bir string ifade döndürür.
//Console.WriteLine(a.Remove(5)); // 5 indexinden başlayarak sonuna kadar tüm karakterleri siler ve geriye yeni bir string ifade döndürür.

#endregion
#region replace() metodu
// verilen bir string ifadenin belirli bir karakter veya karakter dizisini başka bir karakter veya karakter dizisiyle değiştirmek için kullanılır. string değer döndürür.
// varolan değer değişmez.ayrı bir string ifade döndürülür.

//Console.WriteLine(a.Replace("kar", "güneş")); // "kar" ifadesini "güneş" ifadesiyle değiştirir ve geriye yeni bir string ifade döndürür.
//Console.WriteLine(a.Replace('k', 'g'));// 'k' karakterini 'g' karakteriyle değiştirir ve geriye yeni bir string ifade döndürür.

#endregion
#region split() metodu
// verilen bir string ifadeyi belirli bir karakter veya karakter dizisiyle bölmek için kullanılır. string[] değer döndürür.
//Console.WriteLine(a.Split(' ')[0]); // ' ' karakteriyle string ifadesini böler ve geriye string[] döndürür. [0] indexindeki değeri yazdırır.
//Console.WriteLine(a.Split('a',' ')); // 'a' ve ' ' karakterleriyle string ifadesini böler ve geriye string[] döndürür. [0] indexindeki değeri yazdırır.
#endregion
#region substring() metodu
// verilen bir string ifadenin belirli bir aralığını almak için kullanılır. string değer döndürür.

// Console.WriteLine(a.Substring(5,10));// 5 indexinden başlayarak 10 karakteri alır ve geriye yeni bir string ifade döndürür.
//Console.WriteLine(a.Substring(5)); // 5 indexinden başlayarak sonuna kadar tüm karakterleri alır ve geriye yeni bir string ifade döndürür.

#endregion
#region toLower() metodu
// verilen bir string ifadenin tüm karakterlerini küçük harfe dönüştürmek için kullanılır. string değer döndürür.
//Console.WriteLine(a.ToLower()); // tüm karakterleri küçük harfe dönüştürür ve geriye yeni bir string ifade döndürür.
#endregion
#region toUpper() metodu
// verilen bir string ifadenin tüm karakterlerini büyük harfe dönüştürmek için kullanılır. string değer döndürür.
//Console.WriteLine(a.ToUpper()); // tüm karakterleri büyük harfe dönüştürür ve geriye yeni bir string ifade döndürür.
#endregion
#region trim() metodu
// metin ifadesinin başında ve sonunda bulunan boşluk karakterlerini silmek için kullanılır. string değer döndürür.
//Console.WriteLine(a.Trim()); // metin ifadesinin başında ve sonunda bulunan boşluk karakterlerini siler ve geriye yeni bir string ifade döndürür.
//Console.WriteLine("  burak günay        ".Trim()); // metin ifadesinin başında ve sonunda bulunan boşluk karakterlerini siler ve geriye yeni bir string ifade döndürür.

#endregion
#region trimStart() metodu
// metin ifadesinin başında bulunan boşluk karakterlerini silmek için kullanılır. string değer döndürür.
//Console.WriteLine(a.TrimStart()); // metin ifadesinin başında bulunan boşluk karakterlerini siler ve geriye yeni bir string ifade döndürür.
//Console.WriteLine("  burak günay        ".TrimStart()); // metin ifadesinin sadece başında bulunan boşluk karakterlerini siler ve geriye yeni bir string ifade döndürür.
#endregion
#region trimEnd() metodu
// metin ifadesinin sonunda bulunan boşluk karakterlerini silmek için kullanılır. string değer döndürür.
//Console.WriteLine(a.TrimEnd()); // metin ifadesinin sonunda bulunan boşluk karakterlerini siler ve geriye yeni bir string ifade döndürür.
//Console.WriteLine("  burak günay        ".TrimEnd()); // metin ifadesinin sadece sonunda bulunan boşluk karakterlerini siler ve geriye yeni bir string ifade döndürür.

#endregion


#endregion
#region örnekler
// adımınızın ilkten 3 karakterini sondan 5.karakterini yazdıran bir program yazınız.

//string ad = "burak günay";

// adım 1 
//Console.WriteLine(ad[2]);
//Console.WriteLine(ad[ad.Length-5]);

// adım 2
//string aralık = ad[2..^4];
//Console.WriteLine(aralık[0]);
//Console.WriteLine(aralık[aralık.Length-1]);


// girilen metin içerisinde kaç adet n olduğunu bulan bir program yazınız.

//Console.WriteLine("bir metin giriniz");
//string metin = Console.ReadLine();
//int sayac = 0;
//for (int i = 0; i < metin.Length; i++)
//{
//    if (metin[i] == 'n')
//        sayac++;
//}
//Console.WriteLine($"Metin içerisinde {sayac} adet 'n' karakteri bulunmaktadır.");


//girilen metindeki kelime sayısını bulan bir program yazınız.

//1 .yol
//Console.WriteLine("bir metin giriniz");
//string metin = Console.ReadLine();
//string[] kelimeler = metin.Split(' ');
//Console.WriteLine($"Metin içerisinde {kelimeler.Length} adet kelime bulunmaktadır.");


//2.yol
//int sayac = 1;
//while (true)
//    {
//    int index = metin.IndexOf(' ');
//    if (index == -1)
//        break;
//    sayac++;
//    metin = metin.Substring(index + 1);
//}

//Console.WriteLine($"Metin içerisinde {sayac} adet kelime bulunmaktadır.");

#endregion
#region array segment
// bir dizinin bütününden ziyade belirli bir aralığını ulaşmamız gerekirse kopyalamak yerine bağımsız bir referans ile erişmemizi ve böylece salt bir yapı şeklinde,
// temsil etmemizi sağlayan bir yapıdır.daha hızlı bir çalışma sağlar çünkü kopyalama işlemi yapmaz. sadece referans ile erişim sağlar.
// kopyalayıp yeni bir dizi oluşturmak yerine array segment kullanarak belirli bir aralığa erişebiliriz. bu sayede bellek kullanımını azaltır ve performansı artırır.
//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int[] sayilar2 = sayilar[2..5]; // yerine ;
// ArraySegment<int> sayilar3 = new ArraySegment<int>(sayilar, 2, 3); // sayilar dizisinin 2.indexinden başlayarak 3 elemanlık bir segment oluşturur. yani 2,3,4 indexlerindeki elemanlara erişir.

// dizinin tüm elemanlarına erişmek istersek ;
//ArraySegment<int> sayilar4 = new ArraySegment<int>(sayilar); // sayilar dizisinin tüm elemanlarına erişir.
//sayilar3[0] *= 10;
//sayilar4[0] *= 10;

#endregion
#region array segment slicing (dilimleme)

// bir dizi üzerinde birden fazla parçada çalışılacaksa eğer her bir parçayı ayrı bir arraySegment olarak tanımlayabiliriz.
// bu tanımlamalar dısında diziyi tek bir arraysegment ile referans edip ilgili parçayı o segment  üzerinden talep edebiliriz.yani ilgili diziyi tek bir segment üzerinden parcalayabiliriz.

//int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//ArraySegment<int> segment = new ArraySegment<int>(sayilar);
//ArraySegment <int>segment1= segment.Slice(0, 3);
//ArraySegment<int> segment2 = segment.Slice(3, 6);// bu sekilde parcalayabiliriz.

#endregion
#region string segment
// array segmentin string için olan varyasyonudur.
// esasında metinsel değerlerdeki birçok analatik oparasyonlardan bizi kurtarmakta .
// substring vb fonksiyonlar yerine string değerde hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür.
// bu özelliği kullanabilmek için uygulamaya microsoft.extensions.primitives paketinin yüklenmesi gerekmektedir.



//string text = "bunca gamı bunca derdi mevlam yanlız bana mı verdi ";

//StringSegment segment = new StringSegment(text);
//StringSegment segment1 = new StringSegment(text, 4, 5);
//Console.WriteLine(segment1.ToString);

#endregion
#region string builder
// string birleştirme oparasyonunda + oparatörüne nazaran ,
// arkaplanda stringSegment algoritmasını kullanan ve bu algoritma ile bizlere ilgili değerleri en az maliyetle birleştirip döndüren bir sınıftır.
//string isim = "burak", soyisim = "gunay";

//StringBuilder builder = new StringBuilder();
//builder.Append(isim);
//builder.Append(" ");
//builder.Append(soyisim);
//Console.WriteLine(builder.ToString());

#endregion