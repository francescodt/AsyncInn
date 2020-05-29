using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.DTO
{
    public class HotelDTO
    {
        public long ID { get; set; }
        public string HotelName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public List<HotelRoomDTO> ROoms { get; set; }
    }
}
