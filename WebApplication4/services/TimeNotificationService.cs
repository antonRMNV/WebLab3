namespace ASP3
{
    public class TimeNotificationService : ITimeNotificationService
    {
        public DateTime CurrentTime() => DateTime.Now;
        public string GetCurrentTime() => DateTime.Now.ToShortTimeString();

        public string GetNotification()
        {
            if (CurrentTime().TimeOfDay > new TimeSpan(12, 00, 00) &&
                CurrentTime().TimeOfDay < new TimeSpan(17, 59, 59))
                return "It is daytime!";
            else if (CurrentTime().TimeOfDay > new TimeSpan(18, 00, 00) &&
                CurrentTime().TimeOfDay < new TimeSpan(23, 59, 59))
                return "It is evening!";
            else if (CurrentTime().TimeOfDay > new TimeSpan(00, 00, 00) &&
                CurrentTime().TimeOfDay < new TimeSpan(5, 59, 59))
                return "It is night!";
            else
                return "It is morning!";
        }

    }
}

