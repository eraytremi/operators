using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Atama ve işlemli atama******");
            // Atama ve işlemli atama
            int x=3;
            int y=3;
            y=y+2;
            y+=2;

            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x+=2;
            Console.WriteLine(x);

            Console.WriteLine("******Mantıksal operatörler******");
            //Mantıksal Operatörler
            // ||, &&, !

            bool isSucccess = true;
            bool isCompleted =false;

            if(isSucccess && isCompleted)        //ve
                Console.WriteLine("Perfect!");
            
            if(isSucccess || isCompleted)       // veya
                Console.WriteLine("Great!");
            
            if(isSucccess && !isCompleted)      // true ve true
                Console.WriteLine("Fine!");

            Console.WriteLine("******ilişkisel operatörler******");
            // ilişkisel Operatörler
            //<,>, <=,>=,==,!=    

            int a=3;
            int b=4;
            
            bool sonuc =a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("******aritmetik operatörler******");
            //aritmetik operatörler

            // /,*,+,-

            int sayi1 =10;
            int sayi2 =5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1++;                /// çıktının 11 olması gerekiyor ama terminal direkt sayının değerini atıyor!!
            Console.WriteLine(sonuc1);

            // % mod alır.
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

            






        }
    }
}