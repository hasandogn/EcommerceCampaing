using EcommerceCampaing.Interfaces;
using Microsoft.AspNetCore.Http;

namespace EcommerceCampaing.Objects
{
    public class Order : IOrder
    {
        public DateTime OrderDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; private set; }

        public Order() { }
        public Order(ICollection<OrderItem> orderItems)
        {
            OrderDate = DateTime.Now;
            OrderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));
        }

        public void AddOrderItem(int quantity, string productCode)
        {
            if(quantity > 0 && productCode != null)
            {
                OrderItem item = new OrderItem(quantity, productCode);

                OrderItems.Add(item);

                Console.WriteLine("ekleme yapıldı: " + OrderItems);
            }
          
        }
    }
}
