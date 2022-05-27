using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket
{
    public abstract class BaseProduct
    {
        protected string item;
        protected int price;
        protected int specialUnit;
        protected int specialPrice;

        //To be honest, the abstract is not necssary, but I only want to show the OO pricple for the demo.
        public abstract string Item
        {
            get; 
        }

        public abstract int Price
        {
            get; set;
        }

        public abstract int SpecialUnit
        {
            get; set;
        }

        public abstract int SpecialPrice
        {
            get; set;
        }

        public int GetTotalPrice(int count) {

            if (specialUnit == 0)
                return count * price;

            var numberOfspeicalOffer = count / specialUnit;
            var numberOfreminder =  count % specialUnit;

            return (numberOfspeicalOffer * SpecialPrice) + (numberOfreminder * price);
        }


    }
}
