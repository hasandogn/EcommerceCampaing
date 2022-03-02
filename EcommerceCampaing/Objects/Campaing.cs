using EcommerceCampaing.Enums;
using EcommerceCampaing.Interfaces;
using EcommerceCampaing.Modal;
using EcommerceCampaing.UnitOfWork;

namespace EcommerceCampaing.Objects
{
    public class Campaing : ICampaing
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int Duration { get; set; }
        public int Limit { get; set; }
        public int TargetSales { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalSales { get; set; }
        public decimal TurnOver { get; set; }
        public CampaingEnums.Status Status { get; set; } = CampaingEnums.Status.Continues;
        public decimal AvaragePrice { get; set; }

        public Campaing() { }
        public Campaing(CampaingInput input)
        {
            Name = input.Name;
            ProductCode = input.ProductCode;
            Duration = input.Duration;
            Limit = input.Limit;
            TargetSales = input.TargetSales;
            StartDate = DateTimeFactory._dateTime;
            EndDate = StartDate.AddHours(Duration);
        }

        public void ChangeStatusEnded()
        {
            Status = CampaingEnums.Status.Ended;
        }

        public void UpTotalSales(int amount)
        {
            if(amount > 0)
                TotalSales += amount; 
        }

        public void CalculateTurnOver(decimal price,int quantity)
        {
            if(quantity > 0 && price > 0)
                TurnOver += price * quantity;
        }

        public void CalculateAverage()
        {
            if(TotalSales > 0)
                AvaragePrice = TurnOver / TotalSales;
        }

        public bool isEnded()
        {
            if(Status == CampaingEnums.Status.Ended)
                return true;
            return false;
        }

        public void DurationDown(int hour)
        {
            Duration -= hour;
            if(Duration <= 0)
            {
                Status = CampaingEnums.Status.Ended;
            }
        }

        public void AddedHourStartDate(int hour)
        {
            if(hour >= 0)
                StartDate = StartDate.AddHours(hour);
        }

        public void toString()
        {
            Console.WriteLine("Campaign created; name "
             + Name
             + ", product "
             + ProductCode
             + ", duration "
             + Duration
             + ", limit"
             + Limit
             + ", target sales count "
             + TargetSales);
        }
        public void toStringInfo()
        {
            Console.WriteLine("Campaign"
             + Name
             + "info; status "
             + Status.ToString()
             + ", target sales count "
             + TargetSales
             + "i total sales "
             + TotalSales
             + ", Turnover " 
             + TurnOver 
             + ", Avarage Item Price "
             + AvaragePrice);
        }

    }
}
