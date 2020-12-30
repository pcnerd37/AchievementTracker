using System;
using System.Collections.Generic;
using System.Text;

namespace AchievementTracker
{
    class Project
    {
        public string ProjectName { get; set; }
        public int NumberOfTasks { get; set; }
        public double ProjectDuration { get; set; }
        public string ProjectStatus { get; set; }
        public List<Task> ProjectTasks;
        public DateTime DateCreated { get; set; }

    }
}
