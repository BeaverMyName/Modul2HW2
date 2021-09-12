using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Models;

namespace OnlineShopping.Services
{
    public class NotificationService
    {
        public void Notificate(int code, User user)
        {
            if (user.PhoneNumber != null)
            {
                PhoneNotificate(code);
            }

            if (user.Email != null)
            {
                EmailNotificate(code);
            }
        }

        private void EmailNotificate(int code)
        {
            Console.WriteLine($"Notification by email with code: {code}");
        }

        private void PhoneNotificate(int code)
        {
            Console.WriteLine($"Notification by phone with code: {code}");
        }
    }
}
