using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Services;
using OnlineShopping.Models;
using OnlineShopping.Providers;

namespace OnlineShopping
{
    public class Starter
    {
        private readonly UserService _userService;
        private readonly BasketService _basketService;
        private readonly OrderService _orderService;
        private readonly NotificationService _notificationService;
        private readonly User _user;
        private readonly MarketService _marketService;
        private readonly ProductProvider _productProvider;

        public Starter()
        {
            _userService = new UserService() { User = new User() { Name = "Igor", Money = 99999999.99D, PhoneNumber = "+380436541234", Email = "igor.bobro.lul@gmail.com" } };
            _basketService = new BasketService();
            _orderService = new OrderService();
            _notificationService = new NotificationService();
            _user = _userService.User;
            _marketService = new MarketService();
            _productProvider = new ProductProvider();
        }

        public void Run()
        {
            _marketService.TakeRandomProducts(_productProvider, _basketService);

            if (_orderService.DoOrder(_userService, _basketService))
            {
                _orderService.Order = new Order() { Code = new Random().Next(10000000, 99999999) };

                var code = _orderService.Order.Code;

                _notificationService.Notificate(code, _user);
            }
        }
    }
}
