using EcommerceCampaing.Enums;

namespace EcommerceCampaing.Modal
{
    public class CampaingOutput
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int Duration { get; set; }
        public int Limit { get; set; }
        public int TargetSales { get; set; }
        public int TotalSales { get; set; }
        public decimal TurnOver { get; set; }
        public CampaingEnums.Status Status { get; set; } = CampaingEnums.Status.Continues;
        public decimal AvaragePrice { get; set; }
    }

    public class CampaingInput
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int Duration { get; set; }
        public int Limit { get; set; }
        public int TargetSales { get; set; }
    }
}
