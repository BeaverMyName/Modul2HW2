using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Models;

namespace OnlineShopping.Services
{
    public class UserService
    {
        public User User { get; init; }

        public bool Withdraw(double sum)
        {
            if (User.Money >= sum)
            {
                User.Money -= sum;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
