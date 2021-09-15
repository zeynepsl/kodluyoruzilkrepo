using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Atama ve İşlemli Atama Operatorler"); 
            // •	Atama ve İşlemli Atama
            int a = 1;
            int b = 2;
            b = b + 2;
            Console.WriteLine(b);

            b += 2;// işlemli atama
            Console.WriteLine(b);

            b /= 2;
            Console.WriteLine(b);

            a *= 2;
            Console.WriteLine(a);

            Console.WriteLine("*** Mantiksal Operatorler"); 
            // Mantıksal Operatörler (||, &&, !)

            if(a < b || a!=b)
            //multiple line için curly braces
            {
                Console.WriteLine("if çalıştı");
            }
            else if(a < b && a==b){
                Console.WriteLine("else if çalıştı");
            }
            else{
                Console.WriteLine("else çalıştı");
            }

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
               Console.WriteLine("perfect");

            if(isSuccess || isCompleted)
               Console.WriteLine("great");

            if(isSuccess || !isCompleted)//isSucces ise ve isCompleted değilse
            //true || !(false)
               Console.WriteLine("fine");

            Console.WriteLine("*** Iliskisel Operatorler");             
            //ilişkisel operatorler

            int x = 3;
            int y = 4;
            bool sonuc = x<y;
            Console.WriteLine(sonuc);
            
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            
            sonuc = a<=b;
            Console.WriteLine(sonuc);

            sonuc = a==b;
            Console.WriteLine(sonuc);
            
            sonuc = a!=b;
            Console.WriteLine(sonuc); 

            Console.WriteLine(sonuc);

            Console.WriteLine("*** Aritmetik Operatorler");  
            // * + - / %
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
    
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi2++;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 % sayi2;
            Console.WriteLine(sonuc1);
        }
    }
}
