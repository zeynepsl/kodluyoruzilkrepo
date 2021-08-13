using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            String degisken = " ";//white space
            //hataya açık noktalardır
            if (degisken == "")//bu false döner
            {
            }
            DateTime now = DateTime.Now;
            DateTime dateTime = now;
            Console.WriteLine(dateTime);

            object o1 = "x";
            object o2 = '1';
            object o3 = 12;

            String str1 = string.Empty;
            str1 = "zeynep";
            String ad = "zeynep";
            String soyad = "slmn";
            str1 = ad + " " + soyad;

            bool b1 = 5 > 1; //true döner

            String str3 = "1";
            int int4 = 1;
            String str5 = str3 + int4.ToString(); // çıktı: 11

            int int5 = int4 + Convert.ToInt32(str3);//çıktı: 2

            int int6 = int4 + int.Parse(str3);//çıktı: 2
            //Parse: String çevirmek için

            //TARİH
            String dateTime2 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime2);

            String dateTime3 = DateTime.Now.ToString("dd/MM/yyyy");

            //SAAT
            String dateTime4 = DateTime.Now.ToString("hh.mm");
            Console.WriteLine(dateTime4);

        }
    }
}
