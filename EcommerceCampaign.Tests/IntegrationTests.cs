using EcommerceCampaing.Enums;
using EcommerceCampaing.Modal;
using EcommerceCampaing.Objects;
using EcommerceCampaing.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EcommerceCampaign.Tests
{
    public class IntegrationTests
    {
        [Theory]
        [InlineData("P1", 100, 1000, "C1", 5,20,100)]
        public void AddProductAndAddCampaign(string productCode, int price, int stock, string campaignName, int duration, int limit, int targetSales)
        {
            CampaingService campaingService = new CampaingService();

            Product product = new Product(productCode, price, stock);
            var campaignInputModal = new CampaingInput {
                ProductCode = productCode,
                Name = campaignName,
                Duration = duration,
                Limit = limit,
                TargetSales = targetSales,
            };
            Campaing campaing = campaingService.Create(campaignInputModal, product);

            Assert.NotNull(campaing);
            Assert.Equal(95, product.Price);
            Assert.Equal(campaing.Status, CampaingEnums.Status.Continues);

        }
        [Theory]
        [InlineData("P1", 100, 1000, "C1", 5, 20, 100)]
        public async Task AddProductAndAddCampaignAndIncreaseTime(string productCode, int price, int stock, string campaignName, int duration, int limit, int targetSales)
        {
            CampaingService campaingService = new CampaingService();
            OrderService orderService = new OrderService();
            ProductService productService = new ProductService();

            Product product = new Product(productCode, price, stock);
            var campaignInputModal = new CampaingInput
            {
                ProductCode = productCode,
                Name = campaignName,
                Duration = duration,
                Limit = limit,
                TargetSales = targetSales,
            };
            Campaing campaing = campaingService.Create(campaignInputModal, product);


            campaingService.WhenIncreaseTıme(campaing, product, 1);
            Assert.Equal(90, product.Price);

            campaingService.WhenIncreaseTıme(campaing, product, 1);
            Assert.Equal(85, product.Price);

            campaingService.WhenIncreaseTıme(campaing, product, 1);
            Assert.Equal(80, product.Price);

            campaingService.WhenIncreaseTıme(campaing, product, 3);
            Assert.Equal(price, product.Price);

            Assert.Equal(campaing.Status, CampaingEnums.Status.Ended);
        }
    }
}
