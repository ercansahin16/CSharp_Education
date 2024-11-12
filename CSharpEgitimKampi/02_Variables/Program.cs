using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.OutputEncoding = Encoding.UTF8;
         #region Double Değişkenler

         Console.WriteLine("******************");

         //double apple = 14.5, orange = 20.9, strawbery = 15.7, potato = 5.99, tomato = 25.25;

         //Console.WriteLine("---- Elma Birim Fiyatı : " + apple + " ₺");
         //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawbery + " Tl");
         //Console.WriteLine("---- Patates Birim Fiyatı : " + potato + " Tl");
         //Console.WriteLine("---- Domates Birim Fiyatı : " + tomato + " Tl");
         //Console.WriteLine("******************");
         //double appleGram = 1.25, orangeGram = 2.9, strawberyGram = 1.7, potatoGram = 5.99, tomatoGram = 2.25;

         //Console.WriteLine("---- Toplam Elma Fiyatı : " + (apple * appleGram) + " ₺");
         //Console.WriteLine("---- Toplam Çilek  Fiyatı : " + (strawbery * strawberyGram) + " Tl");
         //Console.WriteLine("---- Toplam Patates  Fiyatı : " + (potato * potatoGram) + " Tl");
         //Console.WriteLine("---- Toplam Domates  Fiyatı : " + (tomato * tomatoGram) + " Tl");
         //Console.WriteLine("******************");
         //double totalprice = (apple * appleGram) + (strawbery * strawberyGram) + (potato * potatoGram) + (tomato * tomatoGram);
         //Console.WriteLine("Toplam Tutar : " + (totalprice));




         #endregion

         #region Char Değişkenler

         // string[] chars = { "Ali", "Ercan" };

         //for (int i = 0; i < chars.Length; i++) 
         // {
         //    for (int j = 0; j < chars[i].Length; j++) 
         //    {
         //       Console.Write(chars[i][j]);
         //    }
         // }

         #endregion

         #region Klavyeden Veri Girişi
         //string passengerName, passengerSurname,passengerCinsiyet,passengerage;
         //   Console.Write("Yolcu Adı : ");
         //passengerName = Console.ReadLine();
         //Console.Write("Yolcu Soyadı : ");
         //passengerSurname = Console.ReadLine();
         //Console.Write("Yolcu Cinsiyet  (E / K tuşlayınız) :");
         //passengerCinsiyet = Console.ReadLine().ToLower();

         //if (passengerCinsiyet=="e")
         //{
         //   Console.WriteLine("Merhaba " + passengerName.ToUpper() + " BEY");
         //       Console.Write("Lütfen yaşınızı Giriniz : ");
         //   passengerage = Console.ReadLine();
         //}
         //else
         //{
         //   Console.WriteLine("Merhaba " + passengerName.ToUpper() + " HANIM");
         //   Console.Write("Lütfen yaşınızı Giriniz : ");
         //   passengerage = Console.ReadLine();
         //}
         //Console.WriteLine("***-------------------------***");
         //Console.WriteLine("Aşağıdaki Bilgiler Doğrultusunda Bilet İşlemi gerçekleşmiştir.");
         //Console.WriteLine($"Adınız : {passengerName.ToUpper()}");
         //Console.WriteLine($"Soyadınız : {passengerSurname.ToUpper()}");
         //Console.WriteLine($"Yaşınız : {passengerage}");

         #endregion

         #region İnt Girişleri ve Dönüşümleri
         //int age;
         //   Console.Write("Lütfen Yaşınızı Giriniz :");
         //age =int.Parse( Console.ReadLine());
         //   Console.WriteLine(age);
         #endregion

         Console.ReadLine();
      }
   }
}
