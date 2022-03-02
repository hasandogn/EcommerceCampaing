namespace EcommerceCampaing.Modal
{
    public class ProductInfoOutput
    {
        public decimal Price { get; set; } = 0;
        public int Stock { get; set; } = 0;
    }

    public class ProductOutput
    {
        public string ProductCode { get; set; }
        public decimal Price { get; set; } = 0;
        public int Stock { get; set; } = 0;
    }
    public class ProductInput
    {
        public string ProductCode { get; set; }
        public decimal Price { get; set; } = 0;
        public int Stock { get; set; } = 0;
    }

}
