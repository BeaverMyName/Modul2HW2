using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Product
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; init; }
        public Currency Currency { get; init; }
        public double Cost { get; set; }
        public bool IsInStock { get; set; }
    }
}
