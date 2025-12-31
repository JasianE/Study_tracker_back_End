using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.DTOs;
using back_end.Interfaces;
using back_end.Mappers;
using back_end.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace back_end.Repositories
{
    public class DayRepository : IDayRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IProjectRepository _project;
        public DayRepository(ApplicationDBContext context, IProjectRepository project)
        {
            _context = context;
            _project = project;
        }

        public async Task<Day> AddDayAsync(Day day)
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