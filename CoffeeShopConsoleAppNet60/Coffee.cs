using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    abstract class Coffee
    {
        private int _discount;

        protected string coffeBlend;
        public int Discount
        {
            get { return _discount; }
            set
            {
                if (value < 0 || value > 6)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Det er for meget rabat. Max 5,- ");
                }
                _discount = value;
            }
        }

        public Coffee()
        {
            coffeBlend = "Filter"; 
            Discount = 0;
        }

        public virtual int Price()
        {
            return  20;
        }
        public virtual string Strength()
        {
            return "";
        }

        public virtual string GetInfo()
        {
            return  "Prisen: " + Convert.ToString(Price()) + "\nStyrke " + Strength() + "\nKaffebønne " + coffeBlend ;
        }
    }
}
