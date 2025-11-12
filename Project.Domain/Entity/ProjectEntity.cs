using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entity
{
    public class ProjectEntity
    {
        [Key]
        public long Id { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectStatus { get; set; }
        public decimal EstimatedBudget { get; set; }
        public string ProjectComplexity { get; set; }
        public string ProjectOwner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
