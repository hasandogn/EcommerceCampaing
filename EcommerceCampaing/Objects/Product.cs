using EcommerceCampaing.Interfaces;

namespace EcommerceCampaing.Objects
{
    public class Product : IProduct
    {
        public string ProductCode { get; set; }
        public decimal Price { get; set; } = 0;
        public int Stock { get; set; } = 0;
        private decimal DiscountAmount { get; set; } = 0; 
        private decimal SumDiscountAmount { get; set; } = 0; 


        public Product() { }
        public Product(string productCode, decimal price, int stock)
        {
            if(productCode == null || price == null || stock == null)
            {
                throw new ArgumentNullException();
            }
            ProductCode = productCode;
            Price = price;
            Stock = stock;
        }

        public decimal CalculatePirce(int duration, int limit)
        {
            if(DiscountAmount == 0)
                DiscountAmount = ((Price / 100) * (limit/(duration-1)));
            if (duration >= 0)
            {
                SumDiscountAmount += DiscountAmount;
                Price = Price - DiscountAmount;
            }
            else 
                Price += SumDiscountAmount;
            return Price;
        } 

        public int StockDown(int amount)
        {
            if(amount >= 0)
                Stock = Stock - amount;
            return Stock;
        }
        public decimal SumProductPrice(decimal price, int amount)
        {
            decimal result = 0;
            if (price >= 0 && amount >= 0)
                result = price * amount;

            return result;
        }

        public void toString()
        {
            Console.WriteLine("Product " + ProductCode + " info; " + "price " + Price + "stock " + Stock);
        }
        
        public bool isThereStock(int quantity)
        {
            return Stock > quantity;
        }

    }
}
