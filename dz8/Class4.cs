using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8
{
    public class Project
    {
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Initiator { get; set; }
        public string ProjectLead { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public ProjectStatus Status { get; set; }

        public static implicit operator Project(Project v)
        {
            throw new NotImplementedException();
        }
    }

    public class ProjectStatus
    {
    }
}
