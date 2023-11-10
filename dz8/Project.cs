using System;
using System.Collections.Generic;
using static dz8.TaskManager;

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
          
    }

}
