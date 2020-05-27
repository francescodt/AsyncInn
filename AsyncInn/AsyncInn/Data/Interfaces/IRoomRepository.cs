using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data.Interfaces
{
    public class IRoomRepository
    {

        Task<Room> CreateRoom(Room room);

        Task<Room> GetRoomById(long id);
        Task<List<Room>> GetRooms();

        Task<bool> UpdateRoom(long id, Room room);

        Task<Room> SaveNewRoom(Room room);
        
        Task<Room> DeleteRoom(long id);

        bool RoomExists(long id);
    }
}
