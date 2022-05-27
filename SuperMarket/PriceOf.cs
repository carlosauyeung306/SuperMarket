using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMarket
{
    public class PriceOf : IPriceOf
    {
        public static ProductA _productA = new ProductA() { Price = 50, SpecialUnit = 3, SpecialPrice = 130 };
        public static ProductB _productB = new ProductB() { Price = 30, SpecialUnit = 2, SpecialPrice = 45 };
        public static ProductC _productC = new ProductC() { Price = 20, SpecialUnit = 0, SpecialPrice = 0 };
        public static ProductD _productD = new ProductD() { Price = 15, SpecialUnit = 0, SpecialPrice = 0 };

        public int price_of(string input)
        {
            var products = input.ToCharArray().GroupBy(x => x).Select(g => new { ProductName = g.Key.ToString(), ProductCount = g.Count() });

            var totalPriceOfA = products.Any(x => x.ProductName == _productA.Item) ? _productA.GetTotalPrice(products.FirstOrDefault(x => x.ProductName == _productA.Item).ProductCount) : 0;
            var totalPriceOfB = products.Any(x => x.ProductName == _productB.Item) ? _productB.GetTotalPrice(products.FirstOrDefault(x => x.ProductName == _productB.Item).ProductCount) : 0;
            var totalPriceOfC = products.Any(x => x.ProductName == _productC.Item) ? _productC.GetTotalPrice(products.FirstOrDefault(x => x.ProductName == _productC.Item).ProductCount) : 0;
            var totalPriceOfD = products.Any(x => x.ProductName == _productD.Item) ? _productD.GetTotalPrice(products.FirstOrDefault(x => x.ProductName == _productD.Item).ProductCount) : 0;


            return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD;
        }
    }
}
