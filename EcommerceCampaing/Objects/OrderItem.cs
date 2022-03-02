namespace EcommerceCampaing.Objects
{
    public class OrderItem
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }

        public OrderItem(int quantity, string pCode)
        {
            Quantity = quantity;
            ProductCode = pCode;

            //validation rules will be here
        }

    }
}
