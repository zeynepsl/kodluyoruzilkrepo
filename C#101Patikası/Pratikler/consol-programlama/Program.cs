using System;
//System name space i altında Console sınıfı var
namespace consol_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {        
            Console.WriteLine("Hello World!");

            Console.WriteLine("İsminizi girin: ");
            String name = Console.ReadLine();
            
            Console.WriteLine("Soy isminizi girin: ");
            String surName = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surName);
        }
    }
}
