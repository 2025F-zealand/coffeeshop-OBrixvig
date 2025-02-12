using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
     class FlatWhite : Coffee, IMilk
    {
        public FlatWhite() : base()
        {

            coffeBlend = "Warm cow";
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
            return 45 - Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
        public int MlMilk()
        {
            return 150;
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }
}
