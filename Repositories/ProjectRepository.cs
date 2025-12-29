using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.Interfaces;
using back_end.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace back_end.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDBContext _context;

        public ProjectRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Project?> Delete(int id)
        {
            Project? project = await _context.Project.FirstOrDefaultAsync(x => x.Id == id);
            if (project != null)
            {
                _context.Project.Remove(project);
                _context.SaveChanges();
            }
            return project;
        }

        public async Task<List<Project>> GetAllAsync()
        {
            return await _context.Project.ToListAsync();
        }

        public async Task<Project?> GetById(int id)
        {
            return await _context.Project.FirstOrDefaultAsync(x => x.Id == id);
        }
        
    }
}