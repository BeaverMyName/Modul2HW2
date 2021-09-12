using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Services;

namespace OnlineShopping.Models
{
    public class Basket
    {
        private static readonly Basket _instance = new Basket();
        private readonly ConfigService _configService;
        private readonly Product[] _products;

        static Basket()
        {
        }

        private Basket()
        {
            _configService = new ConfigService();
            _products = new Product[_configService.BasketConfig.Size];
        }

        public static Basket Instance => _instance;

        public Product[] Products => _products;

        public double Sum
        {
            get
            {
                var sum = 0D;
                foreach (Product product in _products)
                {
                    if (product != null)
                    {
                        switch (product.Currency)
                        {
                            case Currency.UAH:
                                sum += product.Cost;
                                break;
                            case Currency.USD:
                                sum += product.Cost * _configService.CurrencyConfig.USDToUAH;
                                break;
                        }
                    }
                }

                return sum;
            }
        }
    }
}
