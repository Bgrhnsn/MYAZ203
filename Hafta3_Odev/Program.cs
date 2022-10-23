using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Odev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product urun_1 = new Product() { Price = 150, ProductId = 1, ProductName = "Yag" };
            Product urun_2 = new Product() { Price = 60, ProductId = 2, ProductName = "Un" };
            Product urun_3 = new Product() { Price = 80, ProductId = 3, ProductName = "Seker" };
            Product urun_4 = new Product() { Price = 100, ProductId = 4, ProductName = "Pirinc" };



            CartItem item1 = new CartItem() { CartId = 1, Product = urun_1, Quantity = 2 };
            CartItem item2 = new CartItem() { CartId = 2, Product = urun_2, Quantity = 2 };
            CartItem item3 = new CartItem() { CartId = 3, Product = urun_3, Quantity = 5 };
            CartItem item4 = new CartItem() { CartId = 4, Product = urun_4, Quantity = 10 };


            ShoppingCart liste = new ShoppingCart();
            
            liste.Add(item1);
            liste.Add(item2);
            liste.Add(item3);
            liste.Add(item4);

            liste.GetBalance();
            liste.Getlist();

            Console.WriteLine(liste.GetBalance());

            liste.Remove(2);
           
            liste.GetBalance();
            liste.Getlist();
            

            Console.WriteLine(liste.GetBalance());

            Console.ReadLine();
        }
    }
}
