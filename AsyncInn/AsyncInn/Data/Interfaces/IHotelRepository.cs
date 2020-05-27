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
        Task<List<Hotel>> GetHotels();

        Task UpdateHotel(Hotel hotel);

        Task DeleteHotel(int id);
    }
}
