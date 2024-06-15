
using System.Collections.Generic;
using CarParkingSystem.Services;

namespace CarParkingSystem.ViewModels
{
    public class ParkingZoneViewModel
    {
        private ParkingZoneService parkingZoneService;

        public ParkingZoneViewModel()
        {
            parkingZoneService = new ParkingZoneService();
        }

        public void AddParkingZone(string zoneName)
        {
            parkingZoneService.AddParkingZone(zoneName);
        }

        public void RemoveParkingZone(int zoneId)
        {
            parkingZoneService.RemoveParkingZone(zoneId);
        }

        public List<string> GetParkingZones()
        {
            return parkingZoneService.GetParkingZones();
        }
    }
}
