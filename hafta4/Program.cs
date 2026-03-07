#region ; ile sonsuz döngü
// ; oparötürü ile sonsuz dögüye girmek 
// while (true) ;
// for (; ; );
// do;
// while (true);
#endregion
#region diziler
//diziler referans türlü değerlerdir . özlerinde class yapısına sahiptirler . diziler tek boyutlu , çok boyutlu ve jagged (diğer adıyla çentikli) olmak üzere üçe ayrılırlar
// kalıp tip[] diziAdı = new tip[elemanSayısı];
// dizi tanımlama sürecinde   c# 11 ile birlikte dizilerde eleman sayısı belirtme zorunluluğu ortadan kalktı
// . artık diziler tanımlanırken eleman sayısı belirtilmeyebilir . bu durumda derleyici dizinin boyutunu otomatik olarak belirler .

// bu özellik sayesinde daha esnek ve dinamik diziler oluşturmak mümkün hale gelmiştir . örneğin :

//int[] sayilar = new int[7];
//sayilar[0]= 10;
//sayilar[1]= 11;
//sayilar[2]= 12;
//sayilar[3]= 13;
//sayilar[4]= 14;
//sayilar[5]= 15; // önemli not türüne uygun değişken ataması yapılmalıdır .
//sayilar[6]= 16; // önemli not : diziler sıfır tabanlıdır yani ilk eleman 0. indexe atanır ve son eleman dizinin boyutunun bir eksiği olan indexe atanır .
//sayilar[7]= 17; // hatalı kod örneği bu dizinin boyutu 7 olarak belirlendiği için 7. indexe erişmeye çalışmak hataya neden olur . 


// isimler dizisindeki isimler sırasıyla Ali , Veli , Ayşe , Fatma ve Ahmet olarak ekrana yazdıran program örneği :
//string[] isimler = new string[5];

//isimler[0] = "Ali";
//isimler[1] = "Veli";
//isimler[2] = "Ayşe";
//isimler[3] = "Fatma";
//isimler[4] = "Ahmet";
//for (int i = 0; i < isimler.Length; i++) // isimler dizisinin boyutunu belirten Length özelliği kullanılarak döngünün kaç kez çalışacağı belirlenir .
// bu sayede dizinin boyutu değişse bile döngü doğru şekilde çalışmaya devam eder .
//{ 

//   Console.WriteLine(isimler[i]);


//}                                        //for ile yapımı

//int i = 0;
//do 
//{
//    Console.WriteLine(isimler[i]);
//    i++;
//} while (i < 5);                        // do while ile yapımı



//int[] sayilar = new int[] { 10, 11, 12, 13, 14, 15, 16 }; // dizinin boyutu belirtilmeden elemanlar doğrudan atanabilir .
//int [] sayilar2 = { 10, 11, 12, 13, 14, 15, 16 }; // dizinin boyutu belirtilmeden elemanlar doğrudan atanabilir . bu durumda derleyici dizinin boyutunu otomatik olarak belirler .
//string[] isimler = new string[5] { "Ali", "Veli", "Ayşe", "Fatma", "Ahmet" }; // string türünde bir dizi tanımlanırken boyut ve elemanlar aynı anda belirlenebilir .

#endregion
#region array sınıfı
//array sınıfı = dizi , dizi = array

//Array array = new int[5];         // array sınıfından bir dizi oluşturuluyor . bu dizi int türünde 5 eleman içerebilir .

// dizi kendi türünde tutuluyorsa indexer de tutulur eğer arrayda tutulursa indexer tutulmaz .
// kendi türünde işlemler oparatif olarak yapılır . array sınıfında fonksiyonel olarak yapılır.

//array sınıfında bu varyasyon kullanılamaz 
//Array array = {3,5,4,6};          // array sınıfında diziyi tanımlarken elemanları doğrudan atamak mümkün değildir .

//Array dizi = new int[3];
//dizi.SetValue(10, 0);
//dizi.SetValue(20, 1);
//dizi.SetValue(30, 2);

//object value = dizi.GetValue(1);  // dizinin 0. indexindeki değeri alır ve value değişkenine atar . bu durumda value değişkeni 10 değerini alır .
//Console.WriteLine(value);         // getvalue ile alınan değer object türünde olduğu için istenirse uygun türe dönüştürülerek kullanılabilir . örneğin int türünde bir değişkene atanabilir 



// array sınıfı methodları :
//1. Array.Sort() : diziyi sıralamak için kullanılır .
//2. Array.Reverse() : diziyi tersine çevirmek için kullanılır .
//3. Array.IndexOf() : dizide belirli bir elemanın indexini bulmak için kullanılır .
//4. Array.Copy() : bir dizinin belirli bir bölümünü başka bir diziye kopyalamak için kullanılır .
//5. Array.Clear() : dizinin belirli bir bölümünü temizlemek için kullanılır .


// array sınıfı methodları örnekleri :
//array.clear // dizi içerisindeki tüm elemeanlara kendi türlerinden default(varsayılan) değer atayan bir fonksiyondur .

//Array isimler = new string[] { "Ali", "Veli", "kübra", "Fatma", "Ahmet" };

//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler.GetValue(i));
//}
//Array.Clear(isimler, 0, isimler.Length);
//Console.WriteLine("*************");
//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler.GetValue(i)); // isimler dizisinin tüm elemanlarını temizler . bu durumda dizinin tüm elemanları null değerini alır .
//} OR
//Array.Clear(isimler, 0,2);// yada (isimler, 0 , isimler.length)


//Array.Copy() : bir dizinin belirli bir bölümünü başka bir diziye kopyalamak için kullanılır .
//bu methodun üç parametresi vardır : kaynak dizi , hedef dizi ve kopyalanacak eleman sayısı . 

//string[] isimler2 = new string[isimler.Length];
//Array.Copy(isimler,isimler2 , isimler.Length);// bu örnekte isimler dizisinin tüm elemanları isimler2 dizisine kopyalanır .
//Array.Copy (isimler, 0, isimler2, 0, 2);// bu örnekte isimler dizisinin ilk iki elemanı isimler2 dizisine kopyalanır .
//for (int i = 0; i < isimler2.Length; i++)
//{
//    Console.WriteLine(isimler2[i]);
//}



//Array.IndexOf() : dizide belirli bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur .
// arama sonucunda ilgili değer varsa o değerin int olarak indexini döndürür . eğer aranan değer dizide yoksa -1 değeri döndürür .

//int index =Array.IndexOf(isimler, "burak"); 
//if (index != -1)
//    Console.WriteLine("Aranan değer dizide bulundu.");
//else Console.WriteLine("Aranan değer dizide bulunamadı.");
//// bu örnekte isimler dizisinde "burak" elemanı aranır . 

//int index2 = Array.IndexOf(isimler, "kübra" , 0,3);// bu örnekte isimler dizisinin ilk üç elemanında "kübra" elemanı aranır .


// array.reverse() : diziyi tersine çevirmek için kullanılır . bu methodun tek parametresi vardır : tersine çevrilecek dizi .


//for (int i = 0; i < isimler.Length; i++) ;
//    {
//    Console.WriteLine(isimler.GetValue(i));
//}Array.Reverse(isimler);
//Console.WriteLine("*************");

//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler.GetValue(i));// bu örnekte isimler dizisi tersine çevrilir .
//}
//
/*Array.Reverse(isimler, 0, 3); */// bu örnekte isimler dizisinin ilk üç elemanı tersine çevrilir .




// array.sort() : diziyi sıralamak için kullanılır . alfabetik sıralama yapar . bu methodun tek parametresi vardır : sıralanacak dizi .
//for (int i = 0; i < isimler.Length; i++) 
//{
//    Console.WriteLine(isimler.GetValue(i));
//}
//Array.Sort(isimler);
//Console.WriteLine("*************");

//for (int i = 0; i < isimler.Length; i++) 
//{
//    Console.WriteLine(isimler.GetValue(i)); // bu örnekte isimler dizisi alfabetik olarak sıralanır  .
//}


// array sınıfı özellikleri
// array.IsFixedSize : dizinin boyutunun sabit olup olmadığını belirten bir özelliktir .
// array.IsReadOnly : dizinin salt okunur olup olmadığını belirten bir özelliktir .
// array.Length : dizinin boyutunu belirten bir özelliktir . dizinin kaç eleman içerdiğini gösterir .
// array.Rank : dizinin boyut sayısını belirten bir özelliktir . tek boyutlu dizilerde rank değeri 1 , çok boyutlu dizilerde rank değeri 2 veya daha fazla olabilir .


//IsReadOnly  bir dizinini sadece okunabilir olup olmadığını bool türünde döndüren bir özelliktir .
//Console.WriteLine(isimler.IsReadOnly);

// IsFixedSize bir dizinin boyutunun sabit olup olmadığını bool türünde döndüren bir özelliktir .
//Console.WriteLine(isimler.IsFixedSize); // tüm dizierde eleman sayısı sabittir bu nedenle bu özellik tüm diziler için true değerini döndürür .

// Length bir dizinin boyutunu int türünde döndüren bir özelliktir .
//Console.WriteLine(isimler.Length); // isimler dizisinin boyutu 5 olduğu için bu özellik 5 değerini döndürür .

// Rank bir dizinin boyut sayısını int türünde döndüren bir özelliktir .
//Console.WriteLine(isimler.Rank); // isimler dizisi tek boyutlu bir dizi olduğu için bu özellik 1 değerini döndürür .

//int[,,] sayilar = new int[1,2,3];
//Console.WriteLine(sayilar.Rank); // sayilar dizisi üç boyutlu bir dizi olduğu için bu özellik 3 değerini döndürür .


//createInstance() : array sınıfının statik bir methodudur . bu methodun iki parametresi vardır :
//oluşturulacak dizinin türü ve dizinin boyutunu belirten bir int arrayi  .
//bu method belirtilen türde ve boyutta bir dizi oluşturur ve oluşturulan diziyi object türünde döndürür .
//bu method özellikle çalışma zamanında dinamik olarak dizi oluşturmak için kullanışlıdır .

//int[] boyutlar = new int[3] ;
// normalde yukarıdaki gibi yapılan dizi tanımlanması esasında arkaplanda array sınıfının createInstance methodu ile yapılır .
// bizlerde bu methodu kullanarak fonksiyonel olarak dizi oluşturabiliriz .
//Array boyutlar2 = Array.CreateInstance(typeof(int),3);

//ayrıca yine bu özellikle çok boyutlu dizilerde tanımlanabilir . örneğin :
//Array cokBoyutluDizi = Array.CreateInstance(typeof(int), 2, 3, 4 ); // bu örnekte üç boyutlu bir dizi oluşturulur .

#endregion
#region system index
//string [] isimler= new string[] { "Ali", "Veli", "kubra", "Fatma", "Ahmet" };
//Index index = ^2; // index türünde bir değişken oluşturulur ve bu değişkene ^2 değeri atanır . bu ifade dizinin sonundan ikinci elemanı temsil eder .                                                                           
// normalde ^ bu oparötör olmadan 2.İfade kubraya denk gelecektir . ancak ^ oparötürü kullanıldığında bu ifade dizinin sonundan ikinci elemanı temsil eder .
//^ bu ifade tersine index alınırken 0 dan değil 1 den başlar.

//int[] sayilar = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 19, 230 };

//Index index2 = 3;//*****^> bu şekilde soldan başlar 0,1,2,3 şeklinde ilerler  bu 13 verirken
// Index index = ^3;//******> bu şekilde sağdan başlar 3,2,1   şeklinde ilerler bu 17 verir.
//Console.WriteLine(sayilar[index]);

#endregion
#region  Range and Indices
// bir dizinin belirli bir aralığında çalısmak istenirese .. opartorü kullanılarak range türünde bir değişken oluşturulabilir .
//int[] sayilar = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 19, 230 };
//Range range = 2..5; // buradaki 2 indextir  5 ise sıra no dur yani bunun karsılıgı 12,13,14 verir .
//Range range = 2..^4; // bu örnekte 2 indextir ^4 ise dizinin sonundan 4. elemanı temsil eder .ama 4 . elemanı değil onu 
// atlayarak 15 i baz alır sağdaki .. dan sonra gelen eleman da ^ bu kullanılırsa sondaki sonucu atlar 
//Range range2 = ^2..^1;//  bu şekilde de kullanılır. 
// range kullanımı ilgili dizinin belirli bir bölümünü alır ve sana ayrı bir dizi olarak döndürür .
//Range range = 2..5;
//var sayilar2 = sayilar[range]; // bu örnekte sayilar dizisinin 2. indexinden başlayarak 5. indexe kadar olan elemanları içeren yeni bir dizi oluşturulur
// . bu yeni dizi 12,13 ve 14 değerlerini içerir .
//*sayilar2[0] = 100; // sayilar2 dizisinin 0. indexindeki değeri 100 olarak değiştirilir .
// bu değişiklik sayilar dizisini etkilemez çünkü sayilar2 dizisi sayilar dizisinden bağımsız bir dizi olarak oluşturulmuştur .

//Range range = ..; // bu şekilde dizinin tamamını temsil eden bir range oluşturulabilir .
//var sayilar2 = sayilar[range]; // bu örnekte sayilar dizisinin tamamını içeren yeni bir dizi oluşturulur . bu yeni dizi sayilar dizisiyle aynı elemanları içerir .

// tersine örnegi :
//Range range = ^7..^3;
//var sayilar2 = sayilar[range]; // bu örnekte sayilar dizisinin sonundan 7. indexinden başlayarak sonundan
// 3. indexe kadar olan elemanları içeren yeni bir dizi oluşturulur .
// bu yeni dizi 14,15,16 ve 17 değerlerini içerir .

#endregion
#region çok boyutlu diziler
// cok boyutlu diziler oyun yapımında yahut yüksek istatiksel verilerle çalışırken oldukça kullanışlı olabilirler . 
// çok boyutlu diziler tek boyutlu dizilerin dizisi olarak düşünülebilirler . çok boyutlu dizilerde her bir boyutun eleman sayısı belirtilmelidir .
// ornek olarak type [,,,] bu bir 4 boyutlu dizi tanımlamak için kullanılan bir kalıptır . "," sayısı arttıkca boyut sayısı artar kısaca virgül sayısı +1 dizinin boyutudur.
// 2 boyutludan fazla dizi tanımlama örneği :

//int[,,] sayilar = new int[3, 4, 5];

// tanımlanmış çok boyutlu diziye değer atama 
//  sayilar[0, 0, 1] = 10;
//  sayilar[0, 0, 2] = 11;
//  sayilar[0, 0, 3] = 12;
//  sayilar[0, 1, 0] = 13;
//  sayilar[0, 1, 1] = 14;
//  sayilar[0, 1, 2] = 15;
//  sayilar[0, 1, 3] = 16;
//  sayilar[0, 2, 0] = 17;
//  .
//  .
//  .
//Console.WriteLine(sayilar.Rank);
//Console.WriteLine(sayilar.Length);// ilgili dizinin tüm eleman sayısını verir . bu örnekte 3*4*5 = 60 eleman vardır .
//Console.WriteLine(sayilar.GetLength(0));
//Console.WriteLine(sayilar.GetLength(1));
//Console.WriteLine(sayilar.GetLength(2));// getlength methodu ilgili boyuttaki eleman sayısını verir

// düzensiz diziler 

// düzensiz diziler her bir elemaanı kendi içinde farklı bir dizi barındıran dizilerdir.
// çok boyutlu dizilerin tek farkı sütun sayılarının değişkeen olmasıdır.
int[][]sayilar=new int[3][];
sayilar[0] = new int[4] {3,5,7,6 };
sayilar[1] = new int[5] { 10, 11, 12, 13,14 };
sayilar[2] = new int[3] { 17, 19, 230 };

//Console.WriteLine(sayilar[0][0]);
//sayilar[0][0] = 100;
//Console.WriteLine(sayilar[0][0]);

//Console.WriteLine(sayilar[0].Length + sayilar[1].Length+ sayilar[2].Length);// bu dizinin toplam eleman sayısını verir

for(int i = 0; i < sayilar.Length; i++)
{
    for (int j = 0; j < sayilar[i].Length; j++)
    {
        Console.Write(sayilar[i][j] + "    -    ");
    }
    Console.WriteLine();
}
#endregion