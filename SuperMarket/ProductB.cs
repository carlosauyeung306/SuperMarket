using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket
{
    public class ProductB : BaseProduct
    {
        public override string Item
        {
            get
            {
                return "B";
            }
        }

        public override int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public override int SpecialUnit
        {
            get
            {
                return specialUnit;
            }
            set
            {
                specialUnit = value;
            }
        }

        public override int SpecialPrice
        {
            get
            {
                return specialPrice;
            }
            set
            {
                specialPrice = value;
            }
        }
    }
}
