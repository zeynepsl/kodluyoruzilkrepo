using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi girin: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sayi:" + sayi);
            }
            //hata Alırsak hata mesajını yazdır:
            catch (Exception ex)
            {
                Console.WriteLine("hata: " + ex.Message.ToString());
            }
            //hata alsın almasın burası çalışır
            // finally
            // {
            //     Console.WriteLine("işlem başarılı");
            // }

            try
            {
               // int a = int.Parse(null);//nul ı int e çevirmeye çalışmak
                //int a = int.Parse("test");//formatException hatası alırız
                int a = int.Parse("-111111111111111111111");//int in kapasitesinin dışında bir veri gelirse
            }
            catch (ArgumentNullException ex)
            {
                //eğer ki hata ArgumentNullException hatası ise:
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);//exception objesini görelim
            }
            catch (FormatException ex)
            {
                //eğer ki hata FormatException hatası ise:
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(ex);//exception objesini görelim
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("çok büyük veya çok büyük değer girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı");
            }

            

        }
    }
}
