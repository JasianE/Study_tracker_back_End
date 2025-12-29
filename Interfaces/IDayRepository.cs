using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.models;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Interfaces
{
    public interface IDayRepository
    {
        // IF hosted on aws or homelab then after every day
        // return a "day" object w/ the time studied for everything that day
        // Otherwise create a new "day" object everytime a session is completed
        // More like a "session object then" w/ a specific date for each time
        // Maybe it would be a good idea to have a session model that day can have multiple of?
        // nah
        // For stats it would filter through them all then, looking for a specific date

        Task<Day> AddDay(Day day);
        Task<List<Day>> GetDaysAsync();
        
    }
}