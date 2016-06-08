using System;
using Microsoft.EntityFrameworkCore;

namespace netcoretask
{
    public class TaskViewModel {

        public TaskViewModel(){

            TaskContext dbcontext = new TaskContext(DbContextOptions.);
        }

        public string Customer { get; set; }
        public string Description { get; set; }

        public int TaskType { get; set; }

        public DateTime CompletedDate { get; set; }
    }
}