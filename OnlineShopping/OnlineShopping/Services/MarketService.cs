using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Providers;

namespace OnlineShopping.Services
{
    public class MarketService
    {
        public void TakeRandomProducts(ProductProvider productProvider, BasketService basketService)
        {
            var random = new Random();
            var marketProducts = productProvider.Products;
            var basketProducts = basketService.Basket.Products;
            var length = basketProducts.Length;
            var pointer = 0;
            for (var i = 0; i < length;)
            {
                pointer = random.Next(length);
                if (marketProducts[pointer].IsInStock)
                {
                    basketService.AddProduct(marketProducts[pointer]);
                    marketProducts[pointer].IsInStock = false;
                    i++;
                }
            }
        }
    }
}
