using Microsoft.EntityFrameworkCore;
using Project.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public class Dbcontext:DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options) { }
        public DbSet<ProjectEntity> ProjectEntity { get; set; }
    }
}
