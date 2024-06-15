
using System;
using System.Collections.Generic;

namespace CarParkingSystem.Services
{
    public class BookingService
    {
        private List<string> bookedSlots = new List<string>();

        public void BookSlot(int slotId, string vehicleNumber)
        {
            // Simplified booking logic
            bookedSlots.add($"Slot {slotId} booked for vehicle {vehicleNumber}");
            Console.WriteLine($"Slot {slotId} booked for vehicle {vehicleNumber}");
        }

        public void CancelBooking(int bookingId)
        {
            // Simplified cancel booking logic
            if (bookingId < bookedSlots.Count)
            {
                Console.WriteLine($"{bookedSlots[bookingId]} canceled.");
                bookedSlots.RemoveAt(bookingId);
            }
        }

        public List<string> GetBookedSlots()
        {
            return bookedSlots;
        }
    }
}
