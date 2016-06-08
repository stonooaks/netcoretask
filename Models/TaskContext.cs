using Microsoft.EntityFrameworkCore;

namespace netcoretask
{
    public class TaskContext : DbContext {

        public TaskContext(DbContextOptions options) : base(options) {}
        public DbSet<Task> Task { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<TaskType> TaskType { get; set; }
    }
}