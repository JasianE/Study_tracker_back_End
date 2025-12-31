using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.DTOs;
using back_end.Interfaces;
using back_end.Mappers;
using back_end.models;
using back_end.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    [Route("api/day")]
    [ApiController]
    public class DayController : ControllerBase
    {
        private readonly IDayRepository _dayRepo;
        private readonly IProjectRepository _projectRepo;

        public DayController(ApplicationDBContext context, IDayRepository dayRepo, IProjectRepository projectRepo)
        {
            _dayRepo = dayRepo;
            _projectRepo = projectRepo;
        }

        [HttpPost("{projectId}")]
        public async Task<IActionResult> CreateDay([FromRoute] int projectId, [FromBody] NewDayDTO day)
        {
            if(_projectRepo.Exists(projectId) != null)
            {
                return BadRequest("Not found");
            } 

            var dayModel = day.ToDayFromNewDayDto(projectId);
            await _dayRepo.AddDayAsync(dayModel);
            return Ok("");

        }
        [HttpGet]
        public async Task<IActionResult> GetDays()
        {
            var days = await _dayRepo.GetDaysAsync();
            return Ok(days);
        }
    }
}