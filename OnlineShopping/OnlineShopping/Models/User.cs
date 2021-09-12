using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class User
    {
        public string Name { get; init; }
        public double Money { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
