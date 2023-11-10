using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static dz8.TaskManager;

namespace dz8
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string Initiator { get; set; }
        public string Executor { get; set; }
        public TaskStatus Status { get; set; }
        public List<Report> Reports { get; set; } = new List<Report>();
    }
}
