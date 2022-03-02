using EcommerceCampaing.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EcommerceCampaign.Tests
{
    public class ProductTests
    {
        [Theory]
        [InlineData(null, null, null)]
        public void ProductNewObject(string name, int price, int stock)
        {
            Product product = new Product();
            Assert.Throws<ArgumentNullException>(() =>  product = new Product(name, price, stock));
        }
    }
}
