
using System;
using System.Collections.Generic;

namespace CarParkingSystem.Services
{
    public class ParkingZoneService
    {
        private List<string> parkingZones = new List<string>();

        public void AddParkingZone(string zoneName)
        {
            // Simplified add parking zone logic
            parkingZones.Add(zoneName);
            Console.WriteLine($"Parking zone {zoneName} added.");
        }

        public void RemoveParkingZone(int zoneId)
        {
            // Simplified remove parking zone logic
            if (zoneId < parkingZones.Count)
            {
                Console.WriteLine($"{parkingZones[zoneId]} removed.");
                parkingZones.RemoveAt(zoneId);
            }
        }

        public List<string> GetParkingZones()
        {
            return parkingZones;
        }
    }
}
