using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int a = 10, b = 20; // aynı türden birden fazla değişken tanımlama ve atama 

            int a = 15;
            int b = a;
            a = a * 5;
            Console.WriteLine(a); 
            Console.WriteLine(b);//derin kopyalama örneği 

            
            object _yas = 25; //boxing işlemi

            int yas= (int)_yas; //unboxing işlemi
            Console.WriteLine(yas*5);//casting işlemi örneği */

            var a = 5; var b=6; var c = 7;
            Console.WriteLine($"a: {a}, b: {b}, c: {c}"); //var türünde birden fazla değişken tanımlama ve ekrana yazdırma







            /*  const double pi = 3.14159; //sabit tanımlama
             #region değişkenler
             int a = 10;
             string b = "Merhaba";
             double c = 3.14;
             float d = 2.5f;
             decimal e = 10.5m;
             bool f = true;
             short g = 100;
             char h = 'A';
             long j = 1000000;
             #endregion    //değişken türleri ve örnekler

             var tuple = (a: 40000, b: "burak", c: 32.7, d: d, e: e, f: f, g: (short)24, h: h, j: j); //tuple tanımlama ve atama
             Console.WriteLine($"Tuple Değerleri: {tuple.a}, {tuple.b}, {tuple.c}, {tuple.d}, {tuple.e}, {tuple.f}, {tuple.g}, {tuple.h}, {tuple.j}"); //tuple değerlerini ekrana yazdırma

             var zx = (z: 10, x: 'Z'); //tuple değişkenine değer atama
             int bigNumber = 1_000_000; //kompleks sayılar için alt çizgi kullanarak okunabilirliği artırma

             int a = default(int);
                bool f = default(bool); //default değer atama */



        }
    }
}

