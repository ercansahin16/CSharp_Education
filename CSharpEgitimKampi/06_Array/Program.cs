using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Array
{
   public class Program
   {
      static void Main(string[] args)
      {
         #region Temel Dizi Örnekleri

         //string[] color = new string[4];

         //color[0] = "Sarı";
         //color[1] = "Kırmızı";
         //Console.Write(color[1]);

         //int[] number= new int[10];

         //number[0] = 1;
         //number[1] = 2;
         //number[2] = 3;

         //Console.WriteLine(number[4]*2);//0

         #endregion

         #region Dizideki Tüm eleemanları listeleme

         //string[] color = { "sarı", "kırmızı", "beyaz", "Yeşil" };

         //for(int i=0;i<color.Length;i++)
         //{
         //   Console.WriteLine(color[i]);
         //}




         #endregion


         #region Dizi Metotları

         //string[] persons = { "Ayşe", "Ali", "Ercan" };
         //var person = Array.IndexOf(persons, "Ercan");
         //   Console.WriteLine(person);//2




         #endregion


         #region Kullanıcıdan değer alma

         //string[] city = new string[5];
         //Console.WriteLine("Lütfen 5 adet şehir ismi Giriniz");
         //for (int i = 0; i < city.Length; i++)
         //{
         //   Console.WriteLine($"Lütfen {i+1}.  şehir ismi Giriniz");
         //   city[i]= Console.ReadLine();
         //}
         //   Console.WriteLine("---------------------------------");
         //   Console.WriteLine("Girdiğiniz iller : ");
         //foreach(string i in city) 
         //{
         //       Console.WriteLine("  ");
         //       Console.Write(i);
         //}
         #endregion
         Console.Read();
      }
   }
}
