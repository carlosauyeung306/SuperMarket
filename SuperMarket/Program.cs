using System;
using System.Collections;
using System.Linq;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Please enter the price of (Enter 'End' for termination'):");

                string input = Console.ReadLine();

                if (input == "End")
                {
                    Environment.Exit(0);
                }

                IPriceOf priceOf = new PriceOf();
                var totalPrice = priceOf.price_of(input); 

                Console.WriteLine("The total price is :" + totalPrice);

            }
        }

    }
}
