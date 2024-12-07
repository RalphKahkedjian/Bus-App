namespace YandexBus
{
    public interface IBusAttributes
    {
        // Declared two attributes and 1 operation
        int DriverExperience { get; set; } 
        string BusType { get; set; }
        void ShowDetails();
    }
}
