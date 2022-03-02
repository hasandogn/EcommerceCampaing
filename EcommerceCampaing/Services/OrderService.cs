using EcommerceCampaing.Modal;
using EcommerceCampaing.Objects;

namespace EcommerceCampaing.Services
{
    public class OrderService
    {
        public decimal SumPrice(decimal price, int amount)
        {
            decimal result = price * amount;

            return result;
        }

        public void CreateOrder(OrderInput input, Product product, Campaing campaing = null)
        {
            if (product.isThereStock(input.Quantity))
            {
                product.StockDown(input.Quantity);

                if (campaing != null)
                {
                    campaing.UpTotalSales(input.Quantity);
                    campaing.CalculateTurnOver(input.Price, input.Quantity);
                    campaing.CalculateAverage();
                }

                //Console.WriteLine("Order created; product " + product.ProductCode + ", quantity " + input.Quantity);
            }
            throw new NotImplementedException();

        }
    }
}
