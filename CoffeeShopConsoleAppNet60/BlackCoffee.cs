using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    class BlackCoffee : Coffee
    {
        public BlackCoffee()
        {
            coffeBlend = "Grinded beans";
        }

        public override int Price()
        {
            try
            {
                Discount = 5;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 20 - Discount;

        }

        public override string Strength()
        {
            return "strong";
        }

        public override string GetInfo()
        {
            return "Prisen: " + Convert.ToString(Price()) + "Kaffe styrke" + Strength();
        }
    }
}
