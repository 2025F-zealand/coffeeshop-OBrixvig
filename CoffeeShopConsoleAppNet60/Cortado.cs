using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    class Cortado : Coffee, IMilk
    {

        public Cortado()
        {
            coffeBlend = "Espresso";
        }
        public int MlMilk()
        {
            return 40;
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
            return 25 - Discount;
        }
        public override string Strength()
        {
            return "Medium"; 
        }

        public override string GetInfo()
        {
            return "Prisen: " + Convert.ToString(Price()) + "dkk, Kaffe styrke " + Strength() + "Milk: " + MlMilk();
        }
    }
}
