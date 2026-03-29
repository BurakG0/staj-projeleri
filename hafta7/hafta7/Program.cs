#region başka sınıfta tanımlanmış method kullanımı
//static void main(string[]args) 
//{
//    Matematik matematik = new Matematik();
//    Console.WriteLine( matematik.carp(3, 5));

//}
//class Matematik
//{
//    public int topla(int sayi1,int sayi2)
//    {
//        return sayi1 + sayi2;
//    }
//    public int cıkar(int sayi1, int sayi2)
//    {
//        return sayi1 - sayi2;
//    }
//    public int carp(int sayi1, int sayi2)
//    {
//        return sayi1 * sayi2;
//    }
//    public int bol(int sayi1, int sayi2)
//    {
//        return sayi1 / sayi2;
//    }

//}



#endregion
#region  Non Trailing Named Arguments

//static void X(int a,int b ,string c)
//{


//}
//X(c: "burak", a: 25, b: 06);
//// normalde sıralı bir değer gönderirken hedefleme yapmamızı sağlar .

#endregion
#region in parameters
// in komutu sayesinde parametreye verilen değeri sabit tutabiliriz.
// in keywordu methodun parametresini readOnly sadece okunabilir yapar.
// static void X(in int a ,int b ,in int c) { }
#endregion
#region Local Functions
// bir method içerisinde tanımlanmış olan methodlardır . 
// erişim belirleyicisi (public ,privat ...) tanımlanmaz .
// isimi tanımlandığı fonksiyondan farklı olmalıdır.
// local functions tanımlandığı methodun heryerinde kullanılır.

//class program1
//{

//    public void  X(int a)
//    {  
//        int b = 0;

//        static void Y(int a , int b)
//        {
//            System.Console.WriteLine(b);
//            System.Console.WriteLine(a);
//        }

//        Y(a,b);

//    }
//}

#endregion
#region method overloading
// bir class içinde aynı isimde birden fazla method tanımlanmasını sağlar .
// bu methodlar tanımlanırken birbirinden farklı imzaları olmalııdr.
// method overloading yapabilmek için isimleri aynı olması gerekir.
// parametre sayıları yada türleri farklı olmalıdır.

//class Matematik
//{
//    public int topla(int sayi1, int sayi2) { return sayi1 + sayi2; }
//    public int topla(int sayi1, int sayi2, int sayi3) { return sayi1 + sayi2 + sayi3; }

//}





#endregion
#region recursive fonksiyon
// kendi içerisinde kendini çağıran veya tetikleyen fonksiyonlardır.
// öngörülmeyen , derinliği tahmin edilemeyen , sonu bilinmeyen durumlarda tercih edilir.
// döngülerin kullanıldığı her noktada recursive fonk. kullanılabilir ama recursive fonk. kullanıldıgı heryerde döngüler kullanılamaz.

//X();
//void X(int a = 1)
//{ 
//   Console.WriteLine("burak");
//    if (a < 3)
//        X(++a);
//    else Console.WriteLine("gunay");

//}
#region recursivc örnek 
//List<FileInfo> files = DosyaYazdır("C:/Users/Rog/Desktop/Staj D");
//foreach (FileInfo file in files )
//    Console.WriteLine(file.FullName);
//List <FileInfo> DosyaYazdır(string path)
//{
//    List<FileInfo> filesInfos = new ();
//    DirectoryInfo dir = new DirectoryInfo(path);
//    DirectoryInfo[] dirs = dir.GetDirectories();
//    if (dirs.Any())
//        foreach (DirectoryInfo directory in dirs )
//            filesInfos.AddRange (DosyaYazdır(directory.FullName));
//    else filesInfos.AddRange (dir.GetFiles());
//    return filesInfos;
//}

#endregion
#endregion
#region ref keyword
// değer türlü değişkenlerde referans yapmak istiyorsak eğer ref keywordu kullanılr.
// değer türlü değişkenlerin referans türlü değişkenler gibi çalışmasını sağlayan bir komuttur.
// referans edilen değişken aynı bellekten beslenir 

//int a=5;
//ref int b = ref a;

//Console.WriteLine(b);
//Console.WriteLine(a);
//a *= 5;
//Console.WriteLine(a);
//b -= 10;
//Console.WriteLine(b);


//int y = 10;
//X(ref y);
//Console.WriteLine(y);

//void X(ref int a)
//{
//    a = 25;
//}


#region ref returns 

//int a = 5;
//int b = X(ref a);

//Console.WriteLine(a);
//Console.WriteLine(b);

//ref int X(ref int y)
//{
//    y = 25;
//    return ref y;
//}



#endregion










#endregion
#region out keyword
// out keywordu metotların parametrelerinden dışarıya değer göndermemizi sağlayan bir keyworddur.
// bir method output parametreler tanımlanıyorsa o parametrelere kendi içerisinde değer atanması gerekmektedir.



//int a = X(out int _b ,123,out string _d );

//int X(out int b , int c , out string d )
//{
//    b = 12;
//    d = "burak";
//    return  0;
//}


#endregion
#region try parse 
// tür dönüşümlerinde elimizdeki değerlerin hedef türe uygun olup olmamasını ve bu duruma göre dönüşümün sağlanmasını try parse ile sağlanır .,

//string a = "123";

//if (int.TryParse(a, out int r))
//{
//    r = int.Parse(a);
//}
//else { }

#endregion