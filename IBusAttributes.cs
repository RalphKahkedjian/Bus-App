namespace YandexBus
{
    public interface IBusAttributes
    {
        int DriverExperience { get; set; } 
        string BusType { get; set; }
        void ShowDetails();
    }
}
