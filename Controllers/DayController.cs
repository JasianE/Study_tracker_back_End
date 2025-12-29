using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.Interfaces;
using back_end.models;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    [Route("api/day")]
    [ApiController]
    public class DayController : ControllerBase
    {
        private readonly IDayRepository _dayRepo;

        public DayController(ApplicationDBContext context, IDayRepository dayRepo)
        {
            _dayRepo = dayRepo;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDay([FromBody] Day day)
        {
            Day result = await _dayRepo.AddDay(day);
            return Ok(result);
        }
    }
}