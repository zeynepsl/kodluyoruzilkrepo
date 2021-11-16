using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            byte a=5;
            sbyte b=30;
            short c = 10;

            int d = a + b + c; //int kapasitesi byte, sbyte, short veri tiplerinin kapasitesinden fazladır.
            Console.WriteLine("d sayisinin degeri: " + d);

            long h = d;
            Console.WriteLine("h sayisinin degeri: " + h);

            float i = h;
            Console.WriteLine("i sayisinin degeri: " + i);

            string isim = "zeynep";
            char karakter = 'z';
            object g = d + isim + karakter;//45zeynepz
            //tüm veri tipleri Object ten türer
            //üst bir veri tipidir
            Console.WriteLine("g'nin degeri: " + g);

            //explicit conversion
            //Veri kaybı olabilir

            int x = 4;
            //byte y = x;//bu hatalı
            byte y = (byte)x; // int'i byte'a çevirir.
            Console.WriteLine("y'nin degeri: " + y);
            int z =100;
            byte t = (byte)z;
            Console.WriteLine("t'nin degeri: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v'nin degeri: " + v);

            //ToString()
            int sayi = 6;
            string metin = sayi.ToString();
            Console.WriteLine("metin: " + metin);

            string metin2 = Convert.ToString(12.5f);//floatı stringe çevirme
            
            //System.Convert
            // string metin3 = "zeynep", metin4 = "tuba";
            // int sayi1, sayi2;
            // int toplam;

            // sayi1 = Convert.ToInt32(metin3);
            // sayi2 = Convert.ToInt32(metin4);   

            // toplam = sayi1 + sayi2;
            // Console.WriteLine("toplam: " + toplam);

            //Parse -> string'2 dönüştürmek için
            static void ParseMethod(){
                //string metin1 = "10";
                string metin2 = "10.25";
                //int rakam1;
                double double1;

                //araştırılacak:
                //rakam1 = int.Parse(metin1); bu hocanın örnekleriyle hata veriyor
                
                double1 = Double.Parse(metin2);

                Console.WriteLine(double1);

            }
            ParseMethod();
        }
    }
}
