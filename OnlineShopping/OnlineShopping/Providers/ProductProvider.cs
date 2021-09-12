using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Models;

namespace OnlineShopping.Providers
{
    public class ProductProvider
    {
        public ProductProvider()
        {
            Products[0] = new Product() { Name = "Dining Table", Cost = 1000, Currency = Currency.UAH, IsInStock = true };
            Products[1] = new Product() { Name = "Dining Chair", Cost = 600, Currency = Currency.UAH, IsInStock = true };
            Products[2] = new Product() { Name = "Console Table", Cost = 1200, Currency = Currency.UAH, IsInStock = true };
            Products[3] = new Product() { Name = "Double Bed", Cost = 7000, Currency = Currency.UAH, IsInStock = true };
            Products[4] = new Product() { Name = "Coffe Table", Cost = 2000, Currency = Currency.UAH, IsInStock = true };
            Products[5] = new Product() { Name = "King Size Bed", Cost = 20000, Currency = Currency.UAH, IsInStock = true };
            Products[6] = new Product() { Name = "Floor Lamp", Cost = 400, Currency = Currency.UAH, IsInStock = true };
            Products[7] = new Product() { Name = "Desk", Cost = 1200, Currency = Currency.UAH, IsInStock = true };
            Products[8] = new Product() { Name = "Outdoor Table", Cost = 700, Currency = Currency.UAH, IsInStock = true };
            Products[9] = new Product() { Name = "Badroom Chair", Cost = 500, Currency = Currency.UAH, IsInStock = true };
            Products[10] = new Product() { Name = "Office Chair", Cost = 20, Currency = Currency.USD, IsInStock = true };
            Products[11] = new Product() { Name = "2 Seater Sofa", Cost = 200, Currency = Currency.USD, IsInStock = true };
            Products[12] = new Product() { Name = "3 Seater Sofa", Cost = 300, Currency = Currency.USD, IsInStock = true };
            Products[13] = new Product() { Name = "4 Seater Sofa", Cost = 400, Currency = Currency.USD, IsInStock = true };
            Products[14] = new Product() { Name = "Wall Light", Cost = 10, Currency = Currency.USD, IsInStock = true };
            Products[15] = new Product() { Name = "Tub Chair", Cost = 30, Currency = Currency.USD, IsInStock = true };
            Products[16] = new Product() { Name = "Swivel Chair", Cost = 40, Currency = Currency.USD, IsInStock = true };
            Products[17] = new Product() { Name = "Corner Sofa", Cost = 250, Currency = Currency.USD, IsInStock = true };
            Products[18] = new Product() { Name = "Wooden Bed", Cost = 600, Currency = Currency.USD, IsInStock = true };
            Products[19] = new Product() { Name = "Metal Bed", Cost = 400, Currency = Currency.USD, IsInStock = true };
        }

        public Product[] Products { get; set; } = new Product[20];
    }
}
