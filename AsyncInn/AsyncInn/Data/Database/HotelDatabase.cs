﻿using AsyncInn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AsyncInn.Data.Interfaces;

namespace AsyncInn.Data.Database
{
    public class HotelDatabase : IHotelRepository
    {
        private readonly AsyncInnDbContext _context;

        public HotelDatabase(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            _context.Hotel.Add(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task<Hotel> GetHotelById(long id)
        {
            return await _context.Hotel.FindAsync(id);
        }

        public async Task<Hotel> SaveNewHotel(Hotel hotel)
        {
            _context.Hotel.Add(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task<Hotel> DeleteHotel(long id)
        {
            var hotel = await _context.Hotel.FindAsync(id);
            if (hotel == null)
            {
                return null;
            }

            _context.Hotel.Remove(hotel);
            await _context.SaveChangesAsync();

            return hotel;
        }

        public async Task<bool> UpdateHotel(long id, Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public bool HotelExists(long id)
        {
            return _context.Hotel.Any(e => e.ID == id);
        }
    }
}
