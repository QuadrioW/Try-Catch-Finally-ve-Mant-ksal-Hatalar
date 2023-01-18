using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayi Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayi:" + " " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandi.");
            }

            try
            {
                // int a = int.Parse(null);
                //int a = int.Parse("Test");
                int a = int.Parse("-45785214785");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok Küçük ya da Çok Büyük Bir Değer Girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Başariyla Tamamlandi.");
            }
        }
    }
}