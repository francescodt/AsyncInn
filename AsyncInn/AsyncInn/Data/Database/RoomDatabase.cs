﻿using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AsyncInn.Data.Interfaces;

namespace AsyncInn.Data.Database
{
    public class RoomDatabase : IRoomRepository
    {
        private readonly AsyncInnDbContext _context;

        public RoomDatabase(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<Room> CreateRoom(Room room)
        {
            _context.Room.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> DeleteRoom(long id)
        {
            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return null;
            }
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> SaveNewRoom(Room room)
        {
            _context.Room.Add(room);
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> GetRoomById(long id)
        {
            return await _context.Room.FindAsync();
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Room.ToListAsync();
        }

        public async Task<bool> UpdateRoom(long id, Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

        }

        public bool RoomExists(long id)
        {
            return _context.Room.Any(e => e.ID == id);
        }
    }
}
