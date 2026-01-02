using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.DTOs;
using back_end.models;
using Microsoft.CodeAnalysis;

namespace back_end.Mappers
{
    public static class DayMapper
    {
        public static NewDayDTO ToNewDayDTO(this Day dayModel)
        {
            return new NewDayDTO
            {
                Id = dayModel.Id,
                TimeSpent = dayModel.TimeSpent,
            };
        }

        public static Day ToDayFromNewDayDto(this NewDayDTO dayDTO, int ProjectId)
        {
            return new Day
            {
                TimeSpent=dayDTO.TimeSpent,
                ProjectId=ProjectId
            };
        }
    }
}