using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Models;

namespace OnlineShopping.Services
{
    public class OrderService
    {
        public Order Order { get; set; }

        public bool DoOrder(UserService userService, BasketService basketService)
        {
            var sum = basketService.Basket.Sum;
            if (userService.Withdraw(sum))
            {
                basketService.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
