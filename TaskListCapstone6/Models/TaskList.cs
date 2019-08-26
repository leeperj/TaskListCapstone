using System;
using System.Collections.Generic;

namespace TaskListCapstone6.Models
{
    public partial class TaskList
    {
        public string UserId { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Completed { get; set; }
        public int TaskId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
