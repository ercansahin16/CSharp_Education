using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DateBaseProject
{
   public class Program
   {
      static void Main(string[] args)
      {

         //Ado.net
         string Number = "";



         Console.WriteLine("Veritabanlı Bilgi Sitemi");

         Console.WriteLine("-----------------------------");
         Console.WriteLine("1-Kategoriler");
         Console.WriteLine("2-Ürünler");
         Console.WriteLine("3-Siparişler");
         Console.WriteLine("4-ÇıkışYap");
         Console.WriteLine("Lütfen getirmek istediğiniz tablo numarası giriniz.");
         Console.WriteLine("-----------------------------");

         Number= Console.ReadLine();


         SqlConnection connection = new SqlConnection("Data Source=LENOVA20VE\\SQLEXPRESS;initial Catalog=CSharpEgitimKampi;integrated security=True;");
         connection.Open();
         SqlCommand command = new SqlCommand("select* from TblCategory",connection);
         SqlDataAdapter adapter = new SqlDataAdapter(command);
         DataTable dataTable = new DataTable();//Verilerimizi Ram Belleğe almamızı sağlıyor
         adapter.Fill(dataTable);//
         connection.Close();

         foreach (DataRow row in dataTable.Rows) 
         {
            foreach (var item in row.ItemArray ) 
            {
                    Console.Write(item.ToString());
            }
                Console.WriteLine();
         }

         Console.Read();
      }
   }
}
