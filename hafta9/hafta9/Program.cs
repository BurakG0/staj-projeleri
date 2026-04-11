#region class ornek

//class ornek 
//{
//    int a , b;

//    public void ornekMetod()
//    {
//        Console.WriteLine("Bu bir örnek metottur.");

//    }
//    public int ornekMetod2()
//    {
//        Console.WriteLine("Bu da ikinci örnek metottur.");
//        return a + b;
//    }
//}
#endregion
#region iç içe class 
//class ornek1 
//{
//    class ornek2 { }

//}

#endregion
#region teorik bilgiler 
// field : class içerisinde tanımlanan değişkenlerdir.Nesne içerisinde değer tutarlar.methodlarda tanımlanırsa field olmazlar.

//ornek nesne1 = new ornek(); // nesne1 adında ornek sınıfından bir nesne oluşturduk.
//nesne1.a = 5; // nesne1 nesnesinin a fieldına 5 değerini atadık.
//nesne1.b = 10;
//ornek nesne2 = new ornek();
//nesne2.a = 15;
//nesne2.b = 30; 
//class ornek
//{

//    public int a, b;

//}

#endregion ,
#region property
//  property : fieldlara benzerler ama fieldlardan farklı olarak değer ataması yaparken veya değer okurken ek işlemler yapmamızı sağlarlar.  
//  propertyler get ve set bloklarından oluşur. get bloğu değer okurken çalışır, set bloğu ise değer atarken çalışır.
// propertyler sayesinde fieldlara değer atarken veya değer okurken ek işlemler yapabiliriz. örneğin bir propertynin set bloğunda değer atarken bir koşul kontrolü yapabiliriz.
// property hangi türde bir fieldı temsil ediyorsa o türde tanımlanır.
#region full property
//class ornek
//{

//    int a; // field
//    public int A // property
//    {
//        get
//        { 
//            return a; 
//        } // değer okurken çalışır


//        set // değer atarken çalışır
//        {
//            a = value;
//        }
//    }
//}
#endregion
#region prop property

//class ornek
//{
//    int a; 
//    string b;
//    public int Ornek { get; set; } = 15; // prop property

//}
#endregion
#region indexer
// indexer : bir sınıfın nesnelerine dizi elemanı gibi erişmemizi sağlayan yapılardır. indexerlar this anahtar kelimesi ile tanımlanır.
//class ornek 
//{
//    int[] dizi = new int[5];
//    public int this[int index] // indexer
//    {
//        get
//        {
//            return dizi[index];
//        }
//        set
//        {
//            dizi[index] = value;
//        }
//    }
//}

#endregion
#endregion
#region class elemanlarına açıklama satırları ekleme
/// <summary>
/// bu bir örnek sınıftır.
/// </summary>
#endregion
#region this keyword
// this keyword : bir sınıfın kendi nesnesine erişmek için kullanılır. this anahtar kelimesi ile sınıfın kendi nesnesine erişebiliriz.
// this anahtar kelimesi genellikle fieldlara erişmek için kullanılır.
// this anahtar kelimesi ile fieldlara erişirken fieldların isimleri ile propertylerin isimleri aynı olabilir.
// bu durumda this anahtar kelimesi ile fieldlara erişebiliriz. 
//class ornek
//{
//    int a; // field
//    public int A // property
//    {
//        get
//        {
//            return a;
//        }
//        set
//        {
//            a = value;
//        }
//    }
//    public void ornekMetod()
//    {
//        this.a = 10; // this anahtar kelimesi ile fielda eriştik.
//        Console.WriteLine(this.a); // this anahtar kelimesi ile fielda eriştik.
//    }
//}



#endregion
#region object initializer
// object initializer : bir sınıfın nesnesini oluştururken fieldlara veya propertylere değer atamak için kullanılan bir yapıdır.
//class ornek 
//{
//    public int a { get; set; }
//    public string b { get; set; }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        ornek nesne1 = new ornek() { a = 5, b = "merhaba" }; // object initializer ile nesne oluşturduk ve fieldlara değer atadık.

//    }

//} 

#endregion
#region shallow copy
// shallow copy varolan bir değerin referansının kopyalanmasıdır .eldeki değer çoğalmaz sadece referansla işaretler 
//myclass m1 = new myclass();
//myclass m2 = m1;
//myclass m3 = m2;
//myclass m4 = new myclass();
//class myclass { }
#endregion
#region deep copy 
// ilgiili nesne miktarını çoğaltır . bellekte aynı değerlere sahib başka bir nesne oluşur.

//myclass m1 = new myclass();
//myclass m2 = m1.Clone(); // Clone metodu ile m1 nesnesinin bir kopyasını oluşturduk ve m2 nesnesine atadık.

//class myclass 
//{
//    public myclass Clone () 
//    {
//        return(myclass)this.MemberwiseClone(); // MemberwiseClone metodu ile deep copy yaparak yeni bir nesne oluşturduk.
//    }
//}


#endregion
#region encapsulation
// nesnedeki fieldlara doğrudan erişimi engelleyip, bu fieldlara erişmek için propertyler veya metodlar kullanarak veri gizleme işlemine encapsulation denir.
// Encapsulation sayesinde nesnenin iç yapısını gizleyebiliriz ve sadece gerekli olan bilgileri dışarıya açabiliriz.
// Bu da nesnenin güvenliğini artırır ve hataların önlenmesine yardımcı olur.

//class myclass  
//{

//	private int myVar;// field


//    public int MyProperty// property
//    {
//		get { return myVar; }// değer okurken çalışır
//        set { myVar = value; }// değer atarken çalışır
//    }

//} // propfull yazaran Tab Tab yaptığında otomatik olarak property oluşturur ve fieldı da tanımlar.

#endregion
#region init only property
// init only  nesnelerin ilk yaratılış anında değer atamakta runtime da değeri değişmez
//class book
//{
//    public string name { get; init; } = "burak";
//    public string surname { get; init; }
//    public book()
//    {
//        surname = "günay";
//    }

//}

//using System.Runtime.InteropServices;

//static void Main(string[] args)
//{
//    myclass my = new myclass { mypro = 3 };
//}
//class myclass { public int mypro { get; init; } = 3; }
#endregion
#region record 
// record : referans tiplerdir ama değer tipleri gibi davranırlar.
// recordlar immutable (değiştirilemez) yapılardır. recordların fieldları readonly olarak tanımlanır ve sadece constructor ile değer atanabilir.
// nesnelerden ziyade verileri temsil etmek için kullanılırlar.
// class ile aralarında çok benzerlik vardır ama recordlarda fieldlar readonly olduğu için classlarda yapılan bazı işlemler recordlarda yapılamaz.
// örneğin bir recordun fieldına değer atayamazsınız ama bir classın fieldına değer atayabilirsiniz.

//record ornek
//{
//    public int a { get; init; }
//    public string b { get; init; }
//    public void ornekMetod()
//    {
//        Console.WriteLine("Bu bir örnek metottur.");
//    }}


//Myrecord m = new Myrecord
//{ prop1 = 5, prop2 = 10 }
//;
//Myrecord m2 = m with { prop2 = 15 };

//record Myrecord
//{
//    public int prop1 { get; init; }
//    public int prop2 { get; init; }
//}



#endregion
#region constructor

// yapıcı / inşa edici / constructor : bir sınıfın nesnesi oluşturulurken çalışan özel bir metottur.
// constructorlar sınıf ile aynı isimde tanımlanır ve geri dönüş tipi olmaz.     
// her classın en az bir tane default constructoru vardır. biz tanımladığımızda default constructor ortadan kalkar ezmiş oluruz .
// privete constructor : bir sınıfın nesnesinin oluşturulmasını engellemek için kullanılan bir yapıdır.
// this constructor : bir constructorun başka bir constructoru çağırmasıdır. this anahtar kelimesi ile constructorlar arasında geçiş yapabiliriz.

//class myclass
//{
//    public myclass(int a) :this() // this constructor ile default constructoru çağırdık.
//    {
//        Console.WriteLine("Bu bir constructor metottur."+a);
//    }
//    public myclass() // constructor
//    {
//        Console.WriteLine("ornek ");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
// new myclass(); // myclass sınıfından bir nesne oluşturduk ve constructor metodu çalıştı.
//myclass m = new (10,15);
//    }
//}

//class myclass
//{
//    public myclass() // constructor
//    {
//        Console.WriteLine("1.constructor");
//    }
//    public myclass(int a) : this() // this constructor ile default constructoru çağırdık.
//    {
//        Console.WriteLine($"2.constructor: {a}");
//    }
//    public myclass(int a, int b) : this(a) // this constructor ile int parametreli constructoru çağırdık.
//    {
//        Console.WriteLine($"3.constructor: {a}, {b}");
//    }
//}


// record myrecord  // recordlarda da aynı şekilde constructor tanımlayabiliriz.this keywordu ile constructorlar arasında geçiş yapabiliriz.
// {
//    public int a { get; init; }
//    public int b { get; init; }
//    public myrecord() // default constructor
//    {
//        Console.WriteLine("default constructor");
//    }
//    public myrecord(int a) : this() // this constructor ile default constructoru çağırdık.
//    {
//        Console.WriteLine($"int parametreli constructor: {a}");
//    }
//    public myrecord(int a, int b) : this(a) // this constructor ile int parametreli constructoru çağırdık.
//    {
//        Console.WriteLine($"int, int parametreli constructor: {a}, {b}");
//    }
// }

#endregion
#region destructor
// destructor : bir sınıfın nesnesi bellekten silinirken çalışan özel bir metottur.
// destructorlar sınıf ile aynı isimde tanımlanır ve geri dönüş tipi olmaz.
// destructorlar sadece classlarda tanımlanabilirler recordlarda tanımlanamazlar.
// destructorlar static olamazlar. destructorlar parametre alamazlar. destructorlar sadece bir tane olabilirler.
// destructorların erişim belirleyicisi olmaz, her zaman private olarak kabul edilirler.
// nesne imha ederken otomatik olarak çalışırlar, biz destructorları manuel olarak çağırmayız.

//class Program
//{
//    static void Main(string[] args)
//    {
//        X();
//        GC.Collect(); // garbage collector devreye sokmak ( tavsiye edilmez ).
//        Console.ReadLine();
//    }
//    static void X() 
//    {
//        myclass m = new myclass();
//    }
//}
//class myclass
//{
//    public myclass()// constructor
//    {
//        Console.WriteLine("nesne oluşturuldu");
//    } 
//    ~myclass()// destructor
//    {
//        Console.WriteLine("nesne imha edildi");
//    } 
//}

// ***************************************************

//class Program
//{
//    static void Main(string[] args)
//    {
//        int sayi = 100;
//        while (sayi >=1 ) 
//        {
//            new myclass(sayi--); 
//        }

//        Console.WriteLine("***************");
//        GC.Collect();
//        Console.ReadLine();
//    }

//}

//class myclass
//{
//    int no;
//    public myclass(int no) 
//    {
//        this.no = no;
//        Console.WriteLine($"{no} . nesne oluşturuldu.");
//    }
//    ~myclass()
//    {
//        Console.WriteLine($"{no} . nesne imha edildi.");
//    }
//}
#endregion
#region deconstruct methodu
// deconstruct ismiyle tanımlanan method sınıfın nesnesi üzerinden hızlı bir şekilde geriye tuple değer döndürmeye olanak tanır .

//class Program
//{
//    static void Main(string[] args)
//    {
//        Person p = new Person
//        {
//            Name = "burak",
//            Age = 25
//        };
//        var (x, y) = p ;
//    }

//}
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public void Deconstruct(out string name, out int age)
//    {
//        name = Name;
//        age = Age;
//    }
//}
#endregion
#region static constructor

#endregion