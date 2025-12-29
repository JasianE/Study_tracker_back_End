using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.Interfaces;
using back_end.models;
using Microsoft.EntityFrameworkCore;

namespace back_end.Repositories
{
    public class DayRepository : IDayRepository
    {
        private readonly ApplicationDBContext _context;
        public DayRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Day> AddDay(Day day)
        {
            await _context.Day.AddAsync(day);
            await _context.SaveChangesAsync();

            return day; 

        }

        public async Task<List<Day>> GetDaysAsync()
        {
            return await _context.Day.ToListAsync();
        }
    }
}