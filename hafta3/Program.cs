#region for döngüsü
//ardaşık işlemler için en uygun olan for döngüsüdür. for döngüsü 3 bölümden oluşur. 
//1. bölümde döngünün kaç kere çalışacağını belirleriz.
//2. bölümde döngünün çalışması için gerekli şartı belirleriz.
//3. bölümde ise döngünün her çalışmasından sonra ne yapılacağını belirleriz.
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}


//double faktoriyel = 1;
//int sayi =int.Parse(Console.ReadLine());
//string sonuc = "";
//for (double i = sayi; i > 0; i--)
//    {
//    faktoriyel *= i;
//    sonuc += i + (i == 1 ? "=" : "x");
//}
//Console.WriteLine("faktoriyel :  " +sonuc + faktoriyel);//factoriyel örneği.



#endregion
#region while döngüsü
//int i = 0;
//while (i <= 10) { 
//    Console.WriteLine("burak");
//    i++;
//}                              //burak isminin 10 kere ekrana yazdırılması.

//int sayi=int.Parse(Console.ReadLine());
//while (sayi > 0)
//{

//Console.WriteLine(sayi);
//  sayi--;
//}                               //girilen sayının 0 olana kadar ekrana yazdırılması.

//int i= 0, toplam=0;
//while (i <= 100)
//{
//    if(i % 2 == 1)
//    toplam += i;
//    i++;
//}
//Console.WriteLine(toplam);     //1 ile 100 arasındaki tek sayıların toplamı.

//while (true)
//{
//    if (DateTime.Now.Second % 5 == 0)
//        Console.WriteLine(DateTime.Now);
//}                         //her 5 saniyede bir o anki tarihi ekrana yazdırır.

#endregion
#region do-while döngüsü
//do-while döngüsü
//int sayi;
//do
//{
//    Console.WriteLine("pozitif bir sayı giriniz : ");
//    sayi = int.Parse(Console.ReadLine());
//} while (sayi <= 0); //girilen sayı pozitif olana kadar ekrana pozitif bir sayı girmemiz gerektiğini yazdırır.
#endregion
#region sonsuz döngü
//for ile sonsuz döngü ve durdurma 
//bool dongu = true;
//for (; dongu;)
//{ 
//    if(true)
//    {
//      dongu=!dongu;
//    }
//}//for döngüsü ile sonsuz döngü oluşturduk ve if bloğu içinde dongu değişkenini false yaparak döngüyü durdurduk.

// while ile sonsuz döngü ve durdurma  
//bool dongu2 = false;
//while (!dongu2)
//{
//    if (true)
//    {
//        dongu2=!dongu2;
//    }

//}//while döngüsü ile sonsuz döngü oluşturduk ve if bloğu içinde dongu2 değişkenini true yaparak döngüyü durdurduk.

//do-while ile sonsuz döngü ve durdurma

//bool dongu3 = true;
//do
//{ if(true)
//        {
//        dongu3=!dongu3;
//    }

//}
//while (dongu3);
#endregion
#region iç içe döngüler
//örnek 1
//for (int i = 1; i <= 9; i++)
//{     for (int a = 1; a <= 9; a++)
//    {
//        for (int b = 1; b <= 9; b++)
//        {
//        for (int c = 1; c <= 9; c++)
//        {
//            Console.WriteLine($"{i} {a} {b} {c}");
//            }
//        }

//    }
//} 
#endregion
#region foreach döngüsü
//string[] isimler = { "burak", "ahmet", "mehmet", "ayşe" };
//foreach (string isim in isimler)
//{ 
//    Console.WriteLine(isim);
//} //foreach döngüsü ile isimler dizisindeki her bir ismi ekrana yazdırır.
#endregion
#region konseptsiz keyword
//break, continue, return, yield, goto
//break: döngüyü veya switch bloğunu sonlandırır.
//continue: döngünün o anki iterasyonunu atlar ve bir sonraki iterasyona geçer.
//return: bir metodu sonlandırır ve isteğe bağlı olarak bir değer döndürebilir.
//yield: bir metodu iterator olarak tanımlar ve her çağrıldığında bir sonraki değeri döndürür.
//goto: program akışını belirli bir etikete atlar, ancak genellikle önerilmez çünkü kodun okunabilirliğini azaltabilir.
#endregion
#region konseptli keyword
//if, else, switch, for, while, do-while, foreach
//if: bir koşulun doğru olup olmadığını kontrol eder ve buna göre kod bloğunu çalıştırır.
//else: if bloğunun koşulu yanlış olduğunda çalışacak kod bloğunu tanımlar.
//switch: bir değişkenin değerine göre farklı kod bloklarını çalıştırır.
//for: belirli bir sayıda tekrarlanacak kod bloğunu tanımlar.
//while: bir koşul doğru olduğu sürece kod bloğunu tekrarlar.
//do-while: kod bloğunu en az bir kez çalıştırır ve ardından koşulu kontrol eder, koşul doğru olduğu sürece tekrarlar.
//foreach: bir koleksiyonun her bir elemanı üzerinde işlem yapmak için kullanılır.
//değişken tanımlamak için kullanılan int string gibi keywordler de konseptli keywordlerdir.
#endregion
#region manevratik komutlar break
//manevratik komutlar, programın akışını kontrol etmek için kullanılan komut veya ifadeler olarak tanımlanır.

// 1. break komutu .

//for (int i = 0; i < 100; i++)
//{
//    if (i == 5)
//    {
//        break; // i 5 olduğunda döngüyü sonlandırır.
//    }
//    Console.WriteLine(i);}
// break komutu, döngüyü veya switch bloğunu sonlandırmak için kullanılır. Yukarıdaki örnekte, i 5 olduğunda break komutu çalışır ve döngü sonlanır,sadece döngü ve switch bloklarında kullanılabilir.
// break komutu, döngünün geri kalanını atlar ve döngüden çıkar. Bu, belirli bir koşul gerçekleştiğinde döngüyü durdurmak istediğiniz durumlarda kullanışlıdır.

//while (true)
//{ if(DateTime.Now.Second == 45)
//    break;
//    Console.WriteLine(DateTime.Now);}
//bu örnekte, her saniye o anki tarihi ekrana yazdırır ve saniye 45 olduğunda break komutu çalışır ve döngü sonlanır.bir nevi ayarlanan saniyeden geri sayım yapar gibi çalışır.

//kullanıcıdan "t " harfi gelene kadar gelen sınırsız sayıyı toplayan program:

//int toplam = 0;
//while (true)
//{
//    Console.WriteLine("bir sayı giriniz");
//    string input = Console.ReadLine();
//    if(input=="t")
//    {
//        Console.WriteLine("toplam sonuç : " + toplam);
//        break;
//    }
//    else
//    {
//         toplam += int.Parse(input);

//    }
//}

// kullanıcıdan alınan sonsuz adet sayı değerlerinden 24'ün katı olunca programı sonlandıran program:
//while (true)
//    {
//    Console.WriteLine("bir sayı giriniz");
//    int input = int.Parse(Console.ReadLine());
//    if (input % 24 == 0)
//    {
//        Console.WriteLine("girdiğiniz sayı 24'ün katı olduğu için program sonlanıyor.");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("girdiğiniz sayı 24'ün katı değil, lütfen tekrar deneyiniz.");
//    }
//}

#endregion
#region manevratik komut continue 
// 2 . continue komutu
// continue komutu,sadece döngülerde kullanılabilir ve döngünün o anki iterasyonunu atlayarak bir sonraki iterasyona geçmesini sağlar.
//Bu, belirli bir koşul gerçekleştiğinde döngünün geri kalanını atlamak istediğiniz durumlarda kullanışlıdır.

//for (int i = 0; i < 10; i++)
//{
//    if (i % 2 != 0)
//    {
//        continue; // i çift olduğunda bu iterasyonu atlar ve bir sonraki iterasyona geçer.
//    }
//    Console.WriteLine(i); // sadece çift sayıları ekrana yazdırır.
//}



//kullanıcının girdiği sonsuz adet sayıdan pozitif olanları çarpan ve "t" (enter) yapıldığında sonucu ekrana yazdıran program:

//int carpım = 1;//carpım değişkeni,
//while (true)//sonsuz döngü oluşturduk.
//{
//    Console.WriteLine("bir sayı giriniz");//kullanıcıdan bir sayı girmesini istiyoruz.
//    string input = Console.ReadLine();//kullanıcının girdiği değeri input değişkenine atıyoruz.
//    if (input == "t")//kullanıcı "t" harfini girdiğinde if bloğu çalışır.
//    {
//        Console.WriteLine(carpım);//carpım değişkeninin o ana kadar çarpılan pozitif sayıların sonucunu ekrana yazdırır.
//        break;
//    }
//    else
//    {

//        int sayi = int.Parse(input);//kullanıcının girdiği değeri sayi değişkenine int türünde atıyoruz.
//        if (sayi < 0)//girdiğimiz sayı negatif ise if bloğu çalışır.

//            continue;//negatif sayıların çarpımına dahil edilmemesi için continue komutu ile o iterasyonu atlıyoruz.
//        carpım *= sayi;//girdiğimiz pozitif sayıları carpım değişkenine çarparak atıyoruz.

//    }}


// 1 ile 1000 arasındaki 7 nin katı olmayan sayıları ekrana yazdıran program:
//for (int i = 1; i < 1000; i++)
//    {
//    if (i % 7 == 0)
//    {
//        continue;//i 7'nin katı olduğunda bu iterasyonu atlar ve bir sonraki iterasyona geçer.
//    }
//    Console.WriteLine(i);//i 7'nin katı olmayan sayıları ekrana yazdırır.
//}

#endregion
#region manevratik komut return

//3.return komutu
//while(true)
//{
//switch (10)
//{
//case 10:
//return;  // returnden sonra hangi komut gelirse gelsin işlemeyecektir.
//break;
//}

//}


// kullanıcı c tuşuna basana kadar sonsuz döngüde dönen program :
//consol.key o tuşa basıldığında entere basmadan işlememizi sağlar
// while(true)
//{
//    if (Console.ReadKey().KeyChar =='c')
//    {
//        Console.WriteLine("uygulama sona ermiştir");
//        return;
//    }
//    Console.WriteLine(""
//        );
//    Console.WriteLine("uygulama çalışıyor");
//}


#endregion
#region goto 
// tavsiye edilmeyen goto keywordu sistemi yavaşlatır ve veri kaybı yapabilir oldukça maliyetlidir.
// görevi başa sardırıp tekrar kullanmak bir nevi sonsuz dögü sağlar 

//a:
//Console.WriteLine("merhaba");
//Console.WriteLine("burak");
//goto a;

//1 den 100 e kadar sayan program 
//int i = 1;
//x:
//Console.WriteLine(i++);
//if (i <= 100)
//    goto x;
// goto için scope önemli değildir her yerde tanımlanabilir.

#endregion