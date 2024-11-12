using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
   public class Program
   {
      static void Main(string[] args)
      {

         #region Foreach Loop

         //int[] nu = { 1, 2, 3, 4, 5 };

         //for (int i = 0; i < nu.Length; i++) { Console.WriteLine(i); }


         //int[] nu = { 1, 2, 3, 4, 5 };
         //int sum = 0;
         //foreach (int i in nu)
         //{

         //   sum += i;

         //}
         //Console.WriteLine(sum);//15



         #endregion


         #region Örnek Sınav Sistemi

         //int[] note = new int[2];

         //Console.WriteLine("Burada 2 sınav notunuzu alarak ortalamanızı bulamaya yarayacak :)");
         //int sum = 0;
         //for (int i = 0; i < note.Length; i++)
         //{
         //   Console.WriteLine($"Lütfen {i + 1}. Notu Giriniz:");
         //   note[i] = Convert.ToInt32(Console.ReadLine());
         //   sum += note[i];
         //}
         //   Console.WriteLine("Sonuç: "+ sum/note.Length);


         #endregion
         Console.ReadLine();
      }
   }
}
