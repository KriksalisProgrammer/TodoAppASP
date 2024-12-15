using Microsoft.EntityFrameworkCore;
using TaskManager.Model;

namespace TaskManager.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
