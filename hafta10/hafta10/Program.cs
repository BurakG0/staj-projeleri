#region static constructor
// bir sınıfta nesne üretilirken ilk tetiklenen fonksiyondur.
// ilgili sınıftan ilk nesne üretilirken tetiklenen fonksiyondur.üretilen ilk nesnenin dışında bir daha tetiklenmez.
// static constructor'lar parametre almazlar ve erişim belirleyicisi olmaz.
// static constructor tetiklenmesi için illa ilk nesne üretilmesi gerekmez. static bir üye çağırıldığında da tetiklenebilirler.

//class myclass
//{
//    public static int sayi;
//    public myclass()
//    {
//        Console.WriteLine("constructor tetiklendi");
//    }
//    static myclass()
//    {
//        Console.WriteLine("static constructor tetiklendi");
//        sayi = 10;
//    }
//}


#endregion
#region positional record
//  Positional record'lar, sınıf benzeri bir yapıya sahip olup, otomatik olarak özellikler, yapıcılar ve diğer üyeler oluşturur.
//  Positional record'lar, genellikle "record" anahtar kelimesiyle tanımlanır ve özellikler, yapıcı parametreleri olarak belirtilir.
// bu property'ler otomatik olarak oluşturulur ve genellikle "init" erişim belirleyicisi kullanılarak tanımlanır.

//static void Main(string[] args)
//{
//   myrecord m = new myrecord("burak", 25);
//    var (n,a) = m;
//}
//record myrecord(string name, int age)
//{ };

#endregion
#region kalıtım inheritance
// C#'ta kalıtım, bir sınıfın başka bir sınıftan özellikler,
// yöntemler ve diğer üyeleri devralmasını sağlayan bir nesne yönelimli programlama (OOP) özelliğidir.
// Kalıtım, kodun yeniden kullanılabilirliğini artırır ve hiyerarşik ilişkileri modellemek için kullanılır.
// sınıflar arasında kalıtım ilişkisi kurmak için ":" operatörünü kullanırız.

//bmw bmw = new bmw();
//ford ford = new ford();
//audi audi = new audi();
//bmw.marka = "BMW";
//bmw.model = "m8";
//bmw.yil = 2023;
//ford.marka = "Ford";
//ford.model = "Mustang";
//ford.yil = 2022;
//bmw.amblem = "BMW amblemi";

//class araba 
//{
//    public string marka;
//    public string model;
//    public int yil;

//}
//class bmw : araba 
//{
//    public string amblem {  get; set; }

//}
//class ford : araba
//{
//    public string lastikmarkasi { get; set; }

//}
//class audi : araba
//{
//    public string farboyutu { get; set; }

//}
// bir sınıfın sadece 1 tane base class'ı olabilir. ancak bir sınıf birden fazla derived class'a sahip olabilir.
// yani çoklu kalıtım yoktur.hem base class hem de derived class olabilirler.
// yani bir sınıf hem başka bir sınıftan kalıtım alabilir hem de başka bir sınıfa kalıtım verebilir.

//class buyukbaba        // base class, parent class, super class
//{

//}
//class baba : buyukbaba // base class'ı buyukbaba, derived class'ı baba
//{

//}
//class ogul : baba      // base class'ı baba, derived class'ı ogul
//{

//}
// new D(); // D sınıfından bir nesne oluşturulduğunda, A, B, C ve D sınıflarının yapıcıları sırasıyla tetiklenir.
// D den bir nesne oluşturulduğunda, önce A sırasıyla istenilen sınıfa gelene kadar nesne oluşturulur ve her sınıfın yapıcısı tetiklenir.

//class A 
//{
//    public A()
//    {
//        Console.WriteLine($"{nameof(A)}  nesnesi oluşturulmuştur");
//    }
//}
//class B : A
//{
//    public B()
//    {
//        Console.WriteLine($"{nameof(B)}  nesnesi oluşturulmuştur");
//    }
//}
//class C : B
//{
//    public C()
//    {
//        Console.WriteLine($"{nameof(C)}  nesnesi oluşturulmuştur");
//    }
//}
//class D : C
//{
//    public D()
//    {
//        Console.WriteLine($"{nameof(D)}  nesnesi oluşturulmuştur");
//    }
//}
#region base keyword
// base keyword'ü, bir sınıfın temel sınıfına (base class) erişmek için kullanılır.
// Bu, temel sınıfın üyelerine erişmek veya temel sınıfın yapıcılarını çağırmak için kullanılır.

//new myclass2(); // myclass2 sınıfından bir nesne oluşturulduğunda, mylass sınıfının yapıcısı da tetiklenir ve 10 değeri ile çağrılır.
//class mylass 
//{
//    public mylass(int a)
//    {
//    }
//}
//class myclass2 : mylass
//{
//    public myclass2(int a) : base(a)
//    {

//    }
//    public myclass2() : base(10)
//    {
//    }
//}
// this ile arasındaki fark   this, aynı sınıf içindeki üyeleri ifade ederken, base, temel sınıfın üyelerini ifade eder.


#endregion

#endregion
#region name hiding
// name hiding, bir alt sınıfın, temel sınıfında tanımlanmış bir üyenin adını gizlemesini sağlar.
// Bu, alt sınıfın üyesi temel sınıfın üyesiyle aynı adı taşıdığında ortaya çıkar.

#endregion
#region virtual, override
// virtual keyword'ü, bir sınıfın bir üyesinin (yöntem, özellik, olay vb.) alt sınıflar tarafından geçersiz kılınabileceğini belirtmek için kullanılır.
// override keyword'ü, bir alt sınıfın, temel sınıfında virtual olarak işaretlenmiş bir üyeyi geçersiz kılmak için kullanılır.

// sanal yapılar , bir sınıfın belirli üyelerinin alt sınıflar tarafından özelleştirilebilmesini sağlar.

//static void Main(string[] args)
//{
//    inek i = new inek();
//    i.mymethod();
//    maymun my = new maymun();
//    my.mymethod();
//}

//class memeli 
//{
//    public virtual void mymethod()
//    {
//        Console.WriteLine("memeli hayvan");
//    }
//}

//class inek : memeli
//{
//    public override void mymethod()
//    {
//        Console.WriteLine("inek hayvan");
//    }
//}

//class maymun : memeli
//{
//    public override void mymethod()
//    {
//        Console.WriteLine("maymun hayvan");
//    }
//}
#endregion
#region polimorfizm
// çok biçimliliktir. örneğin kuş türü tavukta bir kuştur kartalda bir kuştur .
// Polimorfizm, bir nesnenin farklı şekillerde davranabilme yeteneğidir.
// Polimorfizm, genellikle kalıtım ve sanal yapılar (virtual) ile birlikte kullanılır.
// Polimorfizm, bir sınıfın birden fazla alt sınıfı olduğunda ortaya çıkar ve aynı temel sınıf referansını kullanarak farklı alt sınıf nesnelerini işleyebilme yeteneği sağlar.
// Polimorfizm kullanabilmek için kalıtım ve sanal yapılar (virtual) gereklidir. 

//İnsan i = new Erkek();// polimorfizm sayesinde erkek nesnesi insan türünde de tanımlanabilir.
//Erkek E = new Erkek();// polimorfizm sayesinde erkek nesnesi insan türünde de tanımlanabilir.
//İnsan k = new Kadın();// polimorfizm sayesinde kadın nesnesi insan türünde de tanımlanabilir.

//class İnsan
//{

//}
//class Erkek : İnsan
//{

//}
//class Kadın : İnsan
//{

//}

// dinamik polimorfizm : çalışma zamanında hangi methodun çalışacağını belirler. virtual ve override keyword'leri ile sağlanır. 

// static polimorfizm  : derleme zamanında hangi methodun çalışacağını belirler. method overloading ile sağlanır.
// aynı isimde farklı parametreler alan methodlar oluşturulabilir. derleyici hangi methodun çalışacağını belirler.

// polimorfizm tür dönüşümü : bir nesnenin türünü başka bir türe dönüştürme işlemidir. 

//C c = new C(); // c nesnesi C türünde oluşturulur.
//A a = c; // c nesnesi A türüne dönüştürülür. bu işleme upcasting denir. upcasting, bir nesnenin alt sınıf türünden üst sınıf türüne dönüştürülmesidir.
//         // upcasting, her zaman güvenlidir çünkü alt sınıf türü, üst sınıf türünün tüm özelliklerini içerir.

//A a2 = new C(); // a2 nesnesi A türünde oluşturulur.Cast öperatorü kullanılarak dönüşüm sağlamayamazsa runtime hatası verir
//C c2 = a2 as C; // a2 nesnesi C türüne dönüştürülür. bu işleme downcasting denir. downcasting, bir nesnenin üst sınıf türünden alt sınıf türüne dönüştürülmesidir.
//                // as operatorü, dönüşüm başarısız olursa null döner.

//class A{}
//class B:A { }
//class C:B { }




#endregion
#region Association-Aggregation-Composition
// Association, Aggregation ve Composition, nesne yönelimli programlamada nesneler arasındaki ilişkileri tanımlamak için kullanılan kavramlardır.
// association, iki nesne arasında zayıf bir ilişkiyi ifade eder. Bir nesne diğerini kullanabilir, ancak her iki nesne de birbirinden bağımsızdır.
// aggregation, bir nesnenin diğerini içerdiği ancak her iki nesnenin de bağımsız olduğu bir ilişkiyi ifade eder. Bir nesne diğerini kullanabilir ve her iki nesne de birbirinden bağımsızdır.
// composition, bir nesnenin diğerini içerdiği ve her iki nesnenin de birbirine bağımlı olduğu bir ilişkiyi ifade eder. Bir nesne diğerini kullanabilir ve her iki nesne de birbirine bağımlıdır.

#endregion
#region sealed keyword
// bir sınıfın miras vermesini yani başka bir sınıf tarafından miras alınmasını engelleyen bir keyworddur.
// sadece sınıflarda ve sadece override edilmiş methodlarda kullanılabilir.
// kalıtımsal durumlarda atalardan gelen birincil dereceden alt sınıf tarafından override edilmiş olan virtual methodların daha alt sınıflar tarafından override edilmesini engellemek için kullanılır.

//sealed class A { } sealed record C { } // recordlarda temelinde bir class olduğu için recordlar da da kullanabilir.
//class B : A{ } // kalıtım alması engellendiği için hata veriyor .

// ******************************************

//class A {
//    public virtual void mymethod()
//    {
//        Console.WriteLine("A sınıfının mymethodu");
//    }
//}
//class B : A
//{
//    public sealed override void mymethod()
//    {
//        Console.WriteLine("B sınıfının mymethodu");
//    }
//}
//class C : B
//{
//    public override void mymethod() // B sınıfında mymethodu sealed olarak işaretlediğimiz için C sınıfında override edemeyiz. hata verir.
//    {
//        Console.WriteLine("C sınıfının mymethodu");
//    }
//}
#endregion
#region partial yapılanmalar
// Bir classın struckını , interfacesin aynı yahut farklı dosyalarda birden fazla parçasını tasarlamasını ve bu parçaların özünde bir bütün olarak kullanılmasını 
//sağlayan kodun daha organize ve kolay okunabilirliğini arttıran bir özelliktir.
// parça olmasını istenilen tüm parçalar işaretlenmelidir.

//new A();
// partial class 

//partial class A 
//{
//    partial class B
//    {
//        public void C() { }
//    }
//}
//partial class A 
//{
//    partial class B
//    {
//        public void D() { }
//    }
//}

// partial record
//partial record A { }
//partial record A { } 

// partial abstract
//abstract partial class A { }
//abstract partial class A { }

// partial struct
//partial struct A{ }
//partial struct A{ }

// partial interface 
//partial interface A { }
//partial interface A { }

#endregion
#region absstarction
// abstraction, nesnelerin karmaşıklığını gizleyerek sadece gerekli bilgileri sunma işlemidir.
// Abstraction, genellikle abstract sınıflar ve arayüzler (interfaces) kullanılarak gerçekleştirilir.
#endregion
#region abstract class
// bir sınıfın uyması gereken temel yapıyı tanımlamak için abstract class yapısı kullanılabilir ve gerekli modellemeyi gerçekleştirebiliriz.
// abstract class, soyut sınıf olarak da bilinir ve doğrudan örneklenemezler.
// abstract sınıflar, alt sınıflar tarafından kalıtım yoluyla genişletilmek üzere tasarlanmıştır ve genellikle soyut yöntemler (abstract methods) içerirler.
// abstract method'lar, alt sınıflar tarafından geçersiz kılınması gereken yöntemlerdir ve gövdesi olmayan yöntemlerdir.
// abstract class larda iradeli bir şekilde nesne oluşturulamaz ancak referans tutabilirler.
// kalıtımsal olarak bir abstract class herhangi bir sınıfa miras verdiğinde o sınıftan üretilen nesne abstract class da da nesne üretilmesine yol açar.

//A a = new B(); // oluşturulan B nesnesine A yı referans ettik.
//abstract class A
//{
//    public A()
//    {
//        Console.WriteLine(" A abstract class nesnesi");
//    }
//} 
//class B:A // abstract classa kalıtım yaptık
//{
//    public B()
//    {
//        Console.WriteLine(" B class nesnesi");
//    }

//}

// bir abstract class implement edecek olan sınıflarda zoraki tanımlanması için  abstract methodların gövdesi yazılmak zorundadır.
// aksi takdirde hata verirler.
// zoraki uygulattıralacak methodlar override edilmek zorundadır. 

//abstract class A
//{
//    public abstract void mymethod(); // abstract method
//    public void mymethod2() { }// normal method
//    public int mymethod3 { get; set; }
//    abstract public int mymethod4 { get; set; } // abstract property
//    abstract public int Mymethod5 { get; set; } // abstract property
//}
//class B : A // kısayol Ctrl + . yaparak implement members seçilir. sonradan eklenecekler için tekrar kısayol ile implement members seçilir.
//{
//    public override int mymethod4 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public override int Mymethod5 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//    public override void mymethod()
//    {
//        throw new NotImplementedException();
//    }
//}


// abstract classlar kendi türlerindeki classlara kalıtım verebilirler.

//abstract class A
//{
//    abstract public void Z(); // abstract method
//    abstract public int X { get; set; } // abstract property
//}
//abstract class B : A // B sınıfı A sınıfından kalıtım alır. B sınıfı da abstract olduğu için A sınıfındaki abstract methodları ve propertyleri implement etmek zorunda değildir.
//{
//    public void V() { }
//    abstract public void Y(); // abstract method
//}
//class C : B // implement ederken B deki abstract methodu ve A daki abstract methodu implement etmek zorundayız.
//{
//    public override int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//    public override void Y()
//    {
//        throw new NotImplementedException();
//    }

//    public override void Z()
//    {
//        throw new NotImplementedException();
//    }
//}

#endregion
#region interface  
// interface abstract class gibi çalışır .
// abstract class'ların aksine, interface'ler sadece üyelerin imzalarını içerir ve gövdesi olmayan yöntemler ve özellikler tanımlarlar.
// interface'ler, bir sınıfın belirli bir davranışı uygulamasını sağlamak için kullanılır ve genellikle çoklu kalıtım durumlarında tercih edilirler.
// override edilmesi gerekmez ve zorunlu değildirler. implement eden sınıf isterse override eder isterse etmez. ancak implement eden sınıfın interface de tanımlanan üyeleri implement etmesi gerekir. aksi takdirde hata verirler.
// interface'ler sınıfların imzasıdır.
// kısayol Ctrl + . yaparak implement members seçilir. sonradan eklenecekler için tekrar kısayol ile implement members seçilir.
// birden çok interface implement edilebilir. ancak bir sınıf sadece bir abstract class'a kalıtım alabilir. yani çoklu kalıtım yoktur ancak çoklu interface implementasyonu vardır.


//interface Interface 
//{
//    void X();
//    void Y(int a );
//     int Z { get; set; }
//}
//interface Interface2
//{
//    void V();
//    void W(int a);
//    int T { get; set; }
//}
//abstract class myabstra : Interface
//{
//    abstract public int X();
//    abstract public int Y(int a);

//    void Interface.X()
//    {
//        throw new NotImplementedException();
//    }

//    void Interface.Y(int a)
//    {
//        throw new NotImplementedException();
//    }

//    abstract public int Z { get; set; }
//}
//class A : Interface, Interface2 // A sınıfı Interface ve Interface2 interface'lerini implement eder.
//{
//    public int T { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
//    public int Z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//    public void V()
//    {
//        throw new NotImplementedException();
//    }

//    public void W(int a)
//    {
//        throw new NotImplementedException();
//    }

//    public void X()
//    {
//        throw new NotImplementedException();
//    }

//    public void Y(int a)
//    {
//        throw new NotImplementedException();
//    }
//}
#endregion
