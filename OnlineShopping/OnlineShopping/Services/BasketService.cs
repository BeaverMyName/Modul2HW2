using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Models;

namespace OnlineShopping.Services
{
    public class BasketService
    {
        public Basket Basket => Basket.Instance;

        public void AddProduct(Product product)
        {
            for (var i = 0; i < Basket.Products.Length; i++)
            {
                if (Basket.Products[i] == null)
                {
                    Basket.Products[i] = product;
                    product.IsInStock = false;
                }
            }
        }

        public void Clear()
        {
            for (var i = 0; i < Basket.Products.Length; i++)
            {
                Basket.Products[i] = null;
            }
        }
    }
}
