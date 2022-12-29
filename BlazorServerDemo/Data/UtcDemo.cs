namespace BlazorServerDemo.Data
{
    public class UTCDemo : IDemo ,IUtcDemo
    {
        public DateTime StartupTime { get; init; }

        public UTCDemo()
        {
            StartupTime = DateTime.UtcNow;
        }
    }
}
