using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Models;

namespace AsyncInn.Data.Interfaces
{
    public interface IHotelRepository
    {

        Task<Hotel> CreateHotel(Hotel hotel);

        Task<Hotel> GetHotelById(long id);
        
        Task<bool> UpdateHotel(long id, Hotel hotel);
        Task<Hotel> SaveNewHotel(Hotel hotel);

        Task<Hotel> DeleteHotel(long id);

        bool HotelExists(long id);
    }
}
