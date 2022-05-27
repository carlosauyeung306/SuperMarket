using SuperMarket;
using System;
using Xunit;
using Moq;

namespace SuperMarketTest
{
    public class UnitTest1
    {
        private readonly Mock<PriceOf> _PriceOf;

        public UnitTest1() {
            _PriceOf = new Mock<PriceOf>();
        }

        [Fact]
        public void Request_TestCase1()
        {
            var result = _PriceOf.Object.price_of("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Request_TestCase2()
        {
            var result = _PriceOf.Object.price_of("A");
            Assert.Equal(50, result);
        }

        [Fact]
        public void Request_TestCase3()
        {
            var result = _PriceOf.Object.price_of("AB");
            Assert.Equal(80, result);
        }

        [Fact]
        public void Request_TestCase4()
        {
            var result = _PriceOf.Object.price_of("CDBA");
            Assert.Equal(115, result);
        }

        [Fact]
        public void Request_TestCase5()
        {
            var result = _PriceOf.Object.price_of("AA");
            Assert.Equal(100, result);
        }

        [Fact]
        public void Request_TestCase6()
        {
            var result = _PriceOf.Object.price_of("AAA");
            Assert.Equal(130, result);
        }

        [Fact]
        public void Request_TestCase7()
        {
            var result = _PriceOf.Object.price_of("AAABB");
            Assert.Equal(175, result);
        }


        [Fact]
        public void NoOffer_TestCase()
        {
            var result = _PriceOf.Object.price_of("C"); 
            Assert.Equal(20, result);
        }

        [Fact]
        public void NoOffer_TwoItem_TestCase()
        {
            var result = _PriceOf.Object.price_of("CD");
            Assert.Equal(35, result);
        }

        [Fact]
        public void TwoOfferNotHhaveReminder_OneItem_TestCase()
        {
            var result = _PriceOf.Object.price_of("BBBB");
            Assert.Equal(90, result);
        }

        [Fact]
        public void TwoOfferHhaveReminder_OneItem_TestCase()
        {
            var result = _PriceOf.Object.price_of("BBBBB");
            Assert.Equal(120, result);
        }


        [Fact]
        public void TwoOfferNotHhaveReminder_TwoItem_TestCase()
        {
            var result = _PriceOf.Object.price_of("BBBBAAAAAA");
            //45+45+130+130
            Assert.Equal(350, result);
        }

        [Fact]
        public void TwoOfferHhaveReminder_TwoItem_TestCase()
        {
            var result = _PriceOf.Object.price_of("BBBBBAAAAAAA");
            //45 + 45 + 30 + 130 + 130 +  50
            Assert.Equal(430, result);
        }
    }


}
