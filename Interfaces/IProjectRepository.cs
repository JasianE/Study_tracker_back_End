using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.models;

namespace back_end.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project?> GetById(int id);

        Task<Project?> Delete(int id);
        Task<bool> Exists(int id);
    }
}