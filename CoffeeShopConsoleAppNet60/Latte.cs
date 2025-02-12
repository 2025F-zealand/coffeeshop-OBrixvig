using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    class Latte : Coffee , IMilk
    {

        public Latte()
        {
            coffeBlend = "Latte";
        }
        public int MlMilk()
        {
            return 200;
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
            return 40 - Discount;
        }
        public override string Strength()
        {
            return "Weak";
        }

        public override string GetInfo()
        {
            return "Prisen: " + Convert.ToString(Price()) + " dkk\n" + "Kaffe styrke: " + Strength() + "\n Milk: " + MlMilk() + " Ml.\n" ;
        }
    }
}
