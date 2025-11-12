using Project.Application.DTO;
using Project.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.IServices
{
    public interface IProjectService
    {
        Task<CreateResponseDto> CreateProjectDto(ProjectDto dto);
        Task<List<ProjectEntity>> GetAllProjects();
    }
}
