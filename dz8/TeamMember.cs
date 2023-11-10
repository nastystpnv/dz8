using System;
using System.Collections.Generic; 

namespace dz8
{
    public class TeamMember
    {
        public string Name { get; set; }
        public List<Task> AssignedTasks { get; set; } = new List<Task>();
    }
}
