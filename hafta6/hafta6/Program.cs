
#region span ve readonlyspan
// Span<T> ve ReadOnlySpan<T> türleri, bellek üzerinde verimli bir şekilde çalışmak için kullanılan yapılardır.
// Span<T>, bir bellek bölgesini temsil eder ve bu bölge üzerinde okuma ve yazma işlemleri yapmanıza olanak tanır.

// ReadOnlySpan<T> ise sadece okuma işlemleri için kullanılan bir yapıdır ve yazma işlemlerine izin vermez.

// int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Span<int> span = sayilar; // Span oluşturma
// Span<int> span2 = new Span<int>(sayilar);// Diğer bir Span oluşturma yöntemi
// Span<int> span3 = new Span<int>(sayilar,2,5); // sayilar dizisinin 2. indeksinden başlayarak 5 eleman içeren bir Span oluşturur.
// 2.virgülden sonra kaç adet eleman içereceği belirtilir.

// Span<int> span4 = sayilar.AsSpan();// AsSpan() metodu, bir dizi üzerinde bir Span oluşturmak için kullanılır. Bu yöntem, dizinin tamamını kapsayan bir Span oluşturur.
// Span<int> span5 = sayilar.AsSpan(2,5);//  Bu yöntem, dizinin belirli bir bölümünü kapsayan bir Span oluşturur.
//  İlk parametre başlangıç indeksini, ikinci parametre ise kaç eleman içereceğini belirtir.

// string text ="bir yıldız gibi kayar giderim hayatından";
// span methodu string türlerinde readonlyspan türünde döndürür. Çünkü string türleri immutable (değiştirilemez) olduğu için yazma işlemi yapılamaz.
// ReadOnlySpan<char> span6 = text.AsSpan();// AsSpan() metodu, bir string üzerinde bir ReadOnlySpan oluşturmak için kullanılır.
// Bu yöntem, string'in tamamını kapsayan bir ReadOnlySpan oluşturur.

// ReadOnlySpan<char> span7 = text.AsSpan(2,5);// bu şekilde de belirli bir alanı kapsayan ReadOnlyspan olusturur.

#endregion
#region regular expressions
// metinsel ifadeler üzerinde periyodik ve düzenli operasyonlar gerçekleştirmeyi sağlar.
// kullanılan operatorler:
#region ^ operatörü 
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
//satır başının istenilen ifadeyle başlamasını sağlar 

// string text = "buerakkasjdlşkmasşkldşsalşd";
// Regex  regex = new Regex("bue"); // textin "bue" ile başlayıp başlamadığını bool türünde döndürür. 
// Match match = regex.Match(text); // burada da check işlemi yapılır.

// Console.WriteLine(match.Success);
#endregion
#region \ operatörü 

// \D  : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiğini belirtir.
// \d  : Metinsel değerin ilgili yerinde 0-9 arasında tek bir sayı olacağı ifade edilir.

// \W  : Metinsel değerin ilgili yerinde alfarümerik olmayan karakterin olması gerektiğini belirtir. alfarümerik : a-z , A-Z , 0-9
// \w  : Metinsel değerin ilgili yerinde alfarümerik olan karakterin olacağı ifade edilir.

// \S  : Metinsel değerin ilgili yerinde boşluk (TAB , SPACE ) karakteri olmayacağını belirtilir.
// \s  : Metinsel değerin ilgili yerinde sadece boşluk karakteri olacağı belirtilir.

// Ornek ; 
// 9 ile başlayan , 2.karakteri herhangibi bir sayi olan ve son karakteri boşluk olmayan düzenli ifade oluşturmak 

// string text = "92buerakkasjdlşkmasşkldşsalşd";
// Regex regex = new Regex (@"^9\d\S"); 
// Match match = regex.Match(text); 

// Console.WriteLine(match.Success);
#endregion
#region + operatörü 
// belirli gruptaki karakterlerden 1 veya daha fazla olmasını istiyorsak kullanılan karakterdir.

// Ornek ; 
// 9 ile başlayan , arada  herhangibi bir sayisal değerleri olan ve son karakteri boşluk olmayan düzenli ifade oluşturmak 

// string text = "92978263981kkasjdlşkmasşkldşsalşd";
// Regex regex = new Regex(@"^9\d+\S");// + kullanıldıktan sonra 2.veya daha sonrasındda sayısal olan anlamına gelmektedir.
// Match match = regex.Match(text);

// Console.WriteLine(match.Success);
#endregion
#region | (veya) operatörü
// birden fazla karakter grubundan bir yada daha fazlasının ilgili yerde olabliceğini belirtmek istiyorsak mantıksal veya operatörü kullanılır.

// Ornek ; 
// baş harfi a , b yada c olan metinsel ifadeyi girelim.

// string text = "ad1234";
// Regex regex = new Regex(@"a|b|c|");// + kullanıldıktan sonra 2.veya daha sonrasındda sayısal olan anlamına gelmektedir.
// Match match = regex.Match(text);
// Console.WriteLine(match.Success);
#endregion
#region {n} operatörü 
// sabit sayıda karakter olması isteniyorsa {adet} şeklinde belirtilmeli.

// ornek ; 
// 11 haneli tc kimlik no girilsin 

// string text = "25523490523";
// Regex regex = new Regex(@"\d{11}");
// Match match = regex.Match(text);
// Console.WriteLine(match.Success);

// ornek telefon numarası 
// string text = "533-3016496";
// Regex regex = new Regex(@"\d{3}-\d{6}");
// Match match = regex.Match(text);
// Console.WriteLine(match.Success);
#endregion
#region ? operatörü 
// önüne gelen karakterin en fazla 1 en az 0 defa olabilmektedir.

// ornek ; 
// \d{3}B?A bunun karsılıgı su sekılde olabilir. ====>  123BA  , 234A bunlar true çalışacaktır. 123BBA olsaydı false dönerdi 2 adet B olamaz.
#endregion
#region . operatörü 
// ilgili yerde herhangibi bir karakterin kullanılabileceğini ifade eder.
// kullanıldığı yerde \n karakteri dışında herhangibi bir karakter bulunabilir.

// ornek;
// \d{3}.A  bu ilk 3 karakteri sayi sonra herhangibi bir karakter gelebilir daha sonrasında A olmalı demektir.
// 123-A , 434^A ... 
#endregion
#region \b \B operatörleri 
// \B bu ifade ile kelimenin başında yada sonunda olmaması gereken karakterler bildirilir.
// \b bu ifade ilgili kelimenin belirtilen karakter dizisi ile sadece sonunda sonlanmasını sağlar.

// ornek ; 
// \d{3}dır\B => başında veya sonunda dır olmayacak => 123dır false , dır123 false , 123dır2 true ;
// \d{3}dır\b => sonubda dır olacak => 123dır true , dır123 false , 123dır2 false ;
#endregion
#region [n] operatörü 
// karakter aralığı belirtilebilir ayrıca özel karakterlerin yerinde yazılmasını da ifade eder.

// ornek ;  
// \d{3}[A-E]

// (533) 301 64 96 için;
// [(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}
#endregion

#endregion
#region Regular Expressions Match Sınıfı Özellikleri
// string text = "(533) 301 64 96";
// Regex regex = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
// Match match = regex.Match(text);

// Console.WriteLine($"Succes : {match.Success}"); // doğrulama işlemi yapar. 
// Console.WriteLine($"Value  : {match.Value}");   // doğrulanan değeri getirir.
// Console.WriteLine($"Index  : {match.Index}");   // doğrulamanın hangi indexten başladığını getirir.
// Console.WriteLine($"Length : {match.Length}");  // doğrulanan değerin adetini verir.


#endregion
#region Array List koleksiyonu
// arrayList verilen veriyi objeckt de tuttugu için boxing işlemine tabi tutar.
// arrayList içerisinde bir veriyi talep ettiğimizde o veri object olarak gelecektir .dolayısıyla kendi türünde işlem yapabilmek için 
// Unboxing yapılması gerekir.
// eleman sayısını öğrenmek için count kullanılmalıdır.
//ArrayList yaslar = new ArrayList() { "burak",25,'a',true};// farklı türlerde verileri tutabilir.

//for (int i = 0; i <15; i++)
//{
//    yaslar.Add(i+10);
//}
//Console.WriteLine(yaslar[5]); // değer atama ve okuma 

//int toplam = 0;
//for ( int i = 0; i < yaslar.Count; i++)
//{
//    toplam += (int) yaslar[i]; // arraylist de  cast ile unboxing işlemi
//}

//int toplam = 0;
//for (int i = 0; i < yaslar.Count; i++)
//{
//   if ( yaslar[i] is int)// türünü is operatörüyle kontrol etme işlmei 

//        toplam += (int)yaslar[i];     
//}

#endregion
#region foreach iteresyon
// dizi veya koleksiyondaki bütün değerleri itere eder parça parça işlem için uygun değildir.
// bir döngü değildir.sadece veri kümesinde kullanılabilir.
//ArrayList sayilar =new ArrayList() { 10,10,14,324,6,123,6,5,8976};
//foreach(object item in sayilar)
//{
//    Console.WriteLine(item);
//}
#endregion
#region math sınıfı
#region abs
// mutlak değer
// int i = Math.Abs(10);
#endregion
#region ceiling
// yukarıya yuvarlam 
//double  i = Math.Ceiling(101.23);
//Console.WriteLine(i); yada console.writeline(math.ceiling(10.12));

#endregion
#region floor
// aşşağı yuvarlamak 
//double i = Math.Floor(10.12);
//Console.WriteLine(i.ToString()); yada console.writeline(math.floor(10.12)) ;
#endregion
#region round
// en yakın olana yuvarlama işlemi yapar
//Console.WriteLine(Math.Round(3.4));// tam yarısı olma durumunda yukarıya yuvarlar.
#endregion
#region pow
// üslü sayı işlemleri yapmaya yarar
//Console.WriteLine(Math.Pow(3,4)); // ilk değer taban 2.değer üs tür.
#endregion
#region sqrt
// karekök fonksiyonu 
//Console.WriteLine(Math.Sqrt(55));
#endregion
#region truncate
// eldeki sayının tam sayısını elde etmek için kullanılır yuvarlama yapmaz.
//Console.WriteLine(Math.Truncate(3.4));// küsüratı atar sadece tam sayıyı verir
#endregion
#endregion
#region DateTime struck'ı
#region now
// şimdiki zamanı döndürür saniye vb dahil
//Console.WriteLine(DateTime.Now);
#endregion
#region today
// tetiklendiği zamanki tarih bilgisini getirir saniye vb getirmez
//Console.WriteLine(DateTime.Today);
#endregion
#region compare
// girilen iki tarihi karşılaştırır ve sonucu int döndürür.

//DateTime tarih1 = new DateTime(2000, 09, 06);
//DateTime tarih2 = new DateTime(2004, 06, 05);

//int result = DateTime.Compare(tarih1, tarih2);
//if (result < 0)
//    Console.WriteLine($"{tarih1} büyüktür {tarih2}");
//else if (result > 0)
//    Console.WriteLine($"{tarih1} küçüktür {tarih2}");

//else 
//    Console.WriteLine($"{tarih1} eşittir {tarih2}");

#endregion
#region addDays
// gün ekler 
//Console.WriteLine(DateTime.Now.AddDays(3));
#endregion
#region addHours
// saat ekler 
//Console.WriteLine(DateTime.Now.AddHours(3));
#endregion
#region addMonths
// ay ekler 
//Console.WriteLine(DateTime.Now.AddMonths(3));
#endregion
#region addYears
// yıl ekler 
//Console.WriteLine(DateTime.Now.AddYears(3));
#endregion
#region addMiliseconds
// milisaniye ekler 
//Console.WriteLine(DateTime.Now.AddMilliseconds(3));

#endregion
#endregion
#region timeSpan struck'ı
// iki tarih arasındaki farkı öğrenmemize yarar
//DateTime d1 = DateTime.Now;
//DateTime d2 = new DateTime(2000,09,06);
//TimeSpan span= d1-d2;
//Console.WriteLine(span.Days);
//Console.WriteLine(span.Hours);
//Console.WriteLine(span.Seconds);
#endregion
#region random sınıfı

//Random random = new Random();
#region next fonksiyonu
// belirli bir aralıkta tam sayı bir değer oluşturmak istenirse next kullanılır. 
//Console.WriteLine(random.Next()); // 0 dan int türünün limiti aralığında .
//Console.WriteLine(random.Next(100));// maksimum limit ayarlama 100 olacak şekilde.
//Console.WriteLine(random.Next(50,100)); // min ve max ayarlama 50-100 arasında .
#endregion
#region nextDouble fonksiyonu
// 0 ile 1 arasında rastgele sayı üretir .
//Console.WriteLine(random.NextDouble());
#endregion
#endregion
#region method 
// bir methodun default hali private dır.
// en küçük program parçasıdır.
// method türleri
// [ Erişim belirleyicisi ] [ Geri dönüş değeri ][ Method adı ](      )
// {} genel imza bu şekilde

#region Geriye değer döndürmeyen , parametre almayan method
// bir method geriye değer döndürmüyorsa void yazılmalı
// static  void method1() { }
#endregion
#region geriye değer döndürmeyen , parametre alan method
//static void method2(int a,bool b) { }
#endregion
#region geriye değer döndüren , parametre almayan method
// geriye değer döndüren methodlarda void kullanılamaz 

// public int method3()
//{
//    if (  DateTime.Now.Second>10 )
//    return 25; // geriye değer döndüren methodlarda bildirilen türde bir değer döndürmek için return keywordu gereklidir.
//    return 0;

//} 
// eğer ki bir method herhangibi bir türde  geriye değer döndüreleceği ifade edilirse o türde değer döndürülmesi zorunludur yoksa hata verir.
#endregion
#region geriye değer döndüren , parametre alan method
//public int method4(int a) 
//{ 
//    return DateTime.Now.Year > 2000 ? 1:0 ;
//}
#endregion

#region optional parametre 
// parametreli bir method kullanırken parametreler türüne uygun değerler gönderilmek zorunludur.
// eğer ki zorunlu değer göndermek istemiyorsak parametreye isteğimize göre değer göndermek istiyorsak o parametrenin 
// bu durumunu karşılayabilecek bir özellik olması gerekmektedir.Bu özelliğe opsiyonel parametreler denmektedir.
// method parametrelerine = oparetörü ile bir değer atanırsa o parametreye varsayılan default değer atanmış olur ve opsiyonel parametre olur.
// tüm parametreler opsiyonel yapılabilir .
// birden fazla parametre durumunda opsiyonel olanlar sağ tarafta tanımlanmalıdır.  

//static public void x(int a, int b = 0, int c = 0)
//{

//}

//x(5);
#endregion
#region tanımlanmış methodun kullanımı
// aynı class içindeki tanımlanmış methodlar isimlerinin çağırılmasıyla tetiklenecektir. 

//class ornek
//{
//    public void A()
//    {
//        B();
//    }

//    public void B()
//    {
//        C(3);
//    }

//    public int C(int a)
//    {
//        return a;
//    }
//}

#endregion
#region başka classlarda tanımlanmış method kullanımı

#endregion

#endregion




