using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Odev
{
    public class ShoppingCart
    {
       public  List<CartItem> products;

        public ShoppingCart()
        {
            products = new List<CartItem>();    
        }
        public ShoppingCart(CartItem products)
        {
            Add(products);
        }
        public void Add(CartItem productsa)
        {
            products.Add(productsa);
           
        }
        public string GetBalance()
        {
            double price = 0;
            foreach (var item in products)
            {
                price += item.Product.Price * item.Quantity;
            }
            return ($"Toplam Tutar : {price}");

        }
        public void Getlist()
        {
            foreach (var item in products)
                Console.WriteLine(item);
        }
        public void Remove(int Id)
        {
            var removed = products.FirstOrDefault(a => a.CartId == Id);
            if (removed == null)
            {
                Console.WriteLine("Ardadiginiz Urun Bulunamadi...");
                return;
            }
            products.Remove(removed);
            Console.WriteLine(Id+" Numarali Urun Cikarildi...");
        }

    }
}
