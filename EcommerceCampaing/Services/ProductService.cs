using EcommerceCampaing.Modal;
using EcommerceCampaing.Objects;

namespace EcommerceCampaing.Services
{
    public class ProductService
    {
        //public int WhenIncreaseTımeCalculatePrice(Product product,bool isEndedCampaign)
        //{
        //    int result = 0;
        //    if (!isEndedCampaign)
        //    {
        //        product
        //    }
        //}

        public Product CreateProduct(string productName, decimal price, int stock)
        {
            Product product = new Product(productName, price, stock);

            return product;
        }

        public int WhenEndedCampaignPrice(int price, int limit)
        {
            int result = price + limit;
            return result;
        }

        //public string ProductInfo()
        //{

        //}
    }
}
