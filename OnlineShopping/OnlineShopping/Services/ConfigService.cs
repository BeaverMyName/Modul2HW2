using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Models;

namespace OnlineShopping.Services
{
    public class ConfigService
    {
        private readonly Config _config;

        public ConfigService()
        {
            _config = new Config() { BasketConfig = new BasketConfig(), CurrencyConfig = new CurrencyConfig() };
            _config.BasketConfig.Size = 10;

            // были времена
            _config.CurrencyConfig.USDToUAH = 5;
        }

        public BasketConfig BasketConfig => _config.BasketConfig;
        public CurrencyConfig CurrencyConfig => _config.CurrencyConfig;
    }
}
