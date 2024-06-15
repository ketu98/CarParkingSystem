
using System.Collections.Generic;
using CarParkingSystem.Services;

namespace CarParkingSystem.ViewModels
{
    public class BookingViewModel
    {
        private BookingService bookingService;

        public BookingViewModel()
        {
            bookingService = new BookingService();
        }

        public void BookSlot(int slotId, string vehicleNumber)
        {
            bookingService.BookSlot(slotId, vehicleNumber);
        }

        public void CancelBooking(int bookingId)
        {
            bookingService.CancelBooking(bookingId);
        }

        public List<string> GetBookedSlots()
        {
            return bookingService.GetBookedSlots();
        }
    }
}
