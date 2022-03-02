using EcommerceCampaing.Interfaces;

namespace EcommerceCampaing.Entites
{
    public class Campaing
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Limit { get; set; }
        public int TargetSales { get; set; }

    }
}
