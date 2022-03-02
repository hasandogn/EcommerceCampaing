using EcommerceCampaing.Modal;
using EcommerceCampaing.Objects;

namespace EcommerceCampaing.Services
{
    public class CampaingService
    {
        public Campaing Create(CampaingInput input, Product product)
        {
            Campaing campaing = new Campaing(input);
            product.CalculatePirce(input.Duration, input.Limit);

            return campaing;
        }


        public void WhenIncreaseTıme(Campaing campaing, Product product, int hour)
        {
            while(hour > 0)
            {
                DateTimeService.IncreaseTime(1);
                campaing.DurationDown(1);
                product.CalculatePirce(campaing.Duration, campaing.Limit);
                hour--;
            }
           
        }

        public CampaingOutput CampaignInfo(Campaing campaing)
        {
            CampaingOutput output = new CampaingOutput();
            output.Status = campaing.Status;
            campaing.CalculateAverage();
            output.AvaragePrice = campaing.AvaragePrice;
            output.Name = campaing.Name;
            output.TargetSales = campaing.TargetSales;
            output.TotalSales = campaing.TotalSales;
            output.TurnOver = campaing.TurnOver;

            Console.WriteLine("Campaign"
            + output.Name
            + "info; status "
            + output.Status.ToString()
            + ", target sales count "
            + output.TargetSales
            + "i total sales "
            + output.TotalSales
            + ", Turnover "
            + output.TurnOver
            + ", Avarage Item Price "
            + output.AvaragePrice);

            return output;
        }

    }
}
