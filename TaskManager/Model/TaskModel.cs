using System.ComponentModel.DataAnnotations;

namespace TaskManager.Model
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
