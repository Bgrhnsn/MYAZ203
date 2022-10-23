using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_Odev
{
    public class CartItem
    {
        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return ($"Urun numarasi : { Product.ProductId} Urun Adi :  { Product.ProductName}  Fiyat : { Product.Price}   Adet :  { Quantity}");
        }

        
    }
}
