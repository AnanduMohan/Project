using Microsoft.EntityFrameworkCore;
using Project.Domain.Entity;
using Project.Infrastructure.IReporsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly Dbcontext _dbcontext;
        public ProjectRepository(Dbcontext dbcontext) 
        {
            _dbcontext= dbcontext;
        }
        public async Task<bool> CreateProject(ProjectEntity pro)
        {
            try
            {

                await _dbcontext.ProjectEntity.AddAsync(pro);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public async Task<List<ProjectEntity>> GetAll()
        {
            try
            {
                var result = new List<ProjectEntity>();
                result = await _dbcontext.ProjectEntity.ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
