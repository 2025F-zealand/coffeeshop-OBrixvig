using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    class OrderSystem
    {
        private List<Order> Orders = new List<Order>();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public int TotalRevenue() => Orders.Sum(order => order.TotalPrice());
        public int TotalOrders() => Orders.Count;
        public int TotalCoffeesSold() => Orders.Sum(order => order.TotalItems());

        public void PrintOrders()
        {
            foreach (var order in Orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Customer: {order.Customer}, Total Price: {order.TotalPrice()} DKK");
            }
        }

    }
}
