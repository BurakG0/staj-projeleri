#region parse ornegı
/*
string x = "123"; 
int y = int.Parse(x);// parse methodu string ifadeyi int türüne dönüştürür. Eğer string ifade geçerli bir int değilse, bu yöntem bir FormatException hatası fırlatır.
Console.WriteLine(y);*/
#endregion
#region hatalı parse ornegi
/*string z = "abc";
char z2 = char.Parse(z);
Console.WriteLine(z2); hatalı donusum ornegi dolayında, char.Parse() yöntemi "abc" string'ini tek bir karaktere dönüştürmeye çalışır.
Ancak "abc" üç karakter içerdiği için bu dönüşüm geçersizdir ve bir FormatException hatası fırlatılır.
Bu nedenle, z2 değişkenine herhangi bir değer atanmaz ve program hata verir.dolayısıyla donusturulen değerin uygunlugu onemlidir */
#endregion
#region convert ornegi
/*
// Convert kullanımı 
string a = "456";
int a2 = Convert.ToInt32(a); // Convert.ToInt32() yöntemi, string ifadeyi int türüne dönüştürür.
                             // Eğer string ifade geçerli bir int değilse, bu yöntem bir FormatException hatası fırlatır.
Console.WriteLine(a2); 

string a = "789";
char a2 = Convert.ToChar(a); // Convert.ToChar() yöntemi, string ifadeyi char türüne dönüştürmeye çalışır.
                             // Ancak "789" üç karakter içerdiği için bu dönüşüm geçersizdir ve bir FormatException hatası fırlatılır.

string a = "3,14";
double a2 = Convert.ToDouble(a); // Convert.ToDouble() yöntemi, string ifadeyi double türüne dönüştürür.
                                 // Eğer string ifade geçerli bir double değilse, bu yöntem bir FormatException hatası fırlatır.

 float f =25; 
string f2= f.ToString(); // ToString() yöntemi, bir sayısal değeri string türüne dönüştürür. Bu yöntem, sayısal değerin metin temsili olarak döndürülmesini sağlar. */
#endregion
#region tür dönüşümleri
/*
// Tür Dönüşümleri bir türün kendisinden daha büyük bir türe dönüşmesine bilinçsiz tür donusumu denir.
// Bu tür dönüşümler genellikle veri kaybına neden olmaz çünkü daha büyük bir tür, daha küçük bir türün tüm değerlerini kapsar.
// Örneğin, int türünden float türüne yapılan bir dönüşüm bilinçsiz tür dönüşümüdür:
int a = 3000;
float f = a; // tür değişmesi sırasında veri kaybı olmaz çünkü float, int türünden daha geniş bir aralığa sahiptir.


//bilinçli tür dönüşümü, bir türün kendisinden daha küçük bir türe dönüşmesine denir.
//Bu tür dönüşümler genellikle veri kaybına neden olabilir çünkü daha küçük bir tür, daha büyük bir türün tüm değerlerini kapsamayabilir.

int a = 3000;
short s = (short)a; // tür değişmesi sırasında veri kaybı olabilir çünkü short, int türünden daha dar bir aralığa sahiptir. 
                    // Eğer a'nın değeri short türünün sınırlarını aşarsa, bu dönüşüm sonucunda beklenmeyen sonuçlar ortaya çıkabilir.
                    // veri kaybı sorumlulugunu programcıya aittir. bu nedenle bilinçli tür dönüşümü yapılırken dikkatli olunmalıdır cast operatoru ile yapılır.

int a = 3000;
short s = (byte)a; // burada hem bilinclı hem bilincsiz tür dönüşümü yapılmıştır. int türünden byte türüne dönüşüm bilinçli tür dönüşümüdür.
                   // daha sonra byte türünden short türüne dönüşüm bilinçsiz tür dönüşümüdür.*/
#endregion
#region checked unchecked
/*
// checked kullanımı bilinçli tür dönüşümlerinde oluşabilecek veri kaybını kontrol etmek için kullanılır.
// Eğer checked bloğu içinde bir tür dönüşümü sırasında veri kaybı meydana gelirse bizi uyarır 

checked
{
    int a = 3000;
    short s = (short)a; // tür değişmesi sırasında veri kaybı olabilir çünkü short, int türünden daha dar bir aralığa sahiptir. 
                        // Eğer a'nın değeri short türünün sınırlarını aşarsa, bu dönüşüm sonucunda beklenmeyen sonuçlar ortaya çıkabilir.
                        // checked bloğu sayesinde bu tür dönüşüm sırasında oluşabilecek veri kaybı kontrol edilir.
                        // eğer bir hata meydana gelirse bir OverflowException hatası fırlatılır.
}


//unchecked kullanımı checked bloğunun tam tersi olarak çalışır.
//unchecked bloğu içinde yapılan tür dönüşümlerinde veri kaybı kontrol edilmez ve herhangi bir hata meydana gelmez.
// normal bir kod blogu default olarak unchecked olarak çalışır.*/
#endregion
#region ascii ornegi
/*
//char türünden int türüne dönüşüm örneği
char a = 'b';
int _a = (int)a;
Console.WriteLine(_a);//char türünden int türüne dönüşümde, char türündeki 'b' karakteri ASCII (veya Unicode) kodu olan 98'e dönüştürülür.
                      //Bu nedenle, _a değişkeninin değeri 98 olacaktır ve ekrana 98 yazdırılacaktır.

int ascii = 95;
int bascii = 85;
Console.WriteLine((char)ascii);
Console.WriteLine((char)bascii);//Bu kod parçasında,int ascii değişkeni char türüne donusturulmustur.95 sayısının ascıı tablosundaki karşılıgı gelcektir*/
#endregion
#region ternary operatoru
/*
bool medeniHal = false;
string mesaj = medeniHal==true?"evlilere kampanya":"bekarla kampanya";
Console.WriteLine(mesaj);// Ternary operatoru kullanımı örneği. kullanınmının temel şeyi ?: şeklindedir.

// ternary komutu coklu secenek ornegi
int yas = 25;
string mesaj = yas < 25 ? "a" : (yas == 25 ? "b" : "c");
Console.WriteLine(mesaj);//Bu kod parçasında, yas değişkeninin değeri 25 olduğu için, ikinci koşul olan
                         //(yas == 25 ? "b" : "c") ifadesi değerlendirilir ve sonuç olarak "b" mesajı ekrana yazdırılır.

Console.WriteLine("bir sayı giriniz");
int sayi=int.Parse(Console.ReadLine());
int sonuc = sayi < 3 ? sayi * 5 :
    (sayi > 3 && sayi < 9 ? sayi * 3 :
    (sayi >= 9 && sayi % 2 == 0) ? sayi * 10 :
    (sayi % 2 == 1 ? sayi : -1));
Console.WriteLine("sonuc : " + sonuc);//Bu kod parçasında, kullanıcıdan bir sayı girmesi istenir ve bu sayı üzerinden bir dizi koşul değerlendirilir.
                                      //Koşullar şu şekildedir: kullanıcının girdiği sayı 3'ten küçükse,
                                      //sayı 5 ile çarpılır; sayı 3 ile 9 arasında ise, sayı 3 ile çarpılır;
                                      //sayı 9 veya daha büyük ve çift ise, sayı 10 ile çarpılır; sayı tek ise, sayı kendisi olarak kalır;
                                      //diğer durumlarda sonuç -1 olarak atanır. Sonuç ekrana yazdırılır.
                                      //çoklu ternary operatoru kullanımı örneği. bu şekildedir. çoklu ternary operatoru kullanırken
                                      //0parantezler kullanarak koşulların sırasını belirlemek önemlidir.
Console.WriteLine("Hava durumunu giriniz");
string havadurumu = Console.ReadLine();
string durum = havadurumu == "gunesli" ? "bol bol d vitamini alman dileğiyle" :
    (havadurumu == "yagmurlu" ? "şemsiye almalısın" :
    (havadurumu =="kapalı" ? "yagmur yağabilir":"hava durumu girmediniz"));
Console.WriteLine(durum);//Bu kod parçasında, kullanıcıdan hava durumunu girmesi istenir ve bu bilgi üzerinden bir dizi koşul değerlendirilir.
                         //Koşullar şu şekildedir: kullanıcı "gunesli" yazarsa, "bol bol d vitamini alman dileğiyle" mesajı atanır;
                         //kullanıcı "yagmurlu" yazarsa, "şemsiye almalısın" mesajı atanır; kullanıcı "kapalı" yazarsa, "yagmur yağabilir" mesajı atanır;
                         //diğer durumlarda "hava durumu girmediniz" mesajı atanır. Sonuç ekrana yazdırılır.
string havadurumu = "gunesli";
Console.WriteLine(havadurumu == "gunesli" ?"bol bol d vitamini alman gerek":(havadurumu=="yagmurlu"?"şemsiye almalısın":"yagmur yağabililir"));
//bu şekilde kullanıcıdan veri almadan da havadurumu değişkenini kendimiz girerek yapabiliriz.

//ornek 
string kullaniciAdi = Console.ReadLine();
string sifre = Console.ReadLine();
Console.WriteLine(kullaniciAdi =="burak" && sifre=="1234" ? "şifre doğru giriş yapılıyor":"kullanıcı adı veya şifre yanlış");*/
#endregion
#region sizeof operatoru
//sizeof operatoru, bir veri türünün bellekte kapladığı byte cinsinden boyutunu döndürür.
//Console.WriteLine("int : " + sizeof(int)); // int türünün bellekte kapladıı alanı.
//Console.WriteLine("double : " + sizeof(double));// double türünün bellekte kapladıı alanı.
//Console.WriteLine("decimal : " + sizeof(decimal));// decimal türünün bellekte kapladıı alanı.
#endregion
#region typeof keywordu
//Type t=typeof(int);                //typeof operatörünün kullanımı. typeof operatörü, bir türün Type nesnesini döndürür. Bu sayede tür hakkında bilgi edinilebilir.
//Console.WriteLine(t.Name);         // türün adını verir.
//Console.WriteLine(t.IsPrimitive);  // türün ilkel bir tür olup olmadığını kontrol eder. int gibi temel veri türleri ilkel türlerdir.
//Console.WriteLine(t.IsClass);      // türün bir sınıf olup olmadığını kontrol eder. int gibi temel veri türleri sınıf değildir.
//Console.WriteLine(t.IsValueType);  // türün bir değer türü olup olmadığını kontrol eder. int gibi temel veri türleri değer türleridir.
#endregion
#region is operatoru
//object obj = true ; // is operatoru, bir nesnenin belirli bir türe sahip olup olmadığını kontrol etmek için kullanılır.
//Console.WriteLine( obj is bool );// obj nesnesinin bool türüne sahip olup olmadığını kontrol eder. true döner çünkü obj değişkeni true değerine sahiptir.
//Console.WriteLine( obj is byte );
//Console.WriteLine( obj is short );
//Console.WriteLine( obj is string );
#endregion
#region nullable operatör
//int? a = null; // nullable operatör, bir değer türünün null değer alabilmesini sağlar. int? ifadesi, int türünün nullable versiyonunu temsil eder.
//bool? b = null;
//Console.WriteLine(a is null);
//bir değer türü nullable olarak tanımlandığında, bu türün null değer alabilme özelliği kazanır.is null /is not null/as operatorleri ile null kontrolü yapılabilir.
//as orneklendirmesi
//object x = 123;
//int? y = x as int?; 
#endregion
#region null coalescing operatoru
//string a = "burak";
//Console.WriteLine(a ?? "günay");// null coalescing operatoru, bir ifadenin null olup olmadığını kontrol eder
//ve null ise alternatif bir değer döndürür.
//a ?? "günay" ifadesi, a değişkeni null değilse a'nın değerini döndürür; a değişkeni null ise "günay" değerini döndürür.
#endregion
#region null coalescing assignment operatoru
//string a = null;
//a ??= "günay"; // null coalescing assignment operatoru, bir değişkenin null olup olmadığını kontrol eder ve null ise alternatif bir değer atar.
//a ??= "günay" ifadesi, a değişkeni null ise a nın yeni değeri "günay" olur; a değişkeni null değilse a'nın değeri değişmeden kalır.
//int? id = null;
//id ??= 1; // id değişkeni null ise id değeri 1 olur değilse id değerini korur
#endregion
#region switch case 
/*
//iki değerin eşitlik durumunu kontrol etmek için switch case yapısı kullanılabilir.
//switch case yapısı, bir değişkenin belirli bir değere sahip olup olmadığını kontrol eder ve bu değere göre farklı kod bloklarının çalışmasını sağlar.
string adi = "burak";
switch (adi)                //konrol edileden değer türü ile switch yapısındaki değer türü aynı olmalıdır. bu örnekte her ikisi de string türündedir.
                            //switch parantezinde kontrol edilecek değer bir değişken yada sabit bir değer olabilirken case blogunda kontrol edilecek değerler sabit bir değer olmalıdır.
                            //bu örnekte case blogundaki değerler sabit string değerlerdir.
{
    case "kübra":
        Console.WriteLine("merhaba kübra");
        break;
    case "günay":
        Console.WriteLine("merhaba günay");
        break;
        case "burak":
            Console.WriteLine("merhaba burak");
        break;
    default:
        Console.WriteLine("tanımlanmamış bir isim girdiniz");
        break;
};
//when kullanımı
int satisturari = 1000;
switch (satisturari)
{
    case 1000 when (satisturari<500 ):
        Console.WriteLine("satış tutarı 1000 ve 3 eşittir 5");
        break;
        case 1000 when (3 == 3):
        Console.WriteLine("satış tutarı 1000 ve 3 eşittir 3");
        break;
        default:
        Console.WriteLine("satış tutarı 1000 değil veya 3 eşit değil");
        break;
};// bu kod parçasında,when kullanım örneği gösterilmiştir. switch case yapısında,when ifadesi,"ve" anlamına gelmektedir.
 //goto kullanımı
 //farklı eşitlik durumlarında aynı kod bloğunun çalışmasını sağlamak için goto ifadesi kullanılabilir. şu case deki kodu çalıştır demek için kullanılır.
 int sayi = 49;
switch (sayi) 
{
    case 5:
        Console.WriteLine(sayi*10);
        break;
    case 6:
        Console.WriteLine(sayi*5);
        break;
    case 7:
        goto case 5; // sayi 7 olduğunda case 5 deki kod bloğu çalışır. goto ile yonlendirilen case blogu eşleşip eşlenmediğine bakılmaksızın çalışır.
    default:
        Console.WriteLine("sayı girmediniz");
        break;

};

//switch expression kullanımı
string mesaj = DateTime.Now.DayOfWeek switch // switch expression kullanımı örneği.
{
    DayOfWeek.Monday => "bugün pazartesi",
    DayOfWeek.Tuesday => "bugün salı",
    DayOfWeek.Wednesday => "bugün çarşamba",
    DayOfWeek.Thursday => "bugün perşembe",
    DayOfWeek.Friday => "bugün cuma",
    DayOfWeek.Saturday => "bugün cumartesi",
    DayOfWeek.Sunday => "bugün pazar",
};
int i = 10;//switch expression kullanımı örneği. switch expression, switch case yapısının daha kısa ve okunabilir bir şekilde yazılmasını sağlar.
string isim = i switch
{
    5 => "mehmet",
    7 => "burak",
    10 => "kübra",
   
};

//switch tuple kullanımı
string adi="burak";
int yasi = 25;
string mesaj = (adi, yasi) switch // switch tuple kullanımı örneği. switch case yapısında birden fazla değeri kontrol etmek için tuple kullanılabilir.
{
    ("burak", 25) => "merhaba burak",
    ("kübra", 30) => "merhaba kübra",
    ("günay", 28) => "merhaba günay",
    _ => "tanımlanmamış bir isim veya yaş girdiniz"
};
Console.WriteLine(mesaj);

int sayi1 = 49;
int sayi2 = 50;
string mesaj = (sayi1, sayi2) switch
{
    (5, 10) => "sayılar 5 ve 10",
    (49, 50) => "sayılar 49 ve 50",
    _ => "tanımlanmamış sayılar girdiniz"
};
Console.WriteLine(mesaj);//Bu kod parçasında, switch tuple kullanımı örneği gösterilmiştir.
                         //sayi1 ve sayi2 değişkenlerinin değerleri bir tuple olarak değerlendirilir ve bu tuple'a göre mesaj atanır.

// switch var ve tuple kullanımı
string adi="burak";
int yasi = 25;
string mesaj = (adi, yasi) switch
{
    var (a, b) when (a == "burak" && b == 25) => "merhaba burak",
    var (a, b) when (a == "kübra" && b == 30) => "merhaba kübra",
    var (a, b) when (a == "günay" && b == 28) => "merhaba günay",
    _ => "tanımlanmamış bir isim veya yaş girdiniz"
};
Console.WriteLine(mesaj);
*/
#endregion
#region if else
/*
int sayi =int.Parse(Console.ReadLine());
if (sayi > 100 && sayi <= 400)
{
    Console.WriteLine("sayı 100 ile 400 arasında");
}
else if(sayi > 200 && sayi <= 500)
{
        Console.WriteLine("sayı 200 ile 500 arasında");

}
else if (sayi > 300 && sayi <= 600)
{
    Console.WriteLine("sayı 300 ile 600 arasında");
}
else
{
    Console.WriteLine("sayı 100 ile 600 arasında değil");
}  // if else ve else if yapısında bir örnek gösterilmiştir.


int sayi1 = int.Parse(Console.ReadLine());
if(sayi1 <100)
    {
    Console.WriteLine("sayı 100 den küçük");
}
if (sayi1 > 100)
    {
    Console.WriteLine("sayı 100 den büyük");
}
if (sayi1 == 100)
    {
    Console.WriteLine("sayı 100 e eşit");
} // if yapısında bir örnek gösterilmiştir. if yapısında her koşul birbirinden bağımsız olarak değerlendirilir ve birden fazla koşul sağlanabilir.*/
#endregion
#region if else örnek
/*
// soru : kullanıcıdan iki  tutar girmesini isteyin bu tutarların toplamı 200 den büyükse %25 indirim yapın,değilse indirim yapmayın ve sonucu ekrana yazdırın.
Console.WriteLine("bir tutar giriniz");
int tutar1 = int.Parse(Console.ReadLine());
Console.WriteLine("bir tutar daha giriniz");
int tutar2 = int.Parse(Console.ReadLine());
int toplam = tutar1 + (tutar2 *75/100);
if (tutar1 + tutar2 >200 )
{
    Console.WriteLine("tebrikler indirimi kazandınız kalan tutar : " + toplam);
}
else
{
    Console.WriteLine("maalesef indirim kazanamadınız ödenecek tutar : " + (tutar1 + tutar2));
    Console.WriteLine("indirim kazanmak için kalan tutar : " + (200 - (tutar1 + tutar2)));
  }
*/
#endregion
#region if else örnek 2
/*
Console.WriteLine("bir sayı giriniz");
int sayi = int.Parse(Console.ReadLine());
string sonuc;

if (sayi<0)
    sonuc= "sayı negatiftir";
else 
    sonuc= "sayı pozitiftir";
Console.WriteLine(sonuc);// if else yapısında tek satırda sonuç atama örneği gösterilmiştir. if else yapısında tek bir koşul sağlanıyorsa bu şekilde tek satırda sonuç atanabilir.
*/
#endregion
#region constant pattern
/*
//constant pattern, bir değerin belirli bir sabit değere eşit olup olmadığını kontrol etmek için kullanılır.
int x = 5;
Console.WriteLine(x is int);//burada sadece is kullanımı ile türü kontrol edilir.
Console.WriteLine(x is 5);//burada ise constant pattern kullanılarak x değişkeninin değeri eşit olup olmadığı kontrol edilir.*/
#endregion
#region var pattern
/*
object obj = "burak";// normalde var derleyici sürecinde türü belirlemek için kullanılırken , var pattern runtime sırasında türü belirlemek için kullanılır.
if (obj is var a)
{
    Console.WriteLine(a.ToString());
}*/
#endregion
#region try catch
// try catch yapısı, bir kod bloğunda oluşabilecek hataları yakalamak ve bu hatalara uygun şekilde tepki vermek için kullanılır.
// try catch yapısında, try bloğu içinde hata oluşabilecek kodlar yer alır ve catch bloğu içinde bu hataların nasıl ele alınacağı belirtilir.
//uygulamada runtime hatalarını kontrol etmek için try catch yapısı kullanılır.yönetmek yönlendirmek ve manipule etmek için kullanılır.
//try // olası hata vericek kodlar buraya yazılır.
//{
//    Console.WriteLine("bir sayı giriniz");
//    int sayi = int.Parse(Console.ReadLine());
//    Console.WriteLine("bir sayı daha giriniz");
//    int sayi2 = int.Parse(Console.ReadLine());
//    Console.WriteLine("toplam : " + (sayi + sayi2));// bu try bloğu içinde kullanıcıdan iki sayı girmesi istenir ve bu sayılar toplanarak ekrana yazdırılır.
//                                                    // Eğer kullanıcı geçerli bir sayı girmezse,
//                                                    // int.Parse() yöntemi bir FormatException hatası fırlatır ve bu hata catch bloğu tarafından yakalanır.
//}
//catch { //hata verilirse ne yapılacağı buraya yazılır.
//Console.WriteLine("lütfen sadece sayı giriniz"); // bu catch bloğu, try bloğu içinde oluşabilecek herhangi bir hatayı yakalar ve kullanıcıya sadece sayı girmesi gerektiğini belirten bir mesaj verir.
//}


//try {
//    int sayi1=0 , sayi2=10 ;
//    int a = sayi2 / sayi1;
//}
//catch(Exception ex){// catch bloğunda Exception sınıfından bir nesne tanımlanarak, oluşabilecek hatanın detaylarına erişilebilir. ex değişkeni, yakalanan hatanın bilgilerini içerir.
//exception tüm hata türlerinin atasıdır o yüzden tüm hataları yakalayabilir
//    Console.WriteLine("mesaj" + ex.Message);// ex.Message ifadesi, yakalanan hatanın mesajını ekrana yazdırır. Bu sayede, hatanın ne olduğunu daha iyi anlayabiliriz.
// }

// birden fazla catch bloğu kullanarak farklı türdeki hataları ayrı ayrı yakalayabiliriz. bu sayede, her hata türü için özel bir tepki verebiliriz.
//try
//{
//    int sayi1 = 0, sayi2 = 10;
//    int a = sayi2 / sayi1;
//   int.Parse("abc");
//}
//catch (DivideByZeroException ex) 
// bu catch bloğu, sadece DivideByZeroException türündeki hataları yakalar. Eğer try bloğu içinde başka türde bir hata oluşursa, bu catch bloğu tarafından yakalanmaz ve program hata verir.
//{
//    Console.WriteLine("sayı sıfıra bölünemez" + ex.Message);
//}
//catch (FormatException ex) // bu catch bloğu, sadece FormatException türündeki hataları yakalar. Eğer try bloğu içinde başka türde bir hata oluşursa, bu catch bloğu tarafından yakalanmaz ve program hata verir.
//{
//    Console.WriteLine("lütfen sadece sayı giriniz" + ex.Message);
//}
//catch (Exception ex) // bu catch bloğu, diğer iki catch bloğunda yakalanmayan herhangi bir türdeki hatayı yakalar. Bu sayede, try bloğu içinde oluşabilecek tüm hatalar kontrol altına alınmış olur.
//{
//    Console.WriteLine("beklenmedik bir hata oluştu" + ex.Message);
//}

//finally bloğu, try catch yapısında kullanılan bir blok türüdür. finally bloğu, try bloğu içinde hata oluşsa da oluşmasa da her zaman çalışır.
//en sona tanımlanır ve genellikle kaynakları serbest bırakmak veya temizleme işlemleri yapmak için kullanılır.

//when yapısı ile hata filtreleme yapılabilir. when ifadesi, catch bloğunda belirli koşullar sağlandığında hatayı yakalamak için kullanılır.
//try
//{
   // when ifadesi kullanım örneği "ve" mantığı ile çalışır. birden fazla when ifadesi kullanarak farklı koşulları kontrol edebiliriz.
//}
//catch (Exception ex) when (3==3)
//{
//}
#endregion
