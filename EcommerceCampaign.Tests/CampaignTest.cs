using EcommerceCampaing.Modal;
using EcommerceCampaing.Objects;
using EcommerceCampaing.Services;
using System;
using Xunit;

namespace EcommerceCampaign.Tests
{
    public class CampaignTest
    {
        //private  CampaingService _campaingService;
        //private  OrderService _orderService;
        //private  ProductService _productService;

        //public CampaignTest(CampaingService campaingService, OrderService orderService, ProductService productService)
        //{
        //    _campaingService = campaingService;
        //    _orderService = orderService;
        //    _productService = productService;
        //}

        CampaingService campaingService = new CampaingService();
        OrderService orderService = new OrderService();
        ProductService productService = new ProductService();

        Product product = new Product("P1", 100, 1000);
        Campaing campaign = new Campaing();
       


        //CampaingService campaingService= new CampaingService();
        //private readonly 
        [Fact]
        public void IsNotNullCampaign()
        {
            var inputModel = new CampaingInput
            {
                ProductCode = product.ProductCode,
                Name = "C1",
                Duration = 10,
                Limit = 10,
                TargetSales = 1000
            };
            //inputCampaign.ProductCode = product.ProductCode;
            //inputCampaign.Name = "C1";
            //inputCampaign.Duration = 10;
            //inputCampaign.Limit = 20;
            //inputCampaign.TargetSales = 1000;
            campaign = campaingService.Create(inputModel, product);

            Assert.NotNull(campaign);
        }

      

        //[Theory]
        //[InlineData("")]

        //[Fact]
        //public void IsNotNullCampaign()
        //{
        //    inputCampaign.ProductCode = product.ProductCode;
        //    inputCampaign.Name = "C1";
        //    inputCampaign.Duration = 10;
        //    inputCampaign.Limit = 20;
        //    inputCampaign.TargetSales = 1000;
        //    campaign = campaingService.Create(inputCampaign, product);

        //    Assert.NotNull(campaign);
        //}
    }
}