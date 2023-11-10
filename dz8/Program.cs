using System;
using System.Collections.Generic;

namespace dz8
{
    public class TaskManager
    {
        public enum ProjectStatus
        {
            Project,
            Execution,
            Closed
        }
        public enum TaskStatus
        {
            Assigned,
            InProgress,
            Verification,
            Completed
        }
        static void Main(string[] args)
        {
            List<TeamMember> team = new List<TeamMember>
        {
            new TeamMember { Name = "лиза жоская" },
            new TeamMember { Name = "маратик" },
            new TeamMember { Name = "борис" },
            new TeamMember { Name = "егорка" },
            new TeamMember { Name = "илюшка" },
            new TeamMember { Name = "амирчик" },
            new TeamMember { Name = "олежа" },
            new TeamMember { Name = "дарья" },
            new TeamMember { Name = "диана" },
            new TeamMember { Name = "лешка" },
        };
            Project project = new Project
            {
                Description = "организация катика",
                Deadline = DateTime.Now.AddMonths(1),
                Initiator = "илон маск",
                ProjectLead = "нэстистпнв",
                Status = ProjectStatus.Project
            };
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "забронировать дом",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report = new Report
            {
                Text = "выполнено первое задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report);

            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "закупить еду",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report1 = new Report
            {
                Text = "выполнено второе задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report1);
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "закупить алкоголь",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report2 = new Report
            {
                Text = "выполнено третье задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report2);
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "отправить приглашения",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report3 = new Report
            {
                Text = "выполнено четвертое задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report3);
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "украсить дом",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report4 = new Report
            {
                Text = "выполнено пятое задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report4);
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "заказать такси",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report5 = new Report
            {
                Text = "выполнено шестое задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report5);
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "заказать тамаду",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report6 = new Report
            {
                Text = "выполнено седьмое задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report6);
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "нанять фотографа",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report7 = new Report
            {
                Text = "выполнено восьмое задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report7);
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "выложить истории в инст",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report8 = new Report
            {
                Text = "выполнено девятое задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report8);
            foreach (var member in team)
            {
                Task task = new Task
                {
                    Description = "спеть песню",
                    Deadline = DateTime.Now.AddMonths(1),
                    Initiator = "нэстистпнв",
                    Executor = $"задача для {member.Name}",
                    Status = TaskStatus.Assigned
                };

                member.AssignedTasks.Add(task);
                project.Tasks.Add(task);
            }

            team[0].AssignedTasks[0].Status = TaskStatus.InProgress;
            Report report9 = new Report
            {
                Text = "выполнено десятое задание",
                CompletionDate = DateTime.Now,
                Performer = team[0].Name
            };

            team[0].AssignedTasks[0].Reports.Add(report9);
            foreach (var member in team)
            {
                Console.WriteLine("член: " +  member.Name);
                member.AssignedTasks.ForEach(x => Console.WriteLine("описание задачи: " + x.Description));
            }
            Console.ReadKey();
        }
    }
}
