using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.DTOs;
using back_end.models;

namespace back_end.Mappers
{
    public static class DayMapper
    {
        public static NewDayDTO ToNewDayDTO(this Day dayModel)
        {
            return new NewDayDTO
            {
                Id = dayModel.Id,
                ProjectId = dayModel.ProjectId,
                TimeSpent = dayModel.TimeSpent,
                When = dayModel.When,
            };
        }
    }
}