namespace EcommerceCampaing.UnitOfWork
{
    public class DateTimeFactory
    {
        public static readonly DateTime _dateTime = DateTime.UtcNow;

        public static DateTime Increase()
        {

            return _dateTime.AddHours(1);
        }

    }
}
