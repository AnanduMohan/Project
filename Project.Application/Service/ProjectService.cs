using Project.Application.DTO;
using Project.Application.IServices;
using Project.Domain.Entity;
using Project.Infrastructure.IReporsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository= projectRepository;
        }
        public async Task<CreateResponseDto> CreateProjectDto(ProjectDto dto)
        {
            try
            {
                var insert = new ProjectEntity();
                insert.ProjectCode = dto.ProjectCode;
                insert.ProjectName = dto.ProjectName;
                insert.ProjectComplexity = dto.ProjectComplexity;
                insert.ProjectStatus = dto.ProjectStatus;
                insert.ProjectOwner = dto.ProjectOwner;
                insert.ProjectStatus = dto.ProjectStatus;
                insert.EstimatedBudget = dto.EstimatedBudget;
                insert.StartDate = dto.StartDate;
                insert.EndDate = dto.EndDate;

                await _projectRepository.CreateProject(insert);
                return new CreateResponseDto
                {
                    ProjectCode = insert.ProjectCode,
                    ProjectName = insert.ProjectName,
                };
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public async Task<List<ProjectEntity>> GetAllProjects()
        {
            try
            {
                var result = await _projectRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
