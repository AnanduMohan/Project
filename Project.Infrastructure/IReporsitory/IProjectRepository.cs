using Project.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.IReporsitory
{
    public interface IProjectRepository
    {
        Task<bool> CreateProject(ProjectEntity pro);
        Task<List<ProjectEntity>> GetAll();
    }
}
