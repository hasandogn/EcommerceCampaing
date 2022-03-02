namespace EcommerceCampaing.Services
{
    public class DateTimeService
    {
        private static int TIME = 0;
        //public int IncreaseProcess(int price)
        //{

        //    return DateTime.UtcNow;
        //}
        public static int IncreaseTime(int hour)
        {
            TIME = TIME + hour;
            return TIME;
        }
    }
}
