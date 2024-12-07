using System.Collections.Generic;

namespace YandexBus
{
    public interface IHistoryManager
    {
        void AddBooking(string driverName, int busId, Location location);
        void ShowHistory();
    }
}
// Interface with 2 operations
