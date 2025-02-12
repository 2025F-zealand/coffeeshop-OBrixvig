using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    class Order
    {
        public int OrderId { get; set; }
        public string Barista { get; set; }
        public string Customer { get; set; }
        public string TableId { get; set; }
        public List<Coffee> Coffees { get; set; } = new List<Coffee>();


        public int TotalPrice() => Coffees.Sum(c => c.Price());
        public int TotalItems() => Coffees.Count;
        public int TotalDiscount() => Coffees.Sum(c => c.Discount);
    }
}
