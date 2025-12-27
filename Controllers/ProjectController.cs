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
    [Route("api/project")]
    [ApiController]

    public class ProjectController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IProjectRepository _projectRepo;
        public ProjectController(ApplicationDBContext context, IProjectRepository projectRepo)
        {
            _context = context; //Dependency injection
            _projectRepo = projectRepo;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var Projects = await _projectRepo.GetAllAsync();

            return Ok(Projects);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var Project = await _projectRepo.GetById(id);
            if(Project == null)
            {
                return NotFound();
            } 
            return Ok(Project);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Project project)
        {
            await _context.AddAsync(project);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new {id = project.Id}, project);
        }
        [HttpDelete]
        [Route("{id}")]

        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            Project? project = await _projectRepo.Delete(id);
            if(project == null)
            {
                return NotFound();
            } 
            return Ok(project);
        }

        
    }
}